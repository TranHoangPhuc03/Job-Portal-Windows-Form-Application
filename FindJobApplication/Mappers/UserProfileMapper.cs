using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Mappers
{
    public class UserProfileMapper
    {
        public static UserProfile MapToModel(DataRow dr)
        {
            if (dr == null)
            {
                throw new ArgumentNullException(nameof(dr), "DataRow cannot be null");
            }

            try
            {
                int id = Convert.ToInt32(dr["id"]);
                int userAccountId = Convert.ToInt32(dr["user_account_id"]);
                string name = dr["name"].ToString();
                string email = dr["email"].ToString();
                string phoneNumber = dr["phone_number"]?.ToString();
                DateTime? dateOfBirth = dr["date_of_birth"] as DateTime?;
                string gender = dr["gender"]?.ToString();
                string address = dr["address"]?.ToString();
                string personalLink = dr["personal_link"]?.ToString();
                string userImage = dr["user_image"].ToString();
                string aboutMe = dr["about_me"]?.ToString();
                string title = dr["title"]?.ToString();

                return new UserProfile(
                    id,
                    userAccountId,
                    name,
                    email,
                    phoneNumber,
                    dateOfBirth,
                    gender,
                    address,
                    personalLink,
                    userImage,
                    aboutMe,
                    title
                );
            }
            catch (FormatException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to UserProfile", ex);
            }
            catch (InvalidCastException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to UserProfile", ex);
            }
        }
    }
}
