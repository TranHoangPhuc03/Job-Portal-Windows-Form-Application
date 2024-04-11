using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Mappers
{
    public class JobPostMapper
    {
        public static JobPost MapToModel(DataRow dr)
        {
            if (dr == null)
            {
                throw new ArgumentNullException(nameof(dr), "DataRow cannot be null");
            }

            try
            {
                int id = Convert.ToInt32(dr["id"]);
                string title = dr["title"].ToString();
                int recruitmentNumber = Convert.ToInt32(dr["recruitment_number"]);
                int salary = Convert.ToInt32(dr["salary"]);
                string description = dr["description"].ToString();
                string requirement = dr["requirement"].ToString();
                string prioritize = dr["prioritize"].ToString();
                string benefit = dr["benefit"].ToString();
                DateTime postDate = Convert.ToDateTime(dr["post_date"]);
                DateTime expireDate = Convert.ToDateTime(dr["expire_date"]);
                string address = dr["address"].ToString();
                int yearExperienceId = Convert.ToInt32(dr["year_experience_id"]);
                int locationId = Convert.ToInt32(dr["location_id"]);
                int companyId = Convert.ToInt32(dr["company_id"]);
                string companyName = dr["company_name"].ToString();

                return new JobPost(id, title, recruitmentNumber, salary, description, requirement, prioritize, benefit, postDate, expireDate, address, yearExperienceId, locationId, companyId, companyName);
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
