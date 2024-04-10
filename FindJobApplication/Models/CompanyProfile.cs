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
        private System.DateTime? dateEstablish;
        private int companySize;
        private string companyLink;
        private string reason;
        private string overview;
        private string taxCode;
        private string businessLicense;

        public CompanyProfile() { }
        public CompanyProfile(string name, string email, string businessLicense)
        {
            this.name = name;
            this.email = email;
            this.businessLicense = businessLicense;
        }
        public CompanyProfile(int id, int companyAcdId, string name, string email, string phoneNumber, string address, string companyImage, DateTime? dateEstablish, int companySize, string companyLink, string reason, string overview, string businessLicense, string taxCode)
        {
            this.id = id;
            this.companyAcdId = companyAcdId;
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.companyImage = companyImage;
            this.dateEstablish = dateEstablish;
            this.companySize = companySize;
            this.companyLink = companyLink;
            this.reason = reason;
            this.overview = overview;
            this.taxCode = taxCode;
            this.businessLicense = businessLicense;
        }
        public CompanyProfile(string name, string email, string phoneNumber, string address, DateTime? dateEstablish, int companySize, string companyLink)
        {
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.dateEstablish = dateEstablish;
            this.companySize = companySize;
            this.companyLink = companyLink;
        }
        public int Id { get { return id; } }
        public int CompanyAccId { get => companyAcdId; }
        public string Name { get => name; }
        public string Email { get => email; }
        public string PhoneNumber { get => phoneNumber; }
        public string Address { get => address; }
        public string CompanyImage { get => companyImage; }
        public DateTime? DateEstablish { get => dateEstablish; }
        public int CompanySize { get => companySize; }
        public string CompanyLink { get => companyLink; }
        public string Reason { get => reason; }
        public string Overview { get => overview; }
        public string BusinessLicense { get => businessLicense; set => BusinessLicense = value; }
    }
}
