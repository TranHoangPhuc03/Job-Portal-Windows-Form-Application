using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Mappers
{
    public class AccountMapper
    {
        public static Account MapToModel(DataRow dr)
        {
            if (dr == null)
            {
                throw new ArgumentNullException(nameof(dr), "DataRow cannot be null");
            }

            try
            {
                int id = Convert.ToInt32(dr["id"]);
                string name = dr["name"].ToString();
                string email = dr["email"].ToString();
                string password = dr["password"].ToString();
                string role = dr["role"].ToString();

                return new Account(id, email, password, name, role);
                
            }
            catch (FormatException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to Account", ex);
            }
            catch (InvalidCastException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to Account", ex);
            }
        }
    }
}
