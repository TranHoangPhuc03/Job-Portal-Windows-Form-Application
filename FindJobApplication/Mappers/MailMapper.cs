using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindJobApplication.Models;

namespace FindJobApplication.Mappers
{
    public class MailMapper
    {
        public static Mail MapToModel(DataRow dr)
        {
            if (dr == null)
            {
                throw new ArgumentNullException(nameof(dr), "DataRow cannot be null");
            }

            try
            {
                int id = Convert.ToInt32(dr["id"]);
                int from = Convert.ToInt32(dr["from"]);
                int to = Convert.ToInt32(dr["to"]);
                string title = dr["title"].ToString();
                string contents = dr["contents"].ToString();
                string attachFile = dr["attach_file"].ToString();
                DateTime sendDate = Convert.ToDateTime(dr["send_date"]);

                return new Mail(id, from, to, title, contents, attachFile, sendDate);
            }
            catch (FormatException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to Mail", ex);
            }
            catch (InvalidCastException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to Mail", ex);
            }
        }
    }
}
