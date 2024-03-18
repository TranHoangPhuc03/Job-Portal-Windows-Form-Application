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

        public DataRow findAccountByEmail(string email)
        {
            string sqlStr = $"select * from account where email='{email}';";

            if (db.Read(sqlStr).Rows.Count > 0)
                return db.Read(sqlStr).Rows[0];

            return null;
        }
    }
}
