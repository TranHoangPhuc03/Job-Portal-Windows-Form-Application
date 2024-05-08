using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using FindJobApplication.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.Entity;
using static System.Windows.Forms.Design.AxImporter;

namespace FindJobApplication.Daos
{
    public class UserProfileDao
    {
        private QLXinViecDFContext db = null;

        public UserProfileDao()
        {
            db = new QLXinViecDFContext();
        }

        public ICollection<UserProfile> FindAllUserProfile()
        {
            var results = db.UserProfiles.ToList();

            return results.ToList();
        }

        public UserProfile FindUserProfileByAccountId(int userId)
        {
            var result = db.UserProfiles.Single(row => row.Id == userId);

            return result;
        }

        public ICollection<Account> FindAllCompanyFollowingByUser(int userId)
        {
            var results = db.Accounts
                    .Where(row => row.Id == userId)
                    .SelectMany(row => row.Account1)
                    .ToList();
            return results;
        }

        public int SaveUserFollowJob(int userId, int jobPostId)
        {
            var userProfile = FindUserProfileByAccountId(userId);
            var jobPost = db.JobPosts.Find(jobPostId);
            userProfile.JobPosts.Add(jobPost);
            return db.SaveChanges();
        }
        public int UpdateUserProfile(UserProfile userProfile)
        {
            db.Entry(userProfile).State = EntityState.Modified;
            return db.SaveChanges();
        }
     
        public int DeleteUserFollowJob(int userId, int jobPostId)
        {
            var userProfile = FindUserProfileByAccountId(userId);
            var jobPost = db.JobPosts.Find(jobPostId);
            userProfile.JobPosts.Remove(jobPost);
            db.UserProfiles.Attach(userProfile);
            return db.SaveChanges();
        }
        public int DeleteUserEducation(int userEducationId)
        {
            var result = db.UserEducations.Find(userEducationId);
            db.UserEducations.Attach(result);
            db.UserEducations.Remove(result);
            return db.SaveChanges();
        }
        public int DeleteUserWorkExperience(int userWorkExperienceId)
        {
            var result = db.UserWorkExperiences.Find(userWorkExperienceId);
            db.UserWorkExperiences.Attach(result);
            db.UserWorkExperiences.Remove(result);
            return db.SaveChanges();
        }
        public int DeleteUserPersonalProject(int userPersonalProjectId)
        {
            var result = db.UserPersonalProjects.Find(userPersonalProjectId);
            db.UserPersonalProjects.Attach(result);
            db.UserPersonalProjects.Remove(result);
            return db.SaveChanges();
        }
        public void DeleteAllUserSkills(UserProfile userProfile)
        {
            db.UserProfiles.Attach(userProfile);
            userProfile.Skills.Clear();
            db.SaveChanges();
        }
    }
}
