using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Mappers
{
    public class UserSkillMapper
    {
        public static UserSkill MapToModel(DataRow dr)
        {
            if (dr == null)
            {
                throw new ArgumentNullException(nameof(dr), "DataRow cannot be null");
            }

            try
            {

                int userProfileId = Convert.ToInt32(dr["user_profile_id"]);
                int skillId = Convert.ToInt32(dr["skill_id"]);
                string skillName = dr["skill_name"].ToString();

                return new UserSkill(userProfileId, skillId, skillName);
            }
            catch (FormatException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to User Skill", ex);
            }
            catch (InvalidCastException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to User Skill", ex);
            }
        }
    }
}
