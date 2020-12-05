using QuanLyKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKaraoke.DAO
{
    public class ServiceDAO
    {
        private static ServiceDAO instance;
        public static ServiceDAO Instance
        {
            get { if (instance == null) instance = new ServiceDAO(); return ServiceDAO.instance; }
            private set { ServiceDAO.instance = value; }
        }

        private ServiceDAO() { }

        public DataTable GetServiceList()
        {

            string query = "select * from DICHVU";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public bool InsertService(string name, int price)
        {
            string query = string.Format("insert into DICHVU values(N'{0}','{1}')", name, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateService(int id, string name, int price)
        {
            string query = string.Format("update DICHVU set TENDICHVU = '{0}', GIADICHVU = {1} where ID_DICHVU = {2}", name, price, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteService(int id)
        {
            BillInfoDAO.Instance.DeleteBillInfoByServiceId(id);

            string query = string.Format("delete from DICHVU where ID_DICHVU = {0}",id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    
        public DataTable SearchSeviceByName(string name)
        {
            string query = string.Format("select * from DICHVU where TENDICHVU like N'%{0}%'",name);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }
    }
}