using FindJobApplication.DB;
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

        public DataRow findUserById(int id)
        {
            string sqlStr = String.Format("select * from user_profile where id={0}", id);
            return (DataRow)db.Read(sqlStr).Rows[0];
        }

        public DataRow findUserByAccountId(int id)
        {
            string sqlStr = $"select * from user_profile where user_account_id={id};";
            return (DataRow)db.Read(sqlStr).Rows[0];
        }
    }
}
