using FindJobApplication.DB;
using System;
using System.Collections.Generic;
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
            string sqlStr = $"insert into user_apply_job values ({userId}, {jobId}, '{status}', '{coverLetter}', '{appliedAt.ToString("yyyy-MM-dd HH:mm:ss")}');";
            return db.Excute(sqlStr);
        }
    }
}
