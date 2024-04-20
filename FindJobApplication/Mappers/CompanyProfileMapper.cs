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
                int id = dr.Field<int>("id");
                string name = dr.Field<string>("name");
                string email = dr.Field<string>("email");
                string phoneNumber = dr.Field<string>("phone_number");
                string address = dr.Field<string>("address");
                string companyImage = dr.Field<string>("company_image");
                DateTime? dateEstablished = dr.Field<DateTime?>("date_establish");
                int companySize = dr.Field<int?>("company_size") ?? 0;
                string companyLink = dr.Field<string>("company_link");
                string reason = dr.Field<string>("reason");
                string overview = dr.Field<string>("overview");
                string taxCode = dr.Field<string>("tax_code");
                string businessLicense = dr.Field<string>("business_license");

                return new CompanyProfile(
                        id,
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
