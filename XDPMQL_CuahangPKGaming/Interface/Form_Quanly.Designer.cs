namespace XDPMQL_CuahangPKGaming.Interface
{
    partial class Form_Quanly
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip_QLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_TTCN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_QLNV_Xemdanhsach = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_TTCN_Xemchitiet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_TTCN_Doimatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.tbControl_QuanLy = new System.Windows.Forms.TabControl();
            this.tabPage_QLNV = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_DSNV = new System.Windows.Forms.TabPage();
            this.btnTimphong = new System.Windows.Forms.Button();
            this.cbbTimNV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvDSNhanVien = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ckBNam = new System.Windows.Forms.CheckBox();
            this.cbbChucDanh = new System.Windows.Forms.ComboBox();
            this.cbbMNV = new System.Windows.Forms.ComboBox();
            this.txtML = new System.Windows.Forms.TextBox();
            this.dtpkNS = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tbControl_QuanLy.SuspendLayout();
            this.tabPage_QLNV.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_DSNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNhanVien)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_QLNV,
            this.menuStrip_TTCN,
            this.menuStrip_Logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(951, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip_QLNV
            // 
            this.menuStrip_QLNV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_QLNV_Xemdanhsach});
            this.menuStrip_QLNV.Name = "menuStrip_QLNV";
            this.menuStrip_QLNV.Size = new System.Drawing.Size(115, 20);
            this.menuStrip_QLNV.Text = "Quản lý nhân viên";
            // 
            // menuStrip_TTCN
            // 
            this.menuStrip_TTCN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_TTCN_Xemchitiet,
            this.menuStrip_TTCN_Doimatkhau});
            this.menuStrip_TTCN.Name = "menuStrip_TTCN";
            this.menuStrip_TTCN.Size = new System.Drawing.Size(116, 20);
            this.menuStrip_TTCN.Text = "Thông tin cá nhân";
            // 
            // menuStrip_Logout
            // 
            this.menuStrip_Logout.Name = "menuStrip_Logout";
            this.menuStrip_Logout.Size = new System.Drawing.Size(72, 20);
            this.menuStrip_Logout.Text = "Đăng xuất";
            // 
            // menuStrip_QLNV_Xemdanhsach
            // 
            this.menuStrip_QLNV_Xemdanhsach.Name = "menuStrip_QLNV_Xemdanhsach";
            this.menuStrip_QLNV_Xemdanhsach.Size = new System.Drawing.Size(210, 22);
            this.menuStrip_QLNV_Xemdanhsach.Text = "Xem danh sách nhân viên";
            // 
            // menuStrip_TTCN_Xemchitiet
            // 
            this.menuStrip_TTCN_Xemchitiet.Name = "menuStrip_TTCN_Xemchitiet";
            this.menuStrip_TTCN_Xemchitiet.Size = new System.Drawing.Size(179, 22);
            this.menuStrip_TTCN_Xemchitiet.Text = "Xem chi tiết";
            // 
            // menuStrip_TTCN_Doimatkhau
            // 
            this.menuStrip_TTCN_Doimatkhau.Name = "menuStrip_TTCN_Doimatkhau";
            this.menuStrip_TTCN_Doimatkhau.Size = new System.Drawing.Size(179, 22);
            this.menuStrip_TTCN_Doimatkhau.Text = "Đổi mật khẩu";
            // 
            // tbControl_QuanLy
            // 
            this.tbControl_QuanLy.Controls.Add(this.tabPage_QLNV);
            this.tbControl_QuanLy.Location = new System.Drawing.Point(0, 28);
            this.tbControl_QuanLy.Name = "tbControl_QuanLy";
            this.tbControl_QuanLy.SelectedIndex = 0;
            this.tbControl_QuanLy.Size = new System.Drawing.Size(944, 494);
            this.tbControl_QuanLy.TabIndex = 1;
            // 
            // tabPage_QLNV
            // 
            this.tabPage_QLNV.Controls.Add(this.tabControl1);
            this.tabPage_QLNV.Location = new System.Drawing.Point(4, 22);
            this.tabPage_QLNV.Name = "tabPage_QLNV";
            this.tabPage_QLNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_QLNV.Size = new System.Drawing.Size(936, 468);
            this.tabPage_QLNV.TabIndex = 0;
            this.tabPage_QLNV.Text = "Quản lý nhân viên";
            this.tabPage_QLNV.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_DSNV);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_DSNV
            // 
            this.tabPage_DSNV.Controls.Add(this.panel3);
            this.tabPage_DSNV.Controls.Add(this.dtgvDSNhanVien);
            this.tabPage_DSNV.Controls.Add(this.btnTimphong);
            this.tabPage_DSNV.Controls.Add(this.cbbTimNV);
            this.tabPage_DSNV.Controls.Add(this.label3);
            this.tabPage_DSNV.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DSNV.Name = "tabPage_DSNV";
            this.tabPage_DSNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DSNV.Size = new System.Drawing.Size(923, 440);
            this.tabPage_DSNV.TabIndex = 0;
            this.tabPage_DSNV.Text = "Danh sách nhân viên";
            this.tabPage_DSNV.UseVisualStyleBackColor = true;
            // 
            // btnTimphong
            // 
            this.btnTimphong.Location = new System.Drawing.Point(324, 27);
            this.btnTimphong.Name = "btnTimphong";
            this.btnTimphong.Size = new System.Drawing.Size(103, 35);
            this.btnTimphong.TabIndex = 12;
            this.btnTimphong.Text = "Tìm ";
            this.btnTimphong.UseVisualStyleBackColor = true;
            // 
            // cbbTimNV
            // 
            this.cbbTimNV.FormattingEnabled = true;
            this.cbbTimNV.Location = new System.Drawing.Point(114, 35);
            this.cbbTimNV.Name = "cbbTimNV";
            this.cbbTimNV.Size = new System.Drawing.Size(177, 21);
            this.cbbTimNV.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tìm nhân viên";
            // 
            // dtgvDSNhanVien
            // 
            this.dtgvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSNhanVien.Location = new System.Drawing.Point(6, 68);
            this.dtgvDSNhanVien.Name = "dtgvDSNhanVien";
            this.dtgvDSNhanVien.Size = new System.Drawing.Size(507, 353);
            this.dtgvDSNhanVien.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.ckBNam);
            this.panel3.Controls.Add(this.cbbChucDanh);
            this.panel3.Controls.Add(this.cbbMNV);
            this.panel3.Controls.Add(this.txtML);
            this.panel3.Controls.Add(this.dtpkNS);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtTenNV);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Location = new System.Drawing.Point(552, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 353);
            this.panel3.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Giới tính";
            // 
            // ckBNam
            // 
            this.ckBNam.AutoSize = true;
            this.ckBNam.Location = new System.Drawing.Point(130, 101);
            this.ckBNam.Name = "ckBNam";
            this.ckBNam.Size = new System.Drawing.Size(48, 17);
            this.ckBNam.TabIndex = 16;
            this.ckBNam.Text = "Nam";
            this.ckBNam.UseVisualStyleBackColor = true;
            // 
            // cbbChucDanh
            // 
            this.cbbChucDanh.FormattingEnabled = true;
            this.cbbChucDanh.Location = new System.Drawing.Point(130, 175);
            this.cbbChucDanh.Name = "cbbChucDanh";
            this.cbbChucDanh.Size = new System.Drawing.Size(174, 21);
            this.cbbChucDanh.TabIndex = 15;
            // 
            // cbbMNV
            // 
            this.cbbMNV.FormattingEnabled = true;
            this.cbbMNV.Location = new System.Drawing.Point(129, 23);
            this.cbbMNV.Name = "cbbMNV";
            this.cbbMNV.Size = new System.Drawing.Size(174, 21);
            this.cbbMNV.TabIndex = 14;
            // 
            // txtML
            // 
            this.txtML.Location = new System.Drawing.Point(130, 219);
            this.txtML.Name = "txtML";
            this.txtML.Size = new System.Drawing.Size(173, 20);
            this.txtML.TabIndex = 13;
            // 
            // dtpkNS
            // 
            this.dtpkNS.Location = new System.Drawing.Point(130, 136);
            this.dtpkNS.Name = "dtpkNS";
            this.dtpkNS.Size = new System.Drawing.Size(173, 20);
            this.dtpkNS.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Chức danh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mức lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên NV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã NV";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(130, 62);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(173, 20);
            this.txtTenNV.TabIndex = 5;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(111, 295);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 33);
            this.button8.TabIndex = 4;
            this.button8.Text = "Xóa";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(217, 295);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 33);
            this.button7.TabIndex = 3;
            this.button7.Text = "Sửa";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(5, 295);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 33);
            this.button6.TabIndex = 2;
            this.button6.Text = "Thêm";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form_Quanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 526);
            this.Controls.Add(this.tbControl_QuanLy);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Quanly";
            this.Text = "Quản lý ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbControl_QuanLy.ResumeLayout(false);
            this.tabPage_QLNV.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_DSNV.ResumeLayout(false);
            this.tabPage_DSNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNhanVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_QLNV;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_QLNV_Xemdanhsach;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_TTCN;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_TTCN_Xemchitiet;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_TTCN_Doimatkhau;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Logout;
        private System.Windows.Forms.TabControl tbControl_QuanLy;
        private System.Windows.Forms.TabPage tabPage_QLNV;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_DSNV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckBNam;
        private System.Windows.Forms.ComboBox cbbChucDanh;
        private System.Windows.Forms.ComboBox cbbMNV;
        private System.Windows.Forms.TextBox txtML;
        private System.Windows.Forms.DateTimePicker dtpkNS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dtgvDSNhanVien;
        private System.Windows.Forms.Button btnTimphong;
        private System.Windows.Forms.ComboBox cbbTimNV;
        private System.Windows.Forms.Label label3;
    }
}