using FindJobApplication.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindJobApplication.Models;
using FindJobApplication.Mappers;
using System.Data;

namespace FindJobApplication.Daos
{
    public class MailDao
    {
        Database db = null;
        public MailDao()
        {
            db = new Database();
        }

        public int SaveNewMail(Mail mail)
        {
            string sqlStr = @"INSET INTO mail (from, to, title, contents, attach_file, send_date)
                            VALUES (@From, @To, @Title, @Contents, @AttachFile, @SendDate)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@From", mail.From },
                { "@To", mail.To },
                { "@Title", mail.Title },
                { "@Contents", mail.Contents },
                { "@AttachFile", mail.AttachFile },
                { "@SendDate", mail.SendDate },
            };

            return db.Execute(sqlStr, parameters);
        }

        public List<Mail> FindAllMailByOneAccount(int accountId)
        {
            string sqlStr = @"SELECT * FROM mail WHERE from = @AccountId";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@AccountId", accountId },
            };

            DataTable dt = db.Read(sqlStr, parameters);
            List<Mail> list = new List<Mail>();
            foreach (DataRow dr in dt.Rows)
                list.Add(MailMapper.MapToModel(dr));

            return list;
        }

        public Mail FindMailByMaiId(int mailId)
        {
            string sqlStr = @"SELECT * FROM mail WHERE id = @MailId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@MailId", mailId },
            };

            DataRow dr = db.Read(sqlStr, parameters).Rows.Cast<DataRow>().FirstOrDefault();

            return MailMapper.MapToModel(dr);
        }

        public int DeleteMailByMaiId(int mailId)
        {
            string sqlStr = @"DELETE FROM mail WHERE id = @MailId;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@MailId", mailId },
            };

            return db.Execute(sqlStr, parameters);
        }
    }
}
