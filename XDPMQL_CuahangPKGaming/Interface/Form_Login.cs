using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XDPMQL_CuahangPKGaming.Interface
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void txtboxPW_TextChanged(object sender, EventArgs e)
        {

        }
        Form NextForm(string id)
        {
            Form f = new Form();
            switch (id)
            {
                case "1":
                    f = new Form_Quanly();
                    break;
                case "2":
                    f = new Form_QLKDPK();
                    break;
                case "3":
                    f = new Form_Quanlykho();
                    break;
                case "4":
                    f = new Form_Nhanvienbaohanh();
                    break;
            }
            return f;
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string TK = txtboxId.Text;
            string MK = txtboxPW.Text;

            Form f = NextForm(TK.ToString());

            f.FormClosed += f_FormClosed;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            this.Hide();
        }
        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();

        }

        private void btnHuyboDN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
