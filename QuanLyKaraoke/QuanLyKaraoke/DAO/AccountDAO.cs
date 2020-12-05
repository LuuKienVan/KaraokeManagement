using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKaraoke.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }

        public bool checkLogin(string userName, string password)
        {
            string query = "UserLogin @TEN_TAIKHOAN , @MATKHAU";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{userName, password});

            return result.Rows.Count > 0;
        }

        public bool checkAccountType(string userName)
        {
            string query = string.Format("select LOAITAIKHOAN from TAIKHOAN where TEN_TAIKHOAN = '{0}'",userName);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Contains(0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable GetAccountList()
        {

            string query = "select * from TAIKHOAN";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public bool InsertAccount(string userName, string displayName, int type)
        {
            string query = string.Format("insert into TAIKHOAN values('{0}','{1}', default, {2})", userName, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string userName, string displayName, int type)
        {
            string query = string.Format("update TAIKHOAN set TEN_HIENTHI = '{0}', LOAITAIKHOAN = {1} where TEN_TAIKHOAN = '{2}'", displayName, type, userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string userName)
        {
            string query = string.Format("delete from TAIKHOAN where TEN_TAIKHOAN = {0}", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string userName)
        {
            string query = string.Format("update TAIKHOAN set MATKHAU = '123446' where TEN_TAIKHOAN = '{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }

    
}
