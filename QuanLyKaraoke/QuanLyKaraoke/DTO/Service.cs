using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKaraoke.DTO
{
    public class Service
    {
        private int id;
        private string name;
        private int price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }

        public Service(int id, string name, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public Service(DataRow dtRow)
        {
            this.Id = (int)dtRow["ID_DICHVU"];
            this.Name = dtRow["TENDICHVU"].ToString();
            this.Price = (int)dtRow["GIADICHVU"];
        }
    }
}
