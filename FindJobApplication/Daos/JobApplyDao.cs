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

        public int saveUserApplyJob(DateTime appliedAt, int userId, int jobId, string status = "PENDING", string coverLetter = "")
        {
            string sqlStr = $"insert into user_apply_job(user_id, job_post_id, status, cover_letter, applied_at) values ({userId}, {jobId}, '{status}', '{coverLetter}', '{appliedAt.ToString("yyyy-MM-dd HH:mm:ss")}');";
            return db.Excute(sqlStr);
        }

        public DataTable findByUserAppliedIdAndJobPostId(int userId, int jobPostId)
        {
            string sqlStr = $"select user_apply_job.*, user_profile.name, job_post.title from user_apply_job, user_profile, job_post where user_apply_job.user_id = {userId} and user_apply_job.job_post_id = {jobPostId} and user_apply_job.user_id = user_profile.id and user_apply_job.job_post_id = job_post.id;";
            return db.Read(sqlStr);
        }
    }
}
