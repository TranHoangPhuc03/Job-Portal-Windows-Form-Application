using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Models
{
    public class UserPersonalProject
    {
        private int userProfitId;
        private string projectName;
        private DateTime from;
        private DateTime to;
        private string description;

        public UserPersonalProject() { }
        public UserPersonalProject(int userProfitId, string projectName, DateTime from, DateTime to, string description)
        {
            this.userProfitId = userProfitId;
            this.projectName = projectName;
            this.from = from;
            this.to = to;
            this.description = description;
        }

        public int UserProfitId { get => userProfitId; }
        public string ProjectName { get => projectName; }
        public DateTime From { get => from; }
        public DateTime To { get => to; }
        public string Description { get => description; }
    }
}
