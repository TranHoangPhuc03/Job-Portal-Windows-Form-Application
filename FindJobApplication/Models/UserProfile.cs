using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace FindJobApplication.Models
{
    public class UserProfile
    {
        private  int id;
        private int userAccId;
        private string name;
        private string email;
        private string phoneNumber;
        private DateTime dateOfBirth;
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

        public UserProfile()
        {
            this.userEducations = new List<UserEducation>();
            this.userWorkExperience = new List<UserWorkExperience>();
            this.userPersonalProject = new List<UserPersonalProject>();
            this.userSkills = new List<UserSkill>();
        }

        public UserProfile(int id, int userAccId, string name, string email, string phoneNumber, DateTime dateOfBirth, string gender, string address, string personalLink, string userImage, string aboutMe, string title) : this()
        {
            this.id = id;
            this.userAccId = userAccId;
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.address = address;
            this.personalLink = personalLink;
            this.aboutMe = aboutMe;
            this.title = title;
        }

        public UserProfile(string name, string email) : this()
        {
            this.name = name;
            this.email = email;
        }
        
        public int Id { get => this.id; set => this.id = value; }
        public int UserAccId { get; set; }
        public string Name { get => this.name; }
        public string Email { get => this.email; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
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
