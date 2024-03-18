using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Id { get; }
        public int UserAccId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PersonalLink { get; set; }
        public string UserImage { get; set; }
    }
}
