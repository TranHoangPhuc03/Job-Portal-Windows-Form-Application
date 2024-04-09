using FindJobApplication.DB;
using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindJobApplication.Mappers;

namespace FindJobApplication.Daos
{
    public class YearExperienceDao
    {
        private Database db = null;
        public YearExperienceDao()
        {
            db = new Database();
        }

        public List<YearExperience> FindAllExperienceList()
        {
            string sqlStr = "SELECT * FROM year_experience;";
            DataTable dt = db.Read(sqlStr);
            List<YearExperience> list = new List<YearExperience>();
            foreach (DataRow dr in dt.Rows)
                list.Add(YearExperienceMapper.MapToModel(dr));

            return list;
        }

        public Dictionary<int, YearExperience> FindAllExperienceDict()
        {
            string sqlStr = "SELECT * FROM year_experience;";
            DataTable dt = db.Read(sqlStr);
            Dictionary<int, YearExperience> dict = new Dictionary<int, YearExperience>();
            foreach(DataRow dr in dt.Rows)
            {
                YearExperience yearExperience = YearExperienceMapper.MapToModel(dr);
                dict[yearExperience.Id] = yearExperience;
            }

            return dict;
        }
    }
}
