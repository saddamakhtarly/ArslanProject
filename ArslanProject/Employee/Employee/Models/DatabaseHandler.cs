using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public class DatabaseHandler
    {

        public void EmployeeMethod(Employee1 employee)
        {
            using(DbConfiguration db= new DbConfiguration())
            {
                db.Add(employee);
                db.SaveChanges();
            }
        }
    }
}
