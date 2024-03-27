using FindJobApplication.DB;
using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Daos
{
    public class UserProfileDao
    {
        private Database db = null;

        public UserProfileDao()
        {
            db = new Database();
        }

        public DataTable findAll()
        {
            string sqlStr = "select * from user_profile;";
            return db.Read(sqlStr);
        }

        public UserProfile findUserById(int id)
        {
            UserProfile userProfile = new UserProfile();
            string sqlStr = $"select * from user_profile where id={id};";
            DataRow dr = db.Read(sqlStr).Rows[0];
            userProfile.Id = (int)dr["id"];
            userProfile.UserAccId = (int)dr["user_account_id"];
            userProfile.Name = dr["name"].ToString();
            userProfile.Email = dr["email"].ToString();
            userProfile.PhoneNumber = dr["phone_number"].ToString();
            userProfile.DateOfBirth = (DateTime)dr["date_of_birth"];
            userProfile.Gender = dr["gender"].ToString();
            userProfile.Address = dr["address"].ToString();
            userProfile.PersonalLink = dr["personal_link"].ToString();
            userProfile.UserImage = dr["user_image"].ToString();
            userProfile.AboutMe = dr["about_me"].ToString();
            userProfile.Title = dr["title"].ToString();

            sqlStr = $"select * from user_education where user_profile_id={id};";
            DataTable dt = db.Read(sqlStr);
            foreach (DataRow row in dt.Rows)
            {
                UserEducation userEducation = new UserEducation(
                    (int)row["user_profile_id"],
                    row["school_name"].ToString(),
                    row["major"].ToString(),
                    (DateTime)row["from"],
                    (DateTime)row["to"],
                    row["additional_details"].ToString()
                );
                userProfile.UserEducations.Add(userEducation);
            }

            sqlStr = $"select * from user_work_experience where user_profile_id={id};";
            dt = db.Read(sqlStr);
            foreach (DataRow row in dt.Rows)
            {
                UserWorkExperience userWorkExperience = new UserWorkExperience(
                    (int)row["user_profile_id"],
                    row["job_title"].ToString(),
                    row["company_name"].ToString(),
                    (DateTime)row["from"],
                    (DateTime)row["to"]
                );

                userProfile.UserWorkExperiences.Add(userWorkExperience);
            }

            sqlStr = $"select * from user_personal_project where user_profile_id={id};";
            dt = db.Read(sqlStr);
            foreach (DataRow row in dt.Rows)
            {
                UserPersonalProject userPersonalProject = new UserPersonalProject(
                    (int)row["user_profile_id"],
                    row["project_name"].ToString(),
                    (DateTime)row["from"],
                    (DateTime)row["to"],
                    row["description"].ToString()
                );

                userProfile.UserPersonalProjects.Add(userPersonalProject);
            }

            sqlStr = $"select * from user_skill, skill where user_skill.user_profile_id = {id} and user_skill.skill_id = skill.id;;";
            dt = db.Read(sqlStr);
            foreach (DataRow row in dt.Rows)
            {
                UserSkill userSkill = new UserSkill(
                    (int)row["user_profile_id"],
                    (int)row["skill_id"],
                    row["name"].ToString()
                );

                userProfile.UserSkills.Add(userSkill);
            }

            return userProfile;
        }

        public DataRow findUserByAccountId(int id)
        {
            string sqlStr = $"select * from user_profile where user_account_id={id};";
            return (DataRow)db.Read(sqlStr).Rows[0];
        }
    }
}
