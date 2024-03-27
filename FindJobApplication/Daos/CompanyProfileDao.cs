using FindJobApplication.DB;
using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Daos
{
    public class CompanyProfileDao
    {
        private Database db = null;

        public CompanyProfileDao()
        {
            db = new Database();
        }

        public DataTable findAll()
        {
            string sqlStr = "select * from company_profile;";
            return db.Read(sqlStr);
        }

        public DataRow findCompanyById (int id)
        {
            string sqlStr = String.Format("select * from company_profile where id={0}", id);
            return (DataRow) db.Read(sqlStr).Rows[0];
        }

        public CompanyProfile findCompanyProfileById(int id)
        {
            string sqlStr = String.Format("select * from company_profile where id={0}", id);
            DataRow dr = db.Read(sqlStr).Rows[0];
            CompanyProfile companyProfile = new CompanyProfile(
                (int)dr["id"],
                (int)dr["company_account_id"],
                dr["name"].ToString(),
                dr["email"].ToString(),
                dr["phone_number"].ToString(),
                dr["address"].ToString(),
                dr["company_image"].ToString(),
                (DateTime)dr["date_establish"],
                (int)dr["company_size"],
                dr["company_link"].ToString(),
                dr["reason"].ToString(),
                dr["overview"].ToString()
            );

            return companyProfile;
        }

        public DataRow findCompanyByAccountId(int id)
        {
            string sqlStr = $"select * from company_profile where company_account_id={id};";
            return (DataRow)db.Read(sqlStr).Rows[0];
        }

        public int saveCompanySignUp(CompanyProfile companyProfile)
        {
            string sqlStr = $"INSERT INTO company_profile (company_account_id, name, email, business_license) VALUES ({companyProfile.CompanyAccId}, '{companyProfile.Name}', '{companyProfile.Email}', '{companyProfile.BusinessLicense}')";
            return db.Excute(sqlStr);
        }

        public DataTable findAllUserFollowing(int companyId)
        {
            string sqlStr = $"select * from company_following where company_id={companyId};";
            return db.Read(sqlStr);
        }

        public int saveUserFollowing(int companyId, int userId)
        {
            string sqlStr = $"insert into company_following values ({companyId}, {userId});";
            return db.Excute(sqlStr);
        }

        public int deleteUserFollowing(int companyId, int userId)
        {
            string sqlStr = $"delete from company_following where company_id={companyId} and user_id={userId};";
            return db.Excute(sqlStr);
        }
    }
}
