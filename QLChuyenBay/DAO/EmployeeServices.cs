using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EmployeeServices
    {
        public static List<Employee> LoadEmployees()
        {
            List<Employee> list = new List<Employee>();
            using (var db = new AirportManagerEntities())
            {
                list = db.Employees.ToList();
            }
            return list;
        }
        
       
        public void AddEmployess()
        {
      
        }

        public void UpdateEmployess()
        {
           
        }
        public void DeleteEmployess()
        {

        }
      
    }
}
