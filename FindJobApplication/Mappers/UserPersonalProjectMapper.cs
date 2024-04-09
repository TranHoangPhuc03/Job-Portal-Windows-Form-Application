using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Mappers
{
    public class UserPersonalProjectMapper
    {
        public static UserPersonalProject MapToModel(DataRow dr)
        {
            if (dr == null)
            {
                throw new ArgumentNullException(nameof(dr), "DataRow cannot be null");
            }

            try
            {
                int id = Convert.ToInt32(dr["id"]);
                int userProfileId = Convert.ToInt32(dr["user_profile_id"]);
                string projectName = dr["project_name"].ToString();
                DateTime from = Convert.ToDateTime(dr["from"]);
                DateTime to = Convert.ToDateTime(dr["to"]);
                string description = dr["description"].ToString();

                return new UserPersonalProject(id, userProfileId, projectName, from, to, description);
            }
            catch (FormatException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to User Personal Project", ex);
            }
            catch (InvalidCastException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to User Personal Project", ex);
            }
        }
    }
}
