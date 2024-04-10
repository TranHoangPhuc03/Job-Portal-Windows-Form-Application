using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindJobApplication.Models;

namespace FindJobApplication.Mappers
{
    public class SocialPostMapper
    {
        public static SocialPost MapToModel(DataRow dr)
        {
            if (dr == null)
            {
                throw new ArgumentNullException(nameof(dr), "DataRow cannot be null");
            }

            try
            {
                int id = Convert.ToInt32(dr["id"]);
                DateTime postDate = Convert.ToDateTime(dr["post_date"]);
                string contents = dr["contents"].ToString();
                int accountId = Convert.ToInt32(dr["account_id"]);

                return new SocialPost(id, postDate, contents, accountId);
            }
            catch (FormatException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to Social Post", ex);
            }
            catch (InvalidCastException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to Social Post", ex);
            }
        }
    }
}
