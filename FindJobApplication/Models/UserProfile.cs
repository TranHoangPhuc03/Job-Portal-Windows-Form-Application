using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace FindJobApplication.Models
{
    public class UserProfile : Account
    {
        private string phoneNumber;
        private DateTime? dateOfBirth;
        private string gender;
        private string address;
        private string personalLink;
        private string userImage;
        private string aboutMe;
        private string title;
        private List<UserEducation> userEducations;
        private List<UserWorkExperience> userWorkExperience;
        private List<UserPersonalProject> userPersonalProject;
        private List<UserSkill> userSkills;

        public UserProfile(string name, string email, string password) : base(email, password, name, AccountRole.User) {}

        public UserProfile(int id, string email, string name, string phoneNumber, DateTime? dateOfBirth, string gender, string address, string personalLink, string userImage, string aboutMe, string title) : base(id, email, name)
        {
            this.phoneNumber = phoneNumber;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.address = address;
            this.personalLink = personalLink;
            this.userImage = userImage;
            this.aboutMe = aboutMe;
            this.title = title;
        }

        public string PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PersonalLink { get; set; }
        public string UserImage { get; set; }
        public string AboutMe { get; set; }
        public string Title { get; set; }
        public List<UserEducation> UserEducations { get => userEducations; }
        public List<UserWorkExperience> UserWorkExperiences { get => userWorkExperience; }
        public List<UserPersonalProject> UserPersonalProjects { get => userPersonalProject; }
        public List<UserSkill> UserSkills { get => userSkills; }

    }
}
