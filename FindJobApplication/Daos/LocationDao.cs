using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindJobApplication.DB;
using FindJobApplication.Models;
using FindJobApplication.Mappers;

namespace FindJobApplication.Daos
{
    public class LocationDao
    {
        private Database db = null;
        public LocationDao()
        {
            db = new Database();
        }

        public List<Location> FindAllLocationList()
        {
            string sqlStr = "SELECT * FROM location;";
            List<Location> list = new List<Location>();
            DataTable dt = db.Read(sqlStr);

            foreach (DataRow dr in dt.Rows)
                list.Add(LocationMapper.MapToModel(dr));

            return list;
        }

        public Dictionary<int, Location> FindAllLocationDict()
        {
            string sqlStr = "SELECT * FROM year_experience;";
            DataTable dt = db.Read(sqlStr);
            Dictionary<int, Location> dict = new Dictionary<int, Location>();
            foreach (DataRow dr in dt.Rows)
            {
                Location location = LocationMapper.MapToModel(dr);
                dict[location.Id] = location;
            }

            return dict;
        }
    }
}
