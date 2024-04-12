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

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public int RecruitmentNumber { get => recruitmentNumber; set => recruitmentNumber = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Description { get => description; set => description = value; }
        public string Requirement { get => requirement; set => requirement = value; }
        public string Prioritize { get => prioritize; set => prioritize = value; }
        public string Benefit { get => benefit; set => benefit = value; }
        public DateTime PostDate { get => postDate; set => postDate = value; }
        public DateTime ExpireDate { get => expireDate; set => expireDate = value; }
        public string Address { get => address; set => address = value; }
        public int YearExperienceId { get => yearExperienceId; set => yearExperienceId = value; }
        public int LocationId { get => locationId; set => locationId = value; }
        public int CompanyId { get => companyId; set => companyId = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
    }
}
