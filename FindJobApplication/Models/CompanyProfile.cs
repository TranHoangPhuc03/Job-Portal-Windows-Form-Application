using System;

namespace FindJobApplication.Models
{
    public class CompanyProfile
    {
        private int id;
        private int companyAcdId;
        private string name;
        private string email;
        private string phoneNumber;
        private string address;
        private string companyImage;
        private System.DateTime dateEstablish;
        private int companySize;
        private string companyLink;
        private string reason;
        private string overview;

        public int Id { get; }
        public int CompanyAccId { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string CompanyImage { get; set; }
        public DateTime DateEstablish { get; set; }
        public int CompanySize { get; set; }
        public string CompanyLink { get; set; }
        public string Reason { get; set; }
        public string Overview { get; set; }
    }
}
