using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EmployeeServices
    {
        public static List<NhanVien> LoadEmployees()
        {
            List<NhanVien> list = new List<NhanVien>();
            using (var db = new AirportManage())
            {
                list = db.NhanViens.ToList();
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
