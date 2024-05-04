using FindJobApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Daos
{
    public enum StatusName
    {
        Appropriate,
        Pending,
        InterviewInvited,
        Interviewing,
        Declined,
        Approved
    }

    public class JobApplyDao
    {
        private QLXinViecDFContext db = null;
        public JobApplyDao()
        {
            db = new QLXinViecDFContext();
        }
        public int SaveUserApplyJob(UserApplyJob userApplyJob)
        {
            db.UserApplyJobs.Add(userApplyJob);
            return db.SaveChanges();
        }

        public int UpdateUserApplyStatus(ICollection<UserApplyJob> userApplyJobs, StatusName status)
        {
            if (userApplyJobs.Count == 0)
            {
                return 0;
            }

            foreach (var user in userApplyJobs)
            {
                user.StatusId = (int)status + 1;
            }

            return db.SaveChanges();
        }

        public ICollection<UserApplyJob> FindAllUserApply(int jobPostId)
        {
            var results = db.UserApplyJobs.
                        Where(row => row.JobPostId == jobPostId)
                        .ToList();
            return results;
        }

        public ICollection<UserApplyJob> FilterUserApplyJobByStatus(int jobPostId, StatusName status)
        {
            var results = db.UserApplyJobs
                    .Where(row => row.StatusId  == (int)status+1 && row.JobPostId == jobPostId)
                    .ToList();
            return results;
        }
    }
}
