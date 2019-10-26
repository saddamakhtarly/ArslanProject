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
            using (DbConfiguration db = new DbConfiguration())
            {
                db.Add(employee);
                db.SaveChanges();
            }
        }



        public List<Employee1> GetAllList()
        {
            using (DbConfiguration db = new DbConfiguration())
            {
                var getlist = db.Employees.ToList();

                return getlist;

            }
        }

        public Employee1 GetRow(int id)
        {
            using (DbConfiguration db = new DbConfiguration())
            {
                var getlist = db.Employees.FirstOrDefault(x => x.Id == id);


                return getlist;

            }

        }
        public Employee1 updateemp(Employee1 employee)
        {
            using (DbConfiguration db = new DbConfiguration())
            {

                var model = db.Employees.FirstOrDefault(x => x.Id == employee.Id);

                model.Name = employee.Name;
                model.Designation = employee.Designation;
                model.Code = employee.Code;
                model.Address = employee.Address;
                db.SaveChanges();
                return model;
            }
        }
        public void Deleteemp(Employee1 employee)
        {
            using (DbConfiguration db = new DbConfiguration())
            {

                //var model = db.Employees.FirstOrDefault(x => x.Id == employee.Id);
                var model = db.Employees.Remove(employee);
                db.SaveChanges();

            }
        }
    }
}
