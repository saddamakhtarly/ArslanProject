using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models.Address
{
    public class AddressHandler
    {
        public List<Neighborhood> GetAllNeighborhood()
        {
            using(DbConfiguration db = new DbConfiguration())
            {
                return (
                    from n in db.neighborhoods.Include(n => n.City.Province.Country)
                    select n).ToList();       
            }
        }
    }
}
