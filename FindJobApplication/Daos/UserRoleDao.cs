using FindJobApplication.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Daos
{
    internal class UserRoleDao
    {
        private Database db = null;

        public UserRoleDao()
        {
            db = new Database();
        }

        public DataRow findUserRoleById(int id)
        {
            string sqlStr = $"select role_name from user_role where id={id}";
            DataTable results = db.Read(sqlStr);
            if (results.Rows.Count > 0)
            {
                return results.Rows[0];
            }

            return null;
        }
    }
}
