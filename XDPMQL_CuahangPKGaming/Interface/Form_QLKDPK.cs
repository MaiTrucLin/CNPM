using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XDPMQL_CuahangPKGaming.Database;

namespace XDPMQL_CuahangPKGaming.Interface
{
    public partial class Form_QLKDPK : Form
    {
        public Form_QLKDPK()
        {
            InitializeComponent();
        }

        //Hàm khởi tạo các giá trị ban đầu
        void Load_Start()
        {
            //Disable các textbox tabControl Danh mục phụ kiện
            Disable_UpdatePK();
        }
        //Các hàm binding cơ sở dữ liệu
        void BindingPhong(DataGridView dtgv)
        {
            Binding bdMaPK = new Binding("Text", dtgv.DataSource, "Mã_phụ_kiện", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMaPK.DataBindings.Clear();
            txtMaPK.DataBindings.Add(bdMaPK);

            Binding bdLoaiPK = new Binding("Text", dtgv.DataSource, "Loại_phụ_kiện", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLoaiPK.DataBindings.Clear();
            txtLoaiPK.DataBindings.Add(bdLoaiPK);

            Binding bdGia = new Binding("Text", dtgv.DataSource, "Giá", true, DataSourceUpdateMode.OnPropertyChanged);
            txtGiapk.DataBindings.Clear();
            txtGiapk.DataBindings.Add(bdGia);

            Binding bdKieuPK= new Binding("Text", dtgv.DataSource, "Kiểu_phụ_kiện", true, DataSourceUpdateMode.OnPropertyChanged);
            txtKieuPK.DataBindings.Clear();
            txtKieuPK.DataBindings.Add(bdKieuPK);

            
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void giChúNhanhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void cơSởDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tạoMớiCơSởDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saoLưuCơSởDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phụcHồiCơSởDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thayĐổiMậtKhẩuĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtKhỏiHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátKhỏiHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnBánHàngToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcPhụKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcHãngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêDanhSáchMặtHàngBánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dáToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcPhụKiệnTrongCửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcPhụKiệnTrongKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bắtĐầuSửDụngPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêDoanhThuToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêMặtHàngBánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cbbTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Tạo mới hóa đơn

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_QLKDPK_Load(object sender, EventArgs e)
        {
            Load_Start();
            Load_DSPK(dtgVDSPK);
            Load_DMPK(dtgvDMPK);
            Load_DMNCC(dtgvDMNCC);
        }
        void Load_DMPK(DataGridView dtgv)
        {
            using (GamingGearEntities db = new GamingGearEntities())
            {
                var source = from pk in db.PHUKIENs
                             from lpk in db.LOAIPKs
                             from kpk in db.KIEUPKs
                             where pk.MakieuPK == kpk.MakieuPK & pk.MaloaiPK == lpk.MaloaiPK
                             select new
                             {
                                 Mã_phụ_kiện = pk.MaPK,
                                 Loại_phụ_kiện = lpk.TenloaiPK,
                                 Kiểu_phụ_kiện = kpk.TenkieuPK,
                                 Giá = lpk.Gia
                             };

                dtgv.DataSource = source.ToList();
            }
        }
        void Load_DSPK(DataGridView dtgv)
        {
            using (GamingGearEntities db = new GamingGearEntities())
            {
                var source = from pk in db.PHUKIENs
                             from lpk in db.LOAIPKs
                             from kpk in db.KIEUPKs
                             from hpk in db.HANGs
                             where pk.MakieuPK == kpk.MakieuPK & pk.MaloaiPK == lpk.MaloaiPK & lpk.MaHANG==hpk.MaHANG
                             select new{
                              Mã_phụ_kiện = pk.MaPK,
                              Loại_phụ_kiện = lpk.TenloaiPK,
                              Kiểu_phụ_kiện = kpk.TenkieuPK,
                              Hãng=hpk.Tenhang,
                              Giá = lpk.Gia
                             };

                dtgv.DataSource = source.ToList();
            }
        }
        void Load_DMNCC(DataGridView dtgv)
        {
            using (GamingGearEntities db = new GamingGearEntities())
            {
                var source = from pk in db.NHACUNGCAPs
                             select new
                             {
                                 Mã_nhà_cung_cấp = pk.MaNCC,
                                 Tên_nhà_cung_cấp = pk.TenNCC,
                                 Địa_chỉ = pk.Diachi,
                                 Số_Fax = pk.soFax,
                                 Mail = pk.Mail
                             };

                dtgv.DataSource = source.ToList();
            }
        }
        void Disable_UpdatePK()
        {
            txtMaPK.Enabled = false;
            txtLoaiPK.Enabled = false;
            txtKieuPK.Enabled = false;
            txtHangpk.Enabled = false;
            txtGiapk.Enabled = false;
            txtSLCHpk.Enabled = false;
            txtSLKpk.Enabled = false;
        }
        void Enable_UpdatePK()
        {
            txtMaPK.Enabled = true;
            txtLoaiPK.Enabled = true;
            txtKieuPK.Enabled = true;
            txtHangpk.Enabled = true;
            txtGiapk.Enabled = true;
            txtSLCHpk.Enabled = true;
            txtSLKpk.Enabled = true;
        }

        private void dtgvDMPK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvDMPK_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDMPK.SelectedCells.Count == 0)
                return;
            string MaPK = dtgvDMPK.SelectedCells[0].OwningRow.Cells["Mã_phụ_kiện"].Value.ToString();
            BindingPhong(dtgvDMPK);
        }

        private bool boolChinhsuaPK = false; //Biến bool kiểm tra chỉnh sửa thông tin phụ kiện trong tabControl Danh mục phụ kiện
      
        private void button12_Click(object sender, EventArgs e)
        {
            if (boolChinhsuaPK == false)
            {
                boolChinhsuaPK = true;
                btnChinhsuaPK.Text = "Hủy";
                Enable_UpdatePK();
            }
            else
            {
                boolChinhsuaPK = false;
                btnChinhsuaPK.Text = "Chỉnh sửa thông tin";
                Disable_UpdatePK();
            }
           
        }

        private void dtgVDSPK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public int _stt = 0;
        private void dtgVDSPK_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dtgVDSPK.CurrentCell == null)
                return;
            try
            {
                int r = this.dtgVDSPK.CurrentCell.RowIndex;
                int c = this.dtgVDSPK.CurrentCell.ColumnIndex;
                string _MaPK = dtgVDSPK.Rows[r].Cells[0].Value.ToString();
                string _KieuPK = dtgVDSPK.Rows[r].Cells[1].Value.ToString();
                string _LoaiPK = dtgVDSPK.Rows[r].Cells[2].Value.ToString();
                string _Hang = dtgVDSPK.Rows[r].Cells[3].Value.ToString();
                string _Gia = dtgVDSPK.Rows[r].Cells[4].Value.ToString();
                _stt ++;
                dtgvGiohang.Rows.Add(_stt.ToString(), _MaPK.ToString(), _KieuPK.ToString(),_LoaiPK.ToString() ,_Hang.ToString(), _Gia.ToString());
                ThongTinHoaDon();
            }
            catch
            {
                ThongTinHoaDon();
            }
        }
        private void ThongTinHoaDon()
        {
            float Tienhang = 0;
            for (int i = 0; i < _stt; i++)
            {
                string MPK = dtgvGiohang.Rows[i].Cells[5].Value.ToString();
                txtTienhang.Text = MPK.ToString();
            }
            
        }
    }
}
