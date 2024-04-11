using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Mappers
{
    public class UserEducationMapper
    {
        public static UserEducation MapToModel(DataRow dr)
        {
            if (dr == null)
            {
                throw new ArgumentNullException(nameof(dr), "DataRow cannot be null");
            }

            try
            {
                int id = Convert.ToInt32(dr["id"]);
                int userProfileId = Convert.ToInt32(dr["user_profile_id"]);
                string schoolName = dr["school_name"].ToString();
                string major = dr["major"].ToString();
                DateTime from = Convert.ToDateTime(dr["from"]);
                DateTime to = Convert.ToDateTime(dr["to"]);
                string additionalDetails = dr["additional_details"].ToString();

                return new UserEducation(id, userProfileId, schoolName, major, from, to, additionalDetails);
            }
            catch (FormatException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to CompanyProfile", ex);
            }
            catch (InvalidCastException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to CompanyProfile", ex);
            }
        }
    }
}
