using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Models
{
    public class SocialPost
    {
        private int id;
        private DateTime postDate;
        private string contents;
        private int accountId;

        public SocialPost() { }
        public SocialPost(int id,  DateTime postDate, string contents, int accountId)
        {
            this.id = id;
            this.postDate = postDate;
            this.contents = contents;
            this.accountId = accountId;
        }

        public int Id { get => id; }
        public DateTime PostDate { get => postDate; }
        public string Contents { get => contents; }
        public int AccountId { get => accountId; }
    }
}
