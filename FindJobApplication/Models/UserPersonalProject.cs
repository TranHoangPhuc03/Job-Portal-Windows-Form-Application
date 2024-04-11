using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Models
{
    public class UserPersonalProject
    {
        private int id;
        private int userProfileId;
        private string projectName;
        private DateTime from;
        private DateTime to;
        private string description;

        public UserPersonalProject() { }
        public UserPersonalProject(int id, int userProfitId, string projectName, DateTime from, DateTime to, string description)
        {
            this.userProfileId = userProfitId;
            this.projectName = projectName;
            this.from = from;
            this.to = to;
            this.description = description;
        }

        public int Id { get => id; }
        public int UserProfileId { get => userProfileId; }
        public string ProjectName { get => projectName; }
        public DateTime From { get => from; }
        public DateTime To { get => to; }
        public string Description { get => description; }
    }
}
