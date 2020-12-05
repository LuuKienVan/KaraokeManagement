using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKaraoke.DAO
{
    class EmployeeDAO
    {
        private static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return EmployeeDAO.instance; }
            private set { EmployeeDAO.instance = value; }
        }

        private EmployeeDAO() { }

        public DataTable GetEmployeeList()
        {
            string query = "select * from NHANVIEN";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public bool InsertEmployee(string name, DateTime? date, int gender, string idNum, string phoneNum, string address, string email)
        {
            string query = string.Format("insert into NHANVIEN values(N'{0}','{1}',{2},'{3}','{4}',N'{5}','{6}')", name, date, gender, idNum, phoneNum, address, email);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateEmployee(int id, string name, DateTime? date, int gender, string idNum, string phoneNum, string address, string email)
        {
            string query = string.Format("update NHANVIEN set HOTEN = N'{0}', NGAYSINH = '{1}', GIOITINH = {2}, CMND = '{3}', SDT = '{4}', DIACHI = N'{5}', EMAIL =  '{6}' where ID_NHANVIEN = {7}", name, date, gender, idNum, phoneNum, address, email, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteEmployee(int id)
        {
            string query = string.Format("delete from NHANVIEN where ID_NHANVIEN = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }


}
