using FindJobApplication.DB;
using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindJobApplication.Mappers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace FindJobApplication.Daos
{
    public class UserProfileDao
    {
        private Database db = null;

        public UserProfileDao()
        {
            db = new Database();
        }

        public List<UserProfile> FindAllUserProfile()
        {
            string sqlStr = "SELECT * FROM user_profile;";
                          
            DataTable dt = db.Read(sqlStr);
            List<UserProfile> list = new List<UserProfile>();

            foreach (DataRow dr in dt.Rows)
            {
                UserProfile userProfile = UserProfileMapper.MapToModel(dr);
                userProfile.UserEducations.AddRange(this.FindUserEducationByUserId(userProfile.Id));
                userProfile.UserWorkExperiences.AddRange(this.FindUserWorkExperienceByUserId(userProfile.Id));
                userProfile.UserPersonalProjects.AddRange(this.FindUserPersonalProjectByUserId(userProfile.Id));
                userProfile.UserSkills.AddRange(this.FindUserSkillByUserId(userProfile.Id));

                list.Add(userProfile);
                
            }

            return list;
        }
        public UserProfile FindUserProfileById(int userId)
        {
            string sqlStr = "SELECT * FROM user_profile WHERE id = @UserId;";
            Dictionary<string, object> parameters = new Dictionary<string, object> { { "@UserId", userId } };

            DataRow dr = db.Read(sqlStr, parameters).Rows.Cast<DataRow>().FirstOrDefault();
            UserProfile userProfile = UserProfileMapper.MapToModel(dr);
            userProfile.UserEducations.AddRange(this.FindUserEducationByUserId(userProfile.Id));
            userProfile.UserWorkExperiences.AddRange(this.FindUserWorkExperienceByUserId(userProfile.Id));
            userProfile.UserPersonalProjects.AddRange(this.FindUserPersonalProjectByUserId(userProfile.Id));
            userProfile.UserSkills.AddRange(this.FindUserSkillByUserId(userProfile.Id));

            return userProfile;
        }
        public int FindUserIdByAccountId(int accountId)
        {
            string sqlStr = "SELECT id FROM user_profile WHERE company_account_id = @AccountId;";
            Dictionary<string, object> parameters = new Dictionary<string, object> { { "@AccountId", accountId } };
            return (int)db.ExecuteScalar(sqlStr, parameters);
        }
        public List<UserEducation> FindUserEducationByUserId(int userId)
        {
            string sqlStr = "SELECT * FROM user_education WHERE user_profile_id = @UserProfileId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UserProfileId", userId },
            };

            List<UserEducation> list = new List<UserEducation> ();
            DataTable dt = db.Read(sqlStr, parameters);
            foreach (DataRow dr in dt.Rows)
                list.Add(UserEducationMapper.MapToModel(dr));

            return list;
        }
        public List<UserWorkExperience> FindUserWorkExperienceByUserId(int userId)
        {
            string sqlStr = "SELECT * FROM user_work_experience WHERE user_profile_id = @UserProfileId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UserProfileId", userId },
            };

            List<UserWorkExperience> list = new List<UserWorkExperience>();
            DataTable dt = db.Read(sqlStr, parameters);
            foreach (DataRow dr in dt.Rows)
                list.Add(UserWorkExperienceMapper.MapToModel(dr));

            return list;
        }
        public List<UserPersonalProject> FindUserPersonalProjectByUserId(int userId)
        {
            string sqlStr = "SELECT * FROM user_personal_project WHERE user_profile_id = @UserProfileId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UserProfileId", userId },
            };

            List<UserPersonalProject> list = new List<UserPersonalProject>();
            DataTable dt = db.Read(sqlStr, parameters);
            foreach (DataRow dr in dt.Rows)
                list.Add(UserPersonalProjectMapper.MapToModel(dr));

            return list;
        }
        public List<UserSkill> FindUserSkillByUserId(int userId)
        {
            string sqlStr = @"
                            SELECT
	                            user_skill.user_profile_id,
	                            skill.id AS skill_id,
                                skill.name AS skill_name
                            FROM 
	                            user_skill
                            INNER JOIN skill on user_skill.skill_id = skill.id
                            WHERE user_skill.user_profile_id = @UserProfileId";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UserProfileId", userId },
            };

            List<UserSkill> list = new List<UserSkill>();
            DataTable dt = db.Read(sqlStr, parameters);
            foreach (DataRow dr in dt.Rows)
                list.Add(UserSkillMapper.MapToModel(dr));

            return list;
        }
        //Saving after submit sign up form
        public int SaveUserSignUp(UserProfile userProfile, string password)
        {
            string sqlStr = @"
                            EXEC usp_RegisterUserAccount
                                @Email,
                                @Password,
                                @Name;";
             Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "@Email", userProfile.Email },
                { "@Password", password },
                { "@Name", userProfile.Name }
            };
            return db.Excute(sqlStr, parameters);
        }
        public int SaveUserApplyJob(JobApplyDetail jobApplyDetail)
        {
            string sqlStr = @"
                            INSERT INTO user_apply_job
                            VALUES (@UserId, @JobPostId, @Status, @CoverLetter, @AppliedAt, @CVAttach)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UserId", jobApplyDetail.UserId },
                { "@JobPostId", jobApplyDetail.JobPostId },
                { "@Status", jobApplyDetail.Status },
                { "@CoverLetter", jobApplyDetail.CoverLetter },
                { "@AppliedAt", jobApplyDetail.AppliedAt },
                { "@CVAttach", jobApplyDetail.CVAttach }
            };

            return db.Excute(sqlStr, parameters);
        }
        public int SaveUserEducation(UserEducation userEducation)
        {
            string sqlStr = @"
                            INSERT INTO user_education (user_profile_id, school_name, major, [from], [to], additional_details)
                            VALUES (@UserProfileId, @SchoolName, @Major, @From, @To, @AdditionalDetail)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UserProfileId", userEducation.UserProfileId },
                { "@SchoolName", userEducation.SchoolName },
                { "@Major", userEducation.Major },
                { "@From", userEducation.From },
                { "@To", userEducation.To },
                { "@AdditionalDetail", userEducation.AdditionalDetail }
            };

            return db.Excute(sqlStr, parameters);
        }
        public int SaveUserWorkExperience(UserWorkExperience userWorkExperience)
        {
            string sqlStr = @"
                            INSERT INTO user_work_experience (user_profile_id, job_title, company_name, [from], [to])
                            VALUES (@UserProfileId, @JobTitle, @CompanyName, @From, @To)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UserProfileId", userWorkExperience.UserProfileId },
                { "@JobTitle", userWorkExperience.JobTitle },
                { "@CompanyName", userWorkExperience.CompanyName },
                { "@From", userWorkExperience.From },
                { "@To", userWorkExperience.To },
            };

            return db.Excute(sqlStr, parameters);
        }
        public int SaveUserPersonalProject(UserPersonalProject userPersonalProject)
        {
            string sqlStr = @"
                            INSERT INTO user_personal_project (user_profile_id, project_name, [from], [to], description)
                            VALUES (@UserProfileId, @ProjectName, @From, @To, @Description)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UserProfileId", userPersonalProject.UserProfileId },
                { "@ProjectName", userPersonalProject.ProjectName },
                { "@From", userPersonalProject.From },
                { "@To", userPersonalProject.To },
                { "@Description", userPersonalProject.Description },
            };

            return db.Excute(sqlStr, parameters);
        }
        public int SaveUserSkill(UserSkill userSkill)
        {
            string sqlStr = @"
                            INSERT INTO user_skill (user_profile_id, skill_id)
                            VALUES (@UserProfileId, @SkillId);";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UserProfileId", userSkill.UserProfileId },
                { "@SkillId", userSkill.SkillId }
            };

            return db.Excute(sqlStr, parameters);
        }
        //User Infomation = Name, Birthday, Phone number, Avatar, ...
        public int UpdateUserInformation(UserProfile userProfile)
        {
            string sqlStr = @"
                            UPDATE user_profile
                            SET name = @Name, email = @Email, phone_number = @PhoneNumber, date_of_birth = @DateOfBirth, gender = @Gender, address = @Address, personal_link = @PersonalLink, about_me = @AboutMe, title = @Title
                            WHERE id = @Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Name", userProfile.Name },
                { "@Email", userProfile.Email },
                { "@PhoneNumber", userProfile.PhoneNumber },
                { "@DateOfBirth", userProfile.DateOfBirth },
                { "@Gender", userProfile.Gender },
                { "@Address", userProfile.Address },
                { "@PersonalLink", userProfile.PersonalLink },
                { "@AboutMe", userProfile.AboutMe },
                { "@Title", userProfile.Title },
                { "@Id", userProfile.Id }
            };

            return db.Excute(sqlStr, parameters);
        }
        public int UpdateUserEducation(UserEducation userEducation)
        {
            string sqlStr = @"
                            UPDATE user_education
                            SET school_name = @SchoolName, major = @Major, from = @From, to = @To, addtional_details = @AdditionalDetails
                            WHERE id = @Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Id", userEducation.Id },
                { "@SchoolName", userEducation.SchoolName },
                { "@Major", userEducation.Major },
                { "@From", userEducation.From },
                { "@To", userEducation.To },
                { "@AdditionalDetail", userEducation.AdditionalDetail }
            };

            return db.Excute(sqlStr, parameters);
        }
        public int UpdateUserWorkExperience(UserWorkExperience userWorkExperience)
        {
            string sqlStr = @"
                            UPDATE user_work_experience
                            SET job_title = @JobTitle, company_name = @CompanyName, from = @From, to = @To
                            WHERE id = @Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Id", userWorkExperience.Id },
                { "@JobTitle", userWorkExperience.JobTitle },
                { "@CompanyName", userWorkExperience.CompanyName },
                { "@From", userWorkExperience.From },
                { "@To", userWorkExperience.To },
            };

            return db.Excute(sqlStr, parameters);
        }
        public int UpdateUserPersonalProject(UserPersonalProject userPersonalProject)
        {
            string sqlStr = @"
                            UPDATE user_personal_project
                            SET project_name = @ProjectName, from = @From, to = @To, description = @Description
                            WHERE id = @Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Id", userPersonalProject.Id },
                { "@ProjectName", userPersonalProject.ProjectName },
                { "@From", userPersonalProject.From },
                { "@To", userPersonalProject.To },
                { "@Description", userPersonalProject.Description },
            };

            return db.Excute(sqlStr, parameters);
        }
        public int DeleteUserSkill(UserSkill userSkill)
        {
            string sqlStr = @"DELETE FROM user_skill WHERE user_profile_id = @UserProfileId AND skill_id = @SkillId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UserProfileId", userSkill.UserProfileId },
                { "@SkillId", userSkill.SkillId }
            };

            return db.Excute(sqlStr, parameters);
        }
        public int DeleteUserEducation(UserEducation userEducation)
        {
            string sqlStr = "DELETE FROM user_education WHERE id = @Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Id", userEducation.Id }
            };

            return db.Excute(sqlStr, parameters);
        }
        public int DeleteUserWorkExperience(UserWorkExperience userWorkExperience)
        {
            string sqlStr = "DELETE FROM user_work_experience WHERE id = @Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Id", userWorkExperience.Id }
            };

            return db.Excute(sqlStr, parameters);
        }
        public int DeleteUserPersonalProject(UserPersonalProject userPersonalProject)
        {
            string sqlStr = "DELETE FROM user_personal_project WHERE id = @Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Id", userPersonalProject.Id }
            };

            return db.Excute(sqlStr, parameters);
        }
        public int SaveNewFavouriteJob(int jobPostId, int userId)
        {
            string sqlStr = @"
                            INSERT INTO user_favourite_job(user_id, job_post_id)
                            VALUES (@UserId, @JobPostId);";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UserId", userId },
                { "@JobPostId", jobPostId }
            };

            return db.Excute(sqlStr, parameters);
        }
        public int SaveNewFollowingCompany(int userAccountId, int companyAccountId)
        {
            string sqlStr = @"
                            INSERT INTO following(company_id, user_id)
                            VALUES (@CompanyAccountId, @UserAccountId);";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@CompanyAccountId", companyAccountId },
                { "@UserAccountId", companyAccountId }
            };

            return db.Excute(sqlStr, parameters);
        }
        public List<int> FindAllJobPostIdFavourite(int userId)
        {
            string sqlStr = @"SELECT job_post_id
                            FROM user_favourite_job
                            WHERE user_id = @UserId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UserId", userId },
            };

            DataTable dt = db.Read(sqlStr, parameters);
            List<int> list = new List<int>();
            foreach (DataRow dr in dt.Rows)
                list.Add(Convert.ToInt32(dr["job_post_id"]));

            return list;
        }
        public List<int> FindAllCompanyIdFollowing(int userAccountId)
        {
            string sqlStr = @"
                            SELECT company_id
                            FROM following
                            WHERE user_id = @UserAccountId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UserAccountId", userAccountId },
            };

            DataTable dt = db.Read(sqlStr, parameters);
            List<int> list = new List<int>();
            foreach (DataRow dr in dt.Rows)
                list.Add(Convert.ToInt32(dr["company_id"]));

            return list;
        }
        public int DeleteFavouriteJob(int jobPostId, int userId) 
        {
            string sqlStr = @"
                            DELETE FROM user_favourite_job
                            WHERE user_id = @UserId AND job_post_id = @JobPostId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UserId", userId },
                { "@JobPostId", jobPostId }
            };

            return db.Excute(sqlStr, parameters);
        }
        public int DeleteFollowingCompany(int companyAccoutnId, int userAccountId)
        {
            string sqlStr = @"
                            DELETE FROM following
                            WHERE company_id = @CompanyAccountId AND user_id = @UserAccountId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@CompanyAccountId", companyAccoutnId },
                { "@UserAccountId", userAccountId }
            };

            return db.Excute(sqlStr, parameters);
        }
    }
}
