using System;

namespace FindJobApplication.Models
{
    public class JobPost
    {
        private int id;
        string title;
        int recruitmentNumber;
        int salary;
        string description;
        string requirement;
        string prioritize;
        string benefit;
        DateTime postDate;
        DateTime expireDate;
        string address;
        int yearExperienceId;
        int locationId;
        int companyId;

        public JobPost() { }

        public JobPost(int id, string title)
        {
            this.id = id;
            this.title = title;
        }

        public int Id { get { return id; } }
        public string Title { get { return title; } set { } }
        public int RecruitmentNumber { get; set; }
        public int Salary { get; set; }
        public string Description { get; set; }
        public string Requirement { get; set; }
        public string Prioritize { get; set; }
        public string Benefit { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Address { get; set; }
        public int YearExperienceId { get; set; }
        public int LocationId { get; set; }
        public int CompanyId { get; set; }



    }
}
