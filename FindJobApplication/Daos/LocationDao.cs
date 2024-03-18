using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindJobApplication.DB;
using FindJobApplication.Models;

namespace FindJobApplication.Daos
{
    public class LocationDao
    {
        private Database db = null;
        public LocationDao()
        {
            db = new Database();
        }

        public DataTable findAll()
        {
            string sqlStr = "select * from location;";
            return db.Read(sqlStr);
        }
    }
}
