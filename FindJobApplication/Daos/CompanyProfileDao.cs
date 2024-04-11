using FindJobApplication.DB;
using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindJobApplication.Mappers;
using System.Drawing;

namespace FindJobApplication.Daos
{
    public class CompanyProfileDao
    {
        private Database db = null;

        public CompanyProfileDao()
        {
            db = new Database();
        }

        public List<CompanyProfile> FindAllCompanyProfile()
        {
            string sqlStr = "SELECT * FROM company_profile;";
            DataTable dt = db.Read(sqlStr);
            List<CompanyProfile> list = new List<CompanyProfile>();

            foreach (DataRow dr in dt.Rows)
                list.Add(CompanyProfileMapper.MapToModel(dr));

            return list;
        }

        public CompanyProfile FindCompanyProfileById(int id)
        {
            string sqlStr = "SELECT * FROM company_profile WHERE id = @Id;";
            Dictionary<string, object> parameters = new Dictionary<string, object> { { "@Id", id} };
            DataRow dr = db.Read(sqlStr, parameters).Rows.Cast<DataRow>().FirstOrDefault();

            CompanyProfile companyProfile = CompanyProfileMapper.MapToModel(dr);

            return companyProfile;
        }

        public int FindCompanyIdByAccountId(int accountId)
        {
            string sqlStr = "SELECT id FROM company_profile WHERE company_account_id = @AccountId;";
            Dictionary<string, object> parameters = new Dictionary<string, object> { { "@AccountId", accountId } };
            return (int) db.ExecuteScalar(sqlStr, parameters);
        }

        public int SaveCompanySignUp(CompanyProfile companyProfile, string password)
        {
            string sqlStr = @"
                            EXEC usp_RegisterCompanyAccount
                                @Email,
                                @Password,
                                @Name,
                                @BusinessLicense;";
            Dictionary<string, object> paremeters = new Dictionary<string, object>
            {
                { "@Email", companyProfile.Email },
                { "@Password",  password},
                { "@Name", companyProfile.Name },
                { "@BusinessLicense", companyProfile.BusinessLicense }
            };
            return db.Execute(sqlStr, paremeters);
        }

        public List<int> FindAllUserIdFollowing(int companyAccountId)
        {
            string sqlStr = @"SELECT * FROM following WHERE company_id = @CompanyAccountId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@CompanyAccountId", companyAccountId }
            };

            DataTable dt = db.Read(sqlStr, parameters);
            List<int> list = new List<int>();
            foreach (DataRow dr in dt.Rows)
                list.Add(Convert.ToInt32(dr["user_id"]));

            return list;
        }

        public int SaveUserIdFollowing(int companyAccountId, int userAccountId)
        {
            string sqlStr = @"INSERT INTO following (company_id, account_id)
                            VALUES (@CompanyAccountId, @UserAccountId);";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@CompanyAccountId", companyAccountId },
                { "@UserAccountId", userAccountId },
            };

            return db.Execute(sqlStr, parameters);
        }

        public int DeleteUserIdFollowing(int companyAccountId, int userAccountId)
        {
            string sqlStr = @"DELETE FROM following WHERE company_id=@CompanyAccountId AND user_id=@UserAccountId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@CompanyAccountId", companyAccountId },
                { "@UserAccountId", userAccountId },
            };
            return db.Execute(sqlStr, parameters);
        }

        public int UpdateCompanyReason(int companyId, string reason)
        {
            string sqlStr = "UPDATE company_profile SET reason = @Reason WHERE id = @CompanyId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Reason", reason },
                { "@CompanyId", companyId }
            };

            return db.Execute(sqlStr, parameters);
        }

        public int UpdateCompanyOverview(int companyId, string overview)
        {
            string sqlStr = "UPDATE company_profile SET overview = @Overview WHERE id = @CompanyId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Overview", overview },
                { "@CompanyId", companyId }
            };

            return db.Execute(sqlStr, parameters);
        }

        public int UpdateCompanyProfile(int companyId, CompanyProfile companyProfile)
        {
            string sqlStr = @"
                            UPDATE company_profile
                            SET name = @Name, email = @Email, phone_number = @PhoneNumber, address = @Address, company_size = @CompanySize, date_establish = @DateEstablish, company_link = @CompanyLink
                            WHERE id = @CompanyId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Name", companyProfile.Name },
                { "@Email", companyProfile.Email },
                { "@PhoneNumber", companyProfile.PhoneNumber },
                { "@Address", companyProfile.Address },
                { "@CompanySize", companyProfile.CompanySize },
                { "@DateEstablish", companyProfile.DateEstablish },
                { "@CompanyLink", companyProfile.CompanyLink },
                { "@CompanyId", companyId }
            };

            return db.Execute(sqlStr, parameters);
        }
        public int UpdateUserApplyStatus(int userId, int jobPostId, string status)
        {
            string sqlStr = @"
                            UPDATE user_apply_job
                            SET status = @Status
                            WHERE user_id = @UserId AND job_post_id = @JobPostId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UserId", userId },
                { "@JobPostId", jobPostId },
                { "@Status", status }
            };

            return db.Execute(sqlStr, parameters);
        }
    }
}
