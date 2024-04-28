using FindJobApplication.DB;
using FindJobApplication.Entities;
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

        public account FindAccountByEmail(string email)
        {
            using (var dbcontext = new AccountContext())
            {
                var result = from q in dbcontext.accounts
                             where q.email == email
                             select q;

                return result.First() ?? null;
            }
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
