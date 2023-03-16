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
                var sql = from emps in db.NhanViens
                          select emps;
                foreach(var emp in sql)
                {
                    NhanVien i = new NhanVien();
                    i.IDNhanVien = emp.IDNhanVien;
                    i.HoTen = emp.HoTen;
                    i.SDT = emp.SDT;
                    i.Email =emp.Email;
                    i.DiaChi= emp.DiaChi; 
                    i.ChucVu = emp.ChucVu;
                    i.CongViecs = (ICollection<CongViec>)emp.CongViecs.FirstOrDefault();
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
