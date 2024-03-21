using FindJobApplication.DB;
using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace FindJobApplication.Daos
{
    public class JobPostDao
    {
        private Database db = null;

        public JobPostDao()
        {
            db = new Database();
        }

        public int save(JobPost jobpost)
        {

            string sqlStr = String.Format("INSERT INTO job_post (title, recruitment_number, salary, description, requirement, prioritize, benefit, post_date, expire_date, address, year_experience_id, location_id, company_id) " +
                              "VALUES ('{0}', {1}, {2}, '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', {10}, {11}, {12});",
                              jobpost.Title, jobpost.RecruitmentNumber, jobpost.Salary, jobpost.Description, jobpost.Requirement, jobpost.Prioritize,
                              jobpost.Benefit, jobpost.PostDate.ToString("yyyy-MM-dd HH:mm:ss"), jobpost.ExpireDate.ToString("yyyy-MM-dd HH:mm:ss"),
                              jobpost.Address, jobpost.YearExperienceId, jobpost.LocationId, jobpost.CompanyId);

            return db.Excute(sqlStr);
        }

        public DataTable findAll()
        {
            string sqlStr = "select job_post.title, job_post.recruitment_number, job_post.salary, job_post.description, job_post.requirement, job_post.prioritize, job_post.benefit, job_post.post_date, job_post.expire_date, job_post.address, company_profile.name as company_name, location.name as location_name, year_experience.name as year_experience_name " +
                            "from job_post, location, year_experience, company_profile " +
                            "where job_post.location_id = location.id and job_post.year_experience_id = year_experience.id and job_post.company_id = company_profile.id;";
            return db.Read(sqlStr);
        }

        public DataRow findById(int id)
        {
            string sqlStr = String.Format("select * from job_post where id={0];", id);
            return (DataRow)db.Read(sqlStr).Rows[0];
        }

        public DataTable findByCompanyId(int id)
        {
            string sqlStr = "select job_post_company.title, job_post_company.recruitment_number, job_post_company.salary, job_post_company.description, job_post_company.requirement, job_post_company.prioritize, job_post_company.benefit, job_post_company.post_date, job_post_company.expire_date, job_post_company.address, company_profile.name as company_name, location.name as location_name, year_experience.name as year_experience_name " +
                            $"from(select * from job_post where company_id = {id}) as job_post_company, location, year_experience, company_profile " +
                            "where job_post_company.location_id = location.id and job_post_company.year_experience_id = year_experience.id and job_post_company.company_id = company_profile.id;";
            return db.Read(sqlStr);
        }
    }
}
