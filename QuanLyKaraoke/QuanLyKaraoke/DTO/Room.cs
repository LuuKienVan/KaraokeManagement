using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKaraoke.DTO
{
    public class Room
    {
        private string iD;
        private int price;
        private string status;
        private string type;

        public string ID { get => iD; set => iD = value; }
        public int Price { get => price; set => price = value; }
        public string Status { get => status; set => status = value; }
        public string Type { get => type; set => type = value; }

        public Room(string id, int price, string status, string type = null)
        {
            this.ID = id;
            this.Price = price;
            this.Status = status;
            this.Type = type;
        }

        public Room(DataRow dtRow)
        {
            this.ID = dtRow["ID_PHONG"].ToString();
            this.Price = (int)dtRow["TIENTHUE"];
            this.Status = dtRow["TINHTRANG"].ToString();
            this.Type = dtRow["LOAIPHONG"].ToString();
        }
    }
}
