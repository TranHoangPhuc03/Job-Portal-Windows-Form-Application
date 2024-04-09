using System;
using System.Data;
using FindJobApplication.Models;

namespace FindJobApplication.Mappers
{
    public class CompanyProfileMapper
    {
        public static CompanyProfile MapToModel(DataRow dr)
        {
            if (dr == null)
            {
                throw new ArgumentNullException(nameof(dr), "DataRow cannot be null");
            }

            try
            {
                int id = Convert.ToInt32(dr["id"]);
                int companyAccountId = Convert.ToInt32(dr["company_account_id"]);
                string name = dr["name"].ToString();
                string email = dr["email"].ToString();
                string phoneNumber = dr["phone_number"].ToString();
                string address = dr["address"].ToString();
                string companyImage = dr["company_image"].ToString();
                DateTime dateEstablished = Convert.ToDateTime(dr["date_establish"]);
                int companySize = Convert.ToInt32(dr["company_size"]);
                string companyLink = dr["company_link"].ToString();
                string reason = dr["reason"].ToString();
                string overview = dr["overview"].ToString();
                string taxCode = dr["tax_code"].ToString();
                string businessLicense = dr["business_license"].ToString();

                return new CompanyProfile(
                    id,
                    companyAccountId,
                    name,
                    email,
                    phoneNumber,
                    address,
                    companyImage,
                    dateEstablished,
                    companySize,
                    companyLink,
                    reason,
                    overview,
                    taxCode,
                    businessLicense
                );
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
