using QuanLyKaraoke.DAO;
using QuanLyKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKaraoke
{
    public partial class QuanLyKaraoke : Form
    {
        public QuanLyKaraoke()
        {
            InitializeComponent();

            LoadRoomList();
        }

        #region Methods
        void LoadRoomList()
        {
            List<Room> roomList = RoomDAO.Instance.LoadRoomList();

            foreach (Room item in roomList)
            {
                Button btn = new Button() { Height = RoomDAO.roomHeight, Width = RoomDAO.roomWidth };
                btn.Text = item.ID + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightGreen;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flpRoom.Controls.Add(btn);
            }
        }
        #endregion

        #region Events
        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLy f = new QuanLy();
            f.ShowDialog();
        }

        void ShowBill(string id)
        {

        }
        private void Btn_Click(object sender, EventArgs e)
        {
            string roomId = (sender as Room).ID;
            ShowBill(roomId);
        }
        #endregion

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
