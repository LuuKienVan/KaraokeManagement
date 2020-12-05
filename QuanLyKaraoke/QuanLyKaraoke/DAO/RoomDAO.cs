using QuanLyKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKaraoke.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;
        public static RoomDAO Instance
        {
            get { if (instance == null) instance = new RoomDAO(); return RoomDAO.instance; }
            private set { RoomDAO.instance = value; }
        }

        public static int roomHeight = 70;
        public static int roomWidth = 70;
        private RoomDAO() { }

        public List<Room> LoadRoomList()
        {
            List<Room> roomList = new List<Room>();

            DataTable dt = DataProvider.Instance.ExecuteQuery("LoadRoomList");

            foreach (DataRow item in dt.Rows)
            {
                Room room = new Room(item);
                roomList.Add(room);
            }

            return roomList;
        }

        public DataTable GetRoomList()
        {
            string query = "select * from PHONG";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public bool InsertRoom(string id, int price, string status, string type)
        {
            string query = string.Format("insert into PHONG values('{0}',{1},'{2}','{3}')", id, price, status, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateRoom(string id, int price, string status, string type)
        {
            string query = string.Format("update PHONG set TIENTHUE = {0}, TINHTRANG = '{1}', LOAIPHONG = '{2}' where ID_PHONG = '{3}'", price, status, type, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteRoom(string id)
        {
            string query = string.Format("delete from PHONG where ID_PHONG = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
