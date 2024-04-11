using FindJobApplication.DB;
using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Daos
{
    public class AccountDao
    {
        private Database db = null;

        public AccountDao()
        {
            db = new Database();
        }

        public DataRow FindAccountByEmail(string email)
        {
            string sqlStr = "SELECT * FROM account WHERE email = @Email;";

            Dictionary<string, object> parameters = new Dictionary<string, object> { { "@Email", email } };

            return db.Read(sqlStr, parameters).Rows.Cast<DataRow>().FirstOrDefault();
        }

        public int SaveAccount(string email, string password, int roleId)
        {
            string sqlStr = "INSERT INTO account(email, password, role_id) VALUES (@Email, @Password, @RoleId);";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Email", email },
                { "@Password", password },
                { "@RoleId", roleId }
            };

            return db.Execute(sqlStr, parameters);
        }
    }
}
