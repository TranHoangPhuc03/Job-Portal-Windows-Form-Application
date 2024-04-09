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
            return db.Excute(sqlStr, paremeters);
        }

        public DataTable FindAllUserFollowing(int companyId)
        {
            string sqlStr = "SELECT * from company_following WHERE company_id = @CompanyId;";
            Dictionary<string, object> parameters = new Dictionary<string, object> { { "@CompanyId", companyId } };

            return db.Read(sqlStr, parameters);
        }

        public int SaveUserFollowing(int companyId, int userId)
        {
            string sqlStr = $"insert into company_following values ({companyId}, {userId});";
            return db.Excute(sqlStr);
        }

        public int DeleteUserFollowing(int companyId, int userId)
        {
            string sqlStr = $"delete from company_following where company_id={companyId} and user_id={userId};";
            return db.Excute(sqlStr);
        }

        public int UpdateCompanyReason(int companyId, string reason)
        {
            string sqlStr = "UPDATE company_profile SET reason = @Reason WHERE id = @CompanyId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Reason", reason },
                { "@CompanyId", companyId }
            };

            return db.Excute(sqlStr, parameters);
        }

        public int UpdateCompanyOverview(int companyId, string overview)
        {
            string sqlStr = "UPDATE company_profile SET overview = @Overview WHERE id = @CompanyId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Overview", overview },
                { "@CompanyId", companyId }
            };

            return db.Excute(sqlStr, parameters);
        }

        public int UpdateCompanyProfile(int companyId, CompanyProfile companyProfile)
        {
            string sqlStr = "UPDATE companu_profile SET name = @Name, email = @Email, phone_number = @PhoneNumber, address = @Address, company_size = @CompanySize, date_establish = @DateEstablish, address = @Address, company_link = @CompanyLink WHERE id = @CompanyId;";
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

            return db.Excute(sqlStr);
        }
    }
}
