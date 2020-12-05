using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKaraoke.DTO
{
    public class Bill
    {
        private int idBill;
        private int idEmployee;
        private DateTime? dateCheckOut;
        private int status;

        public int IdBill { get => idBill; set => idBill = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }

        public Bill(int idBill, int idEmployee, DateTime? dateCheckOut, int status)
        {
            this.IdBill = idBill;
            this.IdEmployee = idEmployee;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }

        public Bill(DataRow dtRow)
        {
            this.IdBill = (int)dtRow["ID_HOADON"];
            this.IdEmployee = (int)dtRow["ID_NHANVIEN"];
            this.DateCheckOut = (DateTime?)dtRow["NGAYTHANHTOAN"];
            this.Status = (int)dtRow["TINHTRANG"];
        }
    }
}
