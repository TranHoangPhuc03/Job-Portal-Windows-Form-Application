using FindJobApplication.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Daos
{
    public class JobApplyDao
    {
        private Database db = null;

        public JobApplyDao()
        {
            db = new Database();
        }

        public int SaveUserApplyJob(DateTime appliedAt, int userId, int jobPostId, string status = "PENDING", string coverLetter = "")
        {
            string sqlStr = "INSERT INTO user_apply_job(user_id, job_post_id, status, cover_letter, applied_at) VALUES (@UserId, @JobPostId, @Status, @CoverLetter, @AppliedAt);";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UserId", userId },
                { "@JobPostId", jobPostId },
                { "@Status", status },
                { "@CoverLetter", coverLetter },
                { "@AppliedAt", appliedAt }
            };

            return db.Execute(sqlStr, parameters);
        }

        public DataTable FindUserApplyJob(int userId, int jobPostId)
        {
            string sqlStr = $"SELECT user_apply_job.*, user_profile.name, job_post.title from user_apply_job, user_profile, job_post WHERE user_apply_job.user_id = {userId} and user_apply_job.job_post_id = {jobPostId} and user_apply_job.user_id = user_profile.id and user_apply_job.job_post_id = job_post.id;";
            return db.Read(sqlStr);
        }
        public DataTable TopFiveJobTrending()
        {
            string sqlStr = $"SELECT TOP 5 job_post_id, title, COUNT(job_post_id) AS number_of_apply \r\nFROM user_apply_job \r\nINNER JOIN job_post ON job_post_id = id\r\nGROUP BY user_apply_job.job_post_id, job_post.title \r\nORDER BY number_of_apply DESC\r\n";
            return db.Read(sqlStr);
        }
        public int UpdateUserApplyStatus(int userId, int jobPostId, string status)
        {
            string sqlStr = "UPDATE user_apply_job SET status = @Status WHERE user_id = @UserId AND job_post_id = @JobPostId";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Status", status },
                { "@UserId", userId },
                { "@JobPostId", jobPostId}
            };

            return db.Execute(sqlStr, parameters);
        }
    }
}
