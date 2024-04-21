using FindJobApplication.DB;
using FindJobApplication.Models;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using FindJobApplication.Mappers;

namespace FindJobApplication.Daos
{
    public class JobPostDao
    {
        private Database db = null;

        public JobPostDao()
        {
            db = new Database();
        }

        public int SaveNewJobPost(JobPost jobpost)
        {
            string sqlStr = "INSERT INTO job_post (title, recruitment_number, salary, description, requirement, prioritize, benefit, post_date, expire_date, address, year_experience_id, location_id, company_id) " +
                            "VALUES (@Title, @RecruitmentNumber, @Salary, @Description, @Requirement, @Prioritize, @Benefit, @PostDate, @ExpireDate, @Address, @YearExperienceId, @LocationId, @CompanyId)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Title", jobpost.Title },
                { "@RecruitmentNumber", jobpost.RecruitmentNumber },
                { "@Salary", jobpost.Salary },
                { "@Description", jobpost.Description },
                { "@Requirement", jobpost.Requirement },
                { "@Prioritize", jobpost.Prioritize },
                { "@Benefit", jobpost.Benefit },
                { "@PostDate", jobpost.PostDate },
                { "@ExpireDate", jobpost.ExpireDate },
                { "@Address", jobpost.Address },
                { "@YearExperienceId", jobpost.YearExperienceId },
                { "@LocationId", jobpost.LocationId },
                { "@CompanyId", jobpost.CompanyId }
            };

            return db.Execute(sqlStr, parameters);
        }
        public List<JobPost> FindAllJobPost()
        {
            string sqlStr = @"
                            SELECT
                                job_post.id,
                                job_post.title,
                                job_post.recruitment_number,
                                job_post.salary,
                                job_post.description,
                                job_post.requirement,
                                job_post.prioritize,
                                job_post.benefit,
                                job_post.post_date,
                                job_post.expire_date,
                                job_post.address,
                                account.id AS company_id,
                                account.[name] AS company_name,
                                location.id AS location_id,
                                location.name AS location_name,
                                year_experience.id AS year_experience_id,
                                year_experience.name AS year_experience_name
                            FROM 
                                job_post
                            INNER JOIN 
                                location ON job_post.location_id = location.id
                            INNER JOIN 
                                year_experience ON job_post.year_experience_id = year_experience.id
                            INNER JOIN
                                account ON job_post.company_account_id = account.id";
            DataTable dt = db.Read(sqlStr);
            List<JobPost> list = new List<JobPost>();
            foreach (DataRow dr in dt.Rows)
            {
                JobPost jobPost = JobPostMapper.MapToModel(dr);
                List<int> skills = FindAllJobPostSkill(jobPost.Id);
                jobPost.SkillID.AddRange(skills);
                list.Add(jobPost);
            }

            return list;
        }
        public JobPost FindJobPostById(int jobPostId)
        {
            string sqlStr = @"
                            SELECT
                                job_post.id,
                                job_post.title,
                                job_post.recruitment_number,
                                job_post.salary,
                                job_post.description,
                                job_post.requirement,
                                job_post.prioritize,
                                job_post.benefit,
                                job_post.post_date,
                                job_post.expire_date,
                                job_post.address,
                                account.id AS company_id,
                                account.[name] AS company_name,
                                location.id AS location_id,
                                location.name AS location_name,
                                year_experience.id AS year_experience_id,
                                year_experience.name AS year_experience_name
                            FROM 
                                job_post
                            INNER JOIN 
                                location ON job_post.location_id = location.id
                            INNER JOIN 
                                year_experience ON job_post.year_experience_id = year_experience.id
                            INNER JOIN 
                                account ON job_post.company_account_id = account.id
                            WHERE job_post.id = @Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Id", jobPostId },
            };
            DataRow dr = db.Read(sqlStr, parameters).Rows.Cast<DataRow>().FirstOrDefault();
            return JobPostMapper.MapToModel(dr);
        }
        public List<JobPost> FindAllJobPostByCompanyId(int companyId)
        {
            string sqlStr = @"
                            SELECT
                                job_post.id,
                                job_post.title,
                                job_post.recruitment_number,
                                job_post.salary,
                                job_post.description,
                                job_post.requirement,
                                job_post.prioritize,
                                job_post.benefit,
                                job_post.post_date,
                                job_post.expire_date,
                                job_post.address,
                                company_profile.id AS company_id,
                                company_profile.name AS company_name,
                                location.id AS location_id,
                                location.name AS location_name,
                                year_experience.id AS year_experience_id,
                                year_experience.name AS year_experience_name
                            FROM 
                                job_post
                            INNER JOIN 
                                location ON job_post.location_id = location.id
                            INNER JOIN 
                                year_experience ON job_post.year_experience_id = year_experience.id
                            INNER JOIN 
                                company_profile ON job_post.company_id = company_profile.id
                            WHERE company_profile.id = @CompanyId";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@CompanyId", companyId }
            };
            DataTable dt = db.Read(sqlStr, parameters);
            List<JobPost> list = new List<JobPost>();
            foreach (DataRow dr in dt.Rows)
                list.Add(JobPostMapper.MapToModel(dr));

            return list;
        }
        public int CountUserAppliedForOneJob(int jobPostId)
        {
            string sqlStr = @"
                            SELECT count(account_id) as numer_user_apply
                            FROM user_apply_job
                            WHERE job_post_id = @JobPostId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@JobPostId", jobPostId },
            };

            return (int)db.ExecuteScalar(sqlStr, parameters);
        }
        public List<int> FindAllUserIdAppliedForOneJob(int jobPostId)
        {
            string sqlStr = @"SELECT account_id
                            FROM user_apply_job
                            WHERE job_post_id = @JobPostId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@JobPostId", jobPostId },
            };

            DataTable dt = db.Read(sqlStr);
            List<int> list = new List<int>();
            foreach (DataRow dr in dt.Rows)
                list.Add((int)dr["account_id"]);

            return list;
        }
        public int DeleteJobPostById(int jobPostId)
        {
            string sqlStr = $"DELETE FROM job_post WHERE id=@JobPostId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@JobPostId", jobPostId },
            };

            return db.Execute(sqlStr);
        }
        public int UpdateJobPostById(JobPost jobPost)
        {
            string sqlStr = $@"
                            UPDATE job_post
                            SET title = @Title, 
                                recruitment_number = @RecruitmentNumber, 
                                salary = @Salary, 
                                description = @Description, 
                                requirement = @Requirement, 
                                prioritize = @Prioritize, 
                                benefit = @Benefit, 
                                post_date = @PostDate, 
                                expire_date = @ExpireDate, 
                                address = @Address, 
                                year_experience_id = @YearExperienceId, 
                                location_id = @LocationId, 
                                company_id = @CompanyId
                            WHERE id = @JobPostId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Title", jobPost.Title },
                { "@RecruitmentNumber", jobPost.RecruitmentNumber },
                { "@Salary", jobPost.Salary },
                { "@Description", jobPost.Description },
                { "@Requirement", jobPost.Requirement },
                { "@Prioritize", jobPost.Prioritize },
                { "@Benefit", jobPost.Benefit },
                { "@PostDate", jobPost.PostDate },
                { "@ExpireDate", jobPost.ExpireDate },
                { "@Address", jobPost.Address },
                { "@YearExperienceId", jobPost.YearExperienceId },
                { "@LocationId", jobPost.LocationId },
                { "@CompanyId", jobPost.CompanyId },
                { "@JobPostId", jobPost.Id }
            };

            return db.Execute(sqlStr, parameters);
        }
        public List<int> FindAllJobPostSkill(int jobPostId)
        {
            string sqlStr = @"
                            SELECT *
                            FROM job_skill
                            WHERE job_post_id = @Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Id", jobPostId },
            };

            DataTable dt = db.Read(sqlStr, parameters);
            List<int> list = new List<int>();
            foreach (DataRow dr in dt.Rows)
                list.Add(dr.Field<int>("skill_id"));

            return list;
        }
    }
}
