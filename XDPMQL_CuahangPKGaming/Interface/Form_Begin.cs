using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XDPMQL_CuahangPKGaming.Interface;

namespace XDPMQL_CuahangPKGaming
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBegin_Click(object sender, EventArgs e)
        {  
            Form f =new Form_Login();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            f.FormClosed += f_FormClosed;
            this.Hide();
        }
        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();

        }

        private void proCessload_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgBar_load.Increment(1);
            // Thời gian chờ chương trình khởi động

            if(pgBar_load.Value==100)
            {
                timer1.Stop();
                btnBegin.Enabled = true;
            }
        }
    }
}
