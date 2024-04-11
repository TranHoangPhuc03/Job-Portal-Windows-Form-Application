using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Models
{
    public class Mail
    {
        private int id;
        private int from;
        private int to;
        private string title;
        private string contents;
        private string attachFile;
        private DateTime sendDate;

        public Mail() { }
        public Mail(int id, int from, int to, string title, string contents, string attachFile, DateTime sendDate)
        {
            this.id = id;
            this.from = from;
            this.to = to;
            this.title = title;
            this.contents = contents;
            this.attachFile = attachFile;
            this.sendDate = sendDate;
        }

        public int Id { get => id; }
        public int From { get => from; }
        public int To { get => to; }
        public string Title { get => title; }
        public string Contents { get => contents; }
        public string AttachFile { get => attachFile; }
        public DateTime SendDate { get => sendDate;}
    }
}
