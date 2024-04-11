using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Models
{
    public class UserEducation
    {
        private int id;
        private int userProfileId;
        private string schoolName;
        private string major;
        private DateTime from;
        private DateTime to;
        private string additionalDetail;

        public UserEducation() { }
        public UserEducation(int id, int userProfileId, string schoolName, string major, DateTime from, DateTime to, string additionalDetail)
        {
            this.id = id;
            this.userProfileId = userProfileId;
            this.schoolName = schoolName;
            this.major = major;
            this.from = from;
            this.to = to;
            this.additionalDetail = additionalDetail;
        }

        public int Id { get => id; }
        public int UserProfileId { get => userProfileId; }
        public string SchoolName { get => schoolName; }
        public string Major { get => major; }
        public DateTime From { get => from; }
        public DateTime To { get => to; }   
        public string AdditionalDetail { get => additionalDetail; }
    }
}
