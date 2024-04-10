using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Models
{
    using System;

    public static class ApplyStatus
    {
        public static readonly string NOT_SELECTED = "Not selected";
        public static readonly string PENDING = "Pending";
        public static readonly string INTERVIEW = "Interview";
    }
    public class JobApplyDetail
    {
        private int userId;
        private int jobPostId;
        private string status;
        private string coverLetter;
        private DateTime appliedAt;
        private string cvAttach;

        public JobApplyDetail() { }
        public JobApplyDetail(int userId, int jobPostId, string status, string coverLetter, DateTime appliedAt, string cvAttach)
        {
            this.userId = userId;
            this.jobPostId = jobPostId;
            this.status = status;
            this.coverLetter = coverLetter;
            this.appliedAt = appliedAt;
            this.cvAttach = cvAttach;
        }

        public int UserId { get => this.userId; }
        public int JobPostId { get => this.jobPostId; }
        public string Status { get => this.status; }
        public string CoverLetter { get => this.coverLetter; }
        public DateTime AppliedAt { get => this.appliedAt; }
        public string CVAttach { get => this.cvAttach; }
    }
}
