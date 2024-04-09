using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Mappers
{
    public class UserWorkExperienceMapper
    {
        public static UserWorkExperience MapToModel(DataRow dr)
        {
            if (dr == null)
            {
                throw new ArgumentNullException(nameof(dr), "DataRow cannot be null");
            }

            try
            {
                int id = Convert.ToInt32(dr["id"]);
                int userProfileId = Convert.ToInt32(dr["user_profile_id"]);
                string jobTitle = dr["job_title"].ToString();
                string companyName = dr["company_name"].ToString();
                DateTime from = Convert.ToDateTime(dr["from"]);
                DateTime to = Convert.ToDateTime(dr["to"]);

                return new UserWorkExperience(id, userProfileId, jobTitle, companyName, from, to);
            }
            catch (FormatException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to User Work Experience", ex);
            }
            catch (InvalidCastException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to User Work Experience", ex);
            }
        }
    }
}
