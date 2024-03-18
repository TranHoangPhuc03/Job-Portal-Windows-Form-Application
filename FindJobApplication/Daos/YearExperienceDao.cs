using FindJobApplication.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Daos
{
    public class YearExperienceDao
    {
        private Database db = null;
        public YearExperienceDao()
        {
            db = new Database();
        }

        public DataTable findAll()
        {
            string sqlStr = "select * from year_experience;";
            return db.Read(sqlStr);
        }
    }
}
