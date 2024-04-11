using FindJobApplication.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindJobApplication.Models;
using FindJobApplication.Mappers;

namespace FindJobApplication.Daos
{
    public class SkillDao
    {
        Database db = null;
        public SkillDao()
        {
            db = new Database();
        }

        public List<Skill> FindAllSkill()
        {
            string sqlStr = @"SELECT * FROM skill";

            DataTable dt = db.Read(sqlStr);
            List<Skill> list = new List<Skill>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(SkillMapper.MapToModel(dr));
            }

            return list;
        }
    }
}
