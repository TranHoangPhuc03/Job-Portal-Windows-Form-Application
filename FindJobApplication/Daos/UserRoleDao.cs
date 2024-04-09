using FindJobApplication.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindJobApplication.Daos
{
    internal class UserRoleDao
    {
        private Database db = null;

        public UserRoleDao()
        {
            db = new Database();
        }

        public string FindUserRoleById(int id)
        {
            string sqlStr = "SELECT role_name FROM user_role WHERE id = @Id;";
            Dictionary<string, object> parameters = new Dictionary<string, object> { { "@Id", id } };
            DataTable results = db.Read(sqlStr, parameters);

            if (results.Rows.Count > 0)
            {
                return results.Rows[0]["role_name"].ToString();
            }
            return null;
        }
    }
}
