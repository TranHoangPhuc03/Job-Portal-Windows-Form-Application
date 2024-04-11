using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Models
{
    public class UserWorkExperience
    {
        private int id;
        private int userProfileId;
        private string jobTitle;
        private string companyName;
        private DateTime from;
        private DateTime to;

        public UserWorkExperience() { }
        public UserWorkExperience(int id, int userProfileId, string jobTitle, string companyName, DateTime from, DateTime to)
        {
            this.userProfileId = userProfileId;
            this.jobTitle = jobTitle;
            this.companyName = companyName;
            this.from = from;
            this.to = to;
        }

        public int Id { get => id; }
        public int UserProfileId { get => userProfileId; }
        public string JobTitle { get => jobTitle; }
        public string CompanyName { get => companyName; }
        public DateTime From { get => from; }
        public DateTime To { get => to; }

    }
}
