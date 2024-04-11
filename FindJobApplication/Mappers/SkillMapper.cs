using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FindJobApplication.Models;

namespace FindJobApplication.Mappers
{
    public class SkillMapper
    {
        public static Skill MapToModel(DataRow dr)
        {
            if (dr == null)
            {
                throw new ArgumentNullException(nameof(dr), "DataRow cannot be null");
            }

            try
            {
                int id = Convert.ToInt32(dr["id"]);
                string name = dr["name"].ToString();

                return new Skill(id, name);
            }
            catch (FormatException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to Skill", ex);
            }
            catch (InvalidCastException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to Skill", ex);
            }
        }
    }
}
