using System;

namespace FindJobApplication.Models
{
    public class JobPost
    {
        int id;
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
        string companyName;

        public JobPost() { }

        public JobPost(int id, string title)
        {
            this.id = id;
            this.title = title;
        }

        public JobPost(int id, string title, int recruitmentNumber, int salary, string description, string requirement, string prioritize, string benefit, DateTime postDate, DateTime expireDate, string address, int yearExperienceId, int locationId, int companyId, string companyName) : this(id, title)
        {
            this.recruitmentNumber = recruitmentNumber;
            this.salary = salary;
            this.description = description;
            this.requirement = requirement;
            this.prioritize = prioritize;
            this.benefit = benefit;
            this.postDate = postDate;
            this.expireDate = expireDate;
            this.address = address;
            this.yearExperienceId = yearExperienceId;
            this.locationId = locationId;
            this.companyId = companyId;
            this.companyName = companyName;
        }

        public int Id { get => id; }
        public string Title { get => title; }
        public int RecruitmentNumber { get => recruitmentNumber; }
        public int Salary { get => salary; }
        public string Description { get => description; }
        public string Requirement { get => requirement; }
        public string Prioritize { get => prioritize; }
        public string Benefit { get => benefit; }
        public DateTime PostDate { get => postDate; set => this.PostDate = value; }
        public DateTime ExpireDate { get => expireDate; }
        public string Address { get => address; }
        public int YearExperienceId { get => yearExperienceId; }
        public int LocationId { get => locationId; }
        public int CompanyId { get => companyId; set => this.CompanyId = value; }
        public string CompanyName { get => companyName; }

    }
}
