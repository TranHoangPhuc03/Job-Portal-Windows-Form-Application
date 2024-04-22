using FindJobApplication.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Daos
{
    public class TopTrendingDao
    {
        private Database db = null;

        public TopTrendingDao() 
        {
            db = new Database();
        }
        public DataTable TopFiveJobTrending()
        {
            string sqlStr = @"SELECT TOP 5 job_post_id, title as nameTop, COUNT(job_post_id) AS cnt \r\nFROM user_apply_job \r\nINNER JOIN job_post ON job_post_id = id \r\nGROUP BY job_post_id, title \r\nORDER BY cnt DESC";
            return db.Read(sqlStr);
        }
        public DataTable TopFiveCompanyTrending() 
        {
            string sqlStr = $"SELECT TOP 5 account_followed as idCompany, company_profile.name as nameTop ,count(account_followed) as cnt\r\nfrom following inner join account\r\non account_followed = id \r\ninner join company_profile\r\non id = account_id\r\nwhere account.role = 'company'\r\ngroup by account_followed, company_profile.name\r\norder by cnt DESC;";
            return db.Read(sqlStr);

        }
    }
}
