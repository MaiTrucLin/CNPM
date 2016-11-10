namespace XDPMQL_CuahangPKGaming.Interface
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.lblId = new System.Windows.Forms.Label();
            this.txtboxId = new System.Windows.Forms.TextBox();
            this.txtboxPW = new System.Windows.Forms.TextBox();
            this.lblPW = new System.Windows.Forms.Label();
            this.ckboxReID = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnHuyboDN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(48, 104);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(78, 19);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Tài khoản ";
            // 
            // txtboxId
            // 
            this.txtboxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxId.Location = new System.Drawing.Point(150, 99);
            this.txtboxId.Name = "txtboxId";
            this.txtboxId.Size = new System.Drawing.Size(217, 27);
            this.txtboxId.TabIndex = 2;
            // 
            // txtboxPW
            // 
            this.txtboxPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPW.Location = new System.Drawing.Point(150, 151);
            this.txtboxPW.Name = "txtboxPW";
            this.txtboxPW.Size = new System.Drawing.Size(217, 27);
            this.txtboxPW.TabIndex = 3;
            this.txtboxPW.UseSystemPasswordChar = true;
            this.txtboxPW.TextChanged += new System.EventHandler(this.txtboxPW_TextChanged);
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPW.Location = new System.Drawing.Point(48, 159);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(71, 19);
            this.lblPW.TabIndex = 5;
            this.lblPW.Text = "Mật khẩu";
            // 
            // ckboxReID
            // 
            this.ckboxReID.AutoSize = true;
            this.ckboxReID.Location = new System.Drawing.Point(150, 203);
            this.ckboxReID.Name = "ckboxReID";
            this.ckboxReID.Size = new System.Drawing.Size(110, 17);
            this.ckboxReID.TabIndex = 6;
            this.ckboxReID.Text = "Ghi nhớ tài khoản";
            this.ckboxReID.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(65, 226);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(137, 37);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnHuyboDN
            // 
            this.btnHuyboDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyboDN.Location = new System.Drawing.Point(226, 227);
            this.btnHuyboDN.Name = "btnHuyboDN";
            this.btnHuyboDN.Size = new System.Drawing.Size(119, 37);
            this.btnHuyboDN.TabIndex = 7;
            this.btnHuyboDN.Text = "Huỷ bỏ";
            this.btnHuyboDN.UseVisualStyleBackColor = true;
            this.btnHuyboDN.Click += new System.EventHandler(this.btnHuyboDN_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 92);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(61, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ CỬA HÀNG GAMING GEAR";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(438, 288);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHuyboDN);
            this.Controls.Add(this.ckboxReID);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtboxPW);
            this.Controls.Add(this.txtboxId);
            this.Controls.Add(this.lblId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Login";
            this.Text = "Đăng nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f_FormClosed);
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtboxId;
        private System.Windows.Forms.TextBox txtboxPW;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.CheckBox ckboxReID;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnHuyboDN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}