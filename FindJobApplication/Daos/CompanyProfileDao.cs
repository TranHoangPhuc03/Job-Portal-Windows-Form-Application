using FindJobApplication.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Daos
{
    public class CompanyProfileDao
    {
        private Database db = null;

        public CompanyProfileDao()
        {
            db = new Database();
        }

        public DataTable findAll()
        {
            string sqlStr = "select * from company_profile;";
            return db.Read(sqlStr);
        }

        public DataRow findCompanyById (int id)
        {
            string sqlStr = String.Format("select * from compayny_profile where id={0}", id);
            return (DataRow) db.Read(sqlStr).Rows[0];
        }

        public DataRow findCompanyByAccountId(int id)
        {
            string sqlStr = $"select * from company_profile where company_account_id={id};";
            return (DataRow)db.Read(sqlStr).Rows[0];
        }
    }
}
