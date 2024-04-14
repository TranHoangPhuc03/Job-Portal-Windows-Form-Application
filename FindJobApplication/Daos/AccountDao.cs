using FindJobApplication.DB;
using FindJobApplication.Mappers;
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

        public Account FindAccountByEmail(string email)
        {
            string sqlStr = @"SELECT * FROM account WHERE email = @Email;";

            Dictionary<string, object> parameters = new Dictionary<string, object> { { "@Email", email } };

            DataRow dr =  db.Read(sqlStr, parameters).Rows.Cast<DataRow>().FirstOrDefault();

            if (dr == null)
            {
                return null;
            }

            return AccountMapper.MapToModel(dr);
        }

        public int SaveNewAccount(string email, string name, string password, string role)
        {
            string sqlStr = "INSERT INTO account(email, name, password, role) VALUES (@Email, , @Name, @Password, @Role);";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Email", email },
                { "@Password", password },
                { "@Role", role },
                {   "@Name", name }
            };

            return db.Execute(sqlStr, parameters);
        }
    }
}
