namespace QuanLyKaraoke
{
    partial class QuanLyKaraoke
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.lvRoomService = new System.Windows.Forms.ListView();
            this.btnAddService = new System.Windows.Forms.Button();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.nudServiceQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThuePhong = new System.Windows.Forms.Button();
            this.txbTongSoTien = new System.Windows.Forms.TextBox();
            this.lbTongSoTien = new System.Windows.Forms.Label();
            this.btnCapNhatPhong = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // DangXuatToolStripMenuItem
            // 
            this.DangXuatToolStripMenuItem.Name = "DangXuatToolStripMenuItem";
            this.DangXuatToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.DangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.DangXuatToolStripMenuItem.Click += new System.EventHandler(this.DangXuatToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.DangXuatToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudServiceQuantity);
            this.panel2.Controls.Add(this.cbService);
            this.panel2.Controls.Add(this.btnAddService);
            this.panel2.Location = new System.Drawing.Point(459, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 56);
            this.panel2.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.Location = new System.Drawing.Point(15, 29);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(438, 393);
            this.flpRoom.TabIndex = 3;
            // 
            // lvRoomService
            // 
            this.lvRoomService.HideSelection = false;
            this.lvRoomService.Location = new System.Drawing.Point(459, 91);
            this.lvRoomService.Name = "lvRoomService";
            this.lvRoomService.Size = new System.Drawing.Size(331, 275);
            this.lvRoomService.TabIndex = 4;
            this.lvRoomService.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(268, 3);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(60, 50);
            this.btnAddService.TabIndex = 0;
            this.btnAddService.Text = "Thêm món";
            this.btnAddService.UseVisualStyleBackColor = true;
            // 
            // cbService
            // 
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(3, 3);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(252, 21);
            this.cbService.TabIndex = 1;
            // 
            // nudServiceQuantity
            // 
            this.nudServiceQuantity.Location = new System.Drawing.Point(3, 30);
            this.nudServiceQuantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudServiceQuantity.Name = "nudServiceQuantity";
            this.nudServiceQuantity.Size = new System.Drawing.Size(252, 20);
            this.nudServiceQuantity.TabIndex = 2;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(591, 372);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(60, 50);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnThuePhong
            // 
            this.btnThuePhong.Location = new System.Drawing.Point(459, 372);
            this.btnThuePhong.Name = "btnThuePhong";
            this.btnThuePhong.Size = new System.Drawing.Size(60, 50);
            this.btnThuePhong.TabIndex = 6;
            this.btnThuePhong.Text = "Thuê phòng";
            this.btnThuePhong.UseVisualStyleBackColor = true;
            // 
            // txbTongSoTien
            // 
            this.txbTongSoTien.Location = new System.Drawing.Point(727, 369);
            this.txbTongSoTien.Name = "txbTongSoTien";
            this.txbTongSoTien.Size = new System.Drawing.Size(63, 20);
            this.txbTongSoTien.TabIndex = 7;
            // 
            // lbTongSoTien
            // 
            this.lbTongSoTien.AutoSize = true;
            this.lbTongSoTien.Location = new System.Drawing.Point(652, 372);
            this.lbTongSoTien.Name = "lbTongSoTien";
            this.lbTongSoTien.Size = new System.Drawing.Size(69, 13);
            this.lbTongSoTien.TabIndex = 8;
            this.lbTongSoTien.Text = "Tổng số tiền:";
            // 
            // btnCapNhatPhong
            // 
            this.btnCapNhatPhong.Location = new System.Drawing.Point(525, 372);
            this.btnCapNhatPhong.Name = "btnCapNhatPhong";
            this.btnCapNhatPhong.Size = new System.Drawing.Size(60, 50);
            this.btnCapNhatPhong.TabIndex = 9;
            this.btnCapNhatPhong.Text = "Cập nhật phòng";
            this.btnCapNhatPhong.UseVisualStyleBackColor = true;
            // 
            // QuanLyKaraoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 434);
            this.Controls.Add(this.btnCapNhatPhong);
            this.Controls.Add(this.lbTongSoTien);
            this.Controls.Add(this.txbTongSoTien);
            this.Controls.Add(this.btnThuePhong);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lvRoomService);
            this.Controls.Add(this.flpRoom);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLyKaraoke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán karaoke";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.NumericUpDown nudServiceQuantity;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.ListView lvRoomService;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThuePhong;
        private System.Windows.Forms.TextBox txbTongSoTien;
        private System.Windows.Forms.Label lbTongSoTien;
        private System.Windows.Forms.Button btnCapNhatPhong;
    }
}