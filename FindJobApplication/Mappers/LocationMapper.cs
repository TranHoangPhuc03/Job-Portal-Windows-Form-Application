using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Mappers
{
    public class LocationMapper
    {
        public static Location MapToModel(DataRow dr)
        {
            if (dr == null)
            {
                throw new ArgumentNullException(nameof(dr), "DataRow cannot be null");
            }

            try
            {
                int id = Convert.ToInt32(dr["id"]);
                string name = dr["name"].ToString();

                return new Location(id, name);
            }
            catch (FormatException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to CompanyProfile", ex);
            }
            catch (InvalidCastException ex)
            {
                throw new DataException("Error occurred while mapping DataRow to CompanyProfile", ex);
            }
        }
    }
}
