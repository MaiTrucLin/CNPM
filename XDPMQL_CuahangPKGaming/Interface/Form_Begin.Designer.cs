namespace XDPMQL_CuahangPKGaming
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNamePM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pgBar_load = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblNamePM
            // 
            this.lblNamePM.AutoSize = true;
            this.lblNamePM.BackColor = System.Drawing.Color.Transparent;
            this.lblNamePM.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePM.ForeColor = System.Drawing.Color.Red;
            this.lblNamePM.Location = new System.Drawing.Point(153, 106);
            this.lblNamePM.Name = "lblNamePM";
            this.lblNamePM.Size = new System.Drawing.Size(722, 39);
            this.lblNamePM.TabIndex = 0;
            this.lblNamePM.Text = "PHẦN MỀM QUẢN LÝ CỬA HÀNG KINH DOANH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(327, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHỤ KIỆN CHƠI GAME";
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(369, 330);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(250, 31);
            this.btnBegin.TabIndex = 2;
            this.btnBegin.Text = "Khởi động chương trình";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 32;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pgBar_load
            // 
            this.pgBar_load.Location = new System.Drawing.Point(280, 435);
            this.pgBar_load.Name = "pgBar_load";
            this.pgBar_load.Size = new System.Drawing.Size(426, 23);
            this.pgBar_load.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1035, 562);
            this.Controls.Add(this.pgBar_load);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNamePM);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Load Chương trình";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamePM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pgBar_load;
    }
}

