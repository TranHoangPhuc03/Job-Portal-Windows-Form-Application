using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FindJobApplication.Entities;
using System.CodeDom.Compiler;
using System.Data.Entity;

namespace FindJobApplication.Daos
{
    public class CompanyProfileDao
    {
        private QLXinViecDFContext db = null;

        public CompanyProfileDao()
        {
            db = new QLXinViecDFContext();
        }

        public ICollection<CompanyProfile> FindAllCompanyProfile()
        {
            return db.CompanyProfiles.ToList();
        }

        public CompanyProfile FindCompanyProfileByAccountId(int accountId)
        {
            var result = from q in db.CompanyProfiles
                         where q.Id == accountId
                         select q;
            return result.FirstOrDefault();
        }

        public int SaveCompanySignUp(CompanyProfile companyProfile, string password)
        {
            return 0;
        }

        public ICollection<UserProfile> FindAllUserIdFollowing(int companyAccountId)
        {
            var results = db.Accounts
                    .Find(companyAccountId)
                    .Account1
                    .Select(row => row.UserProfile)
                    .ToList();
            return results;
        }

        public int UpdateCompanyProfile(CompanyProfile companyProfile)
        {
            db.Entry(companyProfile).State = EntityState.Modified;
            return db.SaveChanges();
        }
        public int UpdateUserApplyStatus(int userId, int jobPostId, string status)
        {
            return 0;
        }

        public ICollection<CompanyProfile> FindTopFollowedCompany(int top)
        {
            var results = db.UserProfiles
                .SelectMany(row => row.Account.Account1)
                .GroupBy(row => row.CompanyProfile.Id)
                .OrderByDescending(gp => gp.Count())
                .Take(top)
                .Select(gp => gp.FirstOrDefault().CompanyProfile)
                .ToList();

            return results;
        }
        public void DeleteAllCompanyImages(CompanyProfile companyProfile)
        {
            var imagesToDelete = db.CompanyImages.Where(ci => ci.CompanyId == companyProfile.Id);
            foreach (var image in imagesToDelete.ToList())
            {
                db.CompanyImages.Remove(image);
            }
            db.SaveChanges();
        }

    }
}
