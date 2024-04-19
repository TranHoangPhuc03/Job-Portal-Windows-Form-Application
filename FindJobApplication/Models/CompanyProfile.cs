using System;

namespace FindJobApplication.Models
{
    public class CompanyProfile : Account
    {
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
        private DateTime? dateEstablished;

        public CompanyProfile(string name, string email, string taxCode, string password, string businessLicense) : base(email, password, name, AccountRole.Company)
        {
            this.taxCode = taxCode;
            this.businessLicense = businessLicense;
        }

        public CompanyProfile(int id, string email, string name, string phoneNumber, string address, DateTime? dateEstablish, int companySize, string companyLink) : base(id, email, name)
        {
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.dateEstablish = dateEstablish;
            this.companySize = companySize;
            this.companyLink = companyLink;
        }

        public CompanyProfile(int id, string name, string email, string phoneNumber, string address, string companyImage, DateTime dateEstablished, int companySize, string companyLink, string reason, string overview, string taxCode, string businessLicense) : base(id, email, name)
        {
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.companyImage = companyImage;
            this.dateEstablish = dateEstablished;
            this.companySize = companySize;
            this.companyLink = companyLink;
            this.reason = reason;
            this.overview = overview;
            this.taxCode = taxCode;
            this.businessLicense = businessLicense;
        }

        public CompanyProfile (int id, string name, string email, string phoneNumber, string address, int companySize, DateTime dateEstablish, string companyLink) : base(id, email, name)
        {
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.companySize = companySize;
            this.dateEstablish = dateEstablish;
            this.companyLink = companyLink;
        }

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
