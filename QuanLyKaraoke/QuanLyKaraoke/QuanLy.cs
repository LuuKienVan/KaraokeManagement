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
    public partial class QuanLy : Form
    {
        BindingSource serviceList = new BindingSource();
        BindingSource accountList = new BindingSource();
        BindingSource roomList = new BindingSource();
        BindingSource employeeList = new BindingSource();

        public QuanLy()
        {
            InitializeComponent();
            dtgDichVu.DataSource = serviceList;
            dtgAccount.DataSource = accountList;
            dtgPhong.DataSource = roomList;
            dtgNhanVien.DataSource = employeeList;
            LoadServiceList();
            ServiceBinding();
            LoadAccountList();
            AccountBinding();
            LoadRoomList();
            RoomBinding();
            LoadEmployeeList();
            EmployeeBinding();
        }

        #region Events
        private void btnViewDichVu_Click(object sender, EventArgs e)
        {
            LoadServiceList();
        }

        private void btnAddDichVu_Click(object sender, EventArgs e)
        {
            string name = txbTenDichVu.Text;
            int price = Convert.ToInt32(txbGiaDichVu.Text);

            if (ServiceDAO.Instance.InsertService(name,price))
            {
                MessageBox.Show("Thêm dịch vụ thành công.");
            }
            else
            {
                MessageBox.Show("Xuất hiện lỗi khi thêm dịch vụ.");
            }
        }

        private void btnUpdateDichVu_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIDDichVu.Text);
            string name = txbTenDichVu.Text;
            int price = Convert.ToInt32(txbGiaDichVu.Text);

            if (ServiceDAO.Instance.UpdateService(id, name, price))
            {
                MessageBox.Show("Cập nhật dịch vụ thành công.");
            }
            else
            {
                MessageBox.Show("Xuất hiện lỗi cập nhật dịch vụ.");
            }
        }

        private void btnDeleteDichVu_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIDDichVu.Text);

            if (ServiceDAO.Instance.DeleteService(id))
            {
                MessageBox.Show("Xóa dịch vụ thành công.");
            }
            else
            {
                MessageBox.Show("Xuất hiện lỗi khi xóa dịch vụ.");
            }
        }

        private void btnSearchService_Click(object sender, EventArgs e)
        {
            serviceList.DataSource = SearchServiceByName(txbSearchService.Text);
        }

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txbAccountName.Text;
            string displayName = txbAccountDisplay.Text;
            int type = Convert.ToInt32(nudAccountType.Text);


            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công.");
            }
            else
            {
                MessageBox.Show("Tên tài khoản bị trùng.");
            }

            LoadAccountList();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txbAccountName.Text;

            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công.");
            }
            else
            {
                MessageBox.Show("Xuất hiện lỗi khi xóa tài khoản.");
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string userName = txbAccountName.Text;
            string displayName = txbAccountDisplay.Text;
            int type = Convert.ToInt32(nudAccountType.Text);


            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công.");
            }
            else
            {
                MessageBox.Show("Lỗi cập nhật tài khoản.");
            }

            LoadAccountList();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string userName = txbAccountName.Text;
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đã cài lại mật khẩu.");
            }
            else
            {
                MessageBox.Show("Cài lại mật khẩu thất bại");
            }

        }

        private void btnAddPhong_Click(object sender, EventArgs e)
        {
            string id = txbIDPhong.Text;
            int price = Convert.ToInt32(txbTienThuePhong.Text);
            string status = txbTinhTrangPhong.Text;
            string type = txbLoaiPhong.Text;


            if (RoomDAO.Instance.InsertRoom(id, price, status, type))
            {
                MessageBox.Show("Thêm phòng thành công.");
            }
            else
            {
                MessageBox.Show("Thêm phòng thất bại.");
            }

            LoadRoomList();
        }

        private void btnDeletePhong_Click(object sender, EventArgs e)
        {
            string id = txbIDPhong.Text;

            if (RoomDAO.Instance.DeleteRoom(id))
            {
                MessageBox.Show("Xóa phòng thành công.");
            }
            else
            {
                MessageBox.Show("Xóa phòng thất bại.");
            }

            LoadRoomList();
        }

        private void btnUpdatePhong_Click(object sender, EventArgs e)
        {
            string id = txbIDPhong.Text;
            int price = Convert.ToInt32(txbTienThuePhong.Text);
            string status = txbTinhTrangPhong.Text;
            string type = txbLoaiPhong.Text;


            if (RoomDAO.Instance.UpdateRoom(id, price, status, type))
            {
                MessageBox.Show("Cập nhật phòng thành công.");
            }
            else
            {
                MessageBox.Show("Cập nhật phòng thất bại.");
            }

            LoadRoomList();
        }

        private void btnViewRoom_Click(object sender, EventArgs e)
        {
            LoadRoomList();
        }

        private void btnAddNhanVien_Click(object sender, EventArgs e)
        {
            string name = txbTenNhanVien.Text;
            DateTime? date = dtpNgaySinh.Value;
            int gender = Convert.ToInt32(txbGioiTinh.Text);
            string idNum = txbCMND.Text;
            string phoneNum = txbSDT.Text;
            string address = txbDiaChi.Text;
            string email = txbEmail.Text;

            if (EmployeeDAO.Instance.InsertEmployee(name,date,gender,idNum,phoneNum,address,email))
            {
                MessageBox.Show("Thêm nhân viên thành công.");
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại.");
            }

            LoadEmployeeList();
        }
        private void btnUpdateNhanVien_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIDNhanVien.Text);
            string name = txbTenNhanVien.Text;
            DateTime? date = dtpNgaySinh.Value;
            int gender = Convert.ToInt32(txbGioiTinh.Text);
            string idNum = txbCMND.Text;
            string phoneNum = txbSDT.Text;
            string address = txbDiaChi.Text;
            string email = txbEmail.Text;

            if (EmployeeDAO.Instance.UpdateEmployee(id, name, date, gender, idNum, phoneNum, address, email))
            {
                MessageBox.Show("Cập nhật nhân viên thành công.");
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên thất bại.");
            }

            LoadEmployeeList();
        }

        private void btnDeleteNhanVien_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIDNhanVien.Text);

            if (EmployeeDAO.Instance.DeleteEmployee(id))
            {
                MessageBox.Show("Xóa nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }

            LoadEmployeeList();
        }

        private void btnViewNhanVien_Click(object sender, EventArgs e)
        {
            LoadEmployeeList();
        }
        #endregion

        #region Methods
        void ServiceBinding()
        {
            txbIDDichVu.DataBindings.Add(new Binding("Text", dtgDichVu.DataSource, "ID_DICHVU", true, DataSourceUpdateMode.Never));
            txbTenDichVu.DataBindings.Add(new Binding("Text", dtgDichVu.DataSource, "TENDICHVU", true, DataSourceUpdateMode.Never));
            txbGiaDichVu.DataBindings.Add(new Binding("Text", dtgDichVu.DataSource, "GIADICHVU", true, DataSourceUpdateMode.Never));
        }

        void AccountBinding()
        {
            txbAccountName.DataBindings.Add(new Binding("Text", dtgAccount.DataSource, "TEN_TAIKHOAN", true, DataSourceUpdateMode.Never));
            txbAccountDisplay.DataBindings.Add(new Binding("Text", dtgAccount.DataSource, "TEN_HIENTHI", true, DataSourceUpdateMode.Never));
            nudAccountType.DataBindings.Add(new Binding("Text", dtgAccount.DataSource, "LOAITAIKHOAN", true, DataSourceUpdateMode.Never));
        }

        void RoomBinding()
        {
            txbIDPhong.DataBindings.Add(new Binding("Text", dtgPhong.DataSource, "ID_PHONG", true, DataSourceUpdateMode.Never));
            txbTienThuePhong.DataBindings.Add(new Binding("Text", dtgPhong.DataSource, "TIENTHUE", true, DataSourceUpdateMode.Never));
            txbTinhTrangPhong.DataBindings.Add(new Binding("Text", dtgPhong.DataSource, "TINHTRANG", true, DataSourceUpdateMode.Never));
            txbLoaiPhong.DataBindings.Add(new Binding("Text", dtgPhong.DataSource, "LOAIPHONG", true, DataSourceUpdateMode.Never));
        }

        void EmployeeBinding()
        {
            txbIDNhanVien.DataBindings.Add(new Binding("Text", dtgNhanVien.DataSource, "ID_NHANVIEN", true, DataSourceUpdateMode.Never));
            txbTenNhanVien.DataBindings.Add(new Binding("Text", dtgNhanVien.DataSource, "HOTEN", true, DataSourceUpdateMode.Never));
            dtpNgaySinh.DataBindings.Add(new Binding("Text", dtgNhanVien.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never));
            txbGioiTinh.DataBindings.Add(new Binding("Text", dtgNhanVien.DataSource, "GIOITINH", true, DataSourceUpdateMode.Never));
            txbCMND.DataBindings.Add(new Binding("Text", dtgNhanVien.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            txbSDT.DataBindings.Add(new Binding("Text", dtgNhanVien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txbDiaChi.DataBindings.Add(new Binding("Text", dtgNhanVien.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
            txbEmail.DataBindings.Add(new Binding("Text", dtgNhanVien.DataSource, "EMAIL", true, DataSourceUpdateMode.Never));
        }

        DataTable SearchServiceByName(string name)
        {
            DataTable dt = new DataTable();

            dt = ServiceDAO.Instance.SearchSeviceByName(name);

            return dt;
        }

        void LoadServiceList()
        {
            serviceList.DataSource = ServiceDAO.Instance.GetServiceList();
        }

        void LoadAccountList()
        {
            accountList.DataSource = AccountDAO.Instance.GetAccountList();
        }

        void LoadRoomList()
        {
            roomList.DataSource = RoomDAO.Instance.GetRoomList();
        }

        void LoadEmployeeList()
        {
            employeeList.DataSource = EmployeeDAO.Instance.GetEmployeeList();
        }
        #endregion
    }
}
