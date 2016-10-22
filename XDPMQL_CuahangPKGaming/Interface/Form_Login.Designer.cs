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
            this.lblId = new System.Windows.Forms.Label();
            this.txtboxId = new System.Windows.Forms.TextBox();
            this.txtboxPW = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPW = new System.Windows.Forms.Label();
            this.ckboxReID = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(59, 62);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(78, 19);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Tài khoản ";
            // 
            // txtboxId
            // 
            this.txtboxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxId.Location = new System.Drawing.Point(161, 57);
            this.txtboxId.Name = "txtboxId";
            this.txtboxId.Size = new System.Drawing.Size(199, 27);
            this.txtboxId.TabIndex = 2;
            // 
            // txtboxPW
            // 
            this.txtboxPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPW.Location = new System.Drawing.Point(161, 109);
            this.txtboxPW.Name = "txtboxPW";
            this.txtboxPW.Size = new System.Drawing.Size(199, 27);
            this.txtboxPW.TabIndex = 3;
            this.txtboxPW.UseSystemPasswordChar = true;
            this.txtboxPW.TextChanged += new System.EventHandler(this.txtboxPW_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(146, 190);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 37);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPW.Location = new System.Drawing.Point(59, 117);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(71, 19);
            this.lblPW.TabIndex = 5;
            this.lblPW.Text = "Mật khẩu";
            // 
            // ckboxReID
            // 
            this.ckboxReID.AutoSize = true;
            this.ckboxReID.Location = new System.Drawing.Point(170, 155);
            this.ckboxReID.Name = "ckboxReID";
            this.ckboxReID.Size = new System.Drawing.Size(110, 17);
            this.ckboxReID.TabIndex = 6;
            this.ckboxReID.Text = "Ghi nhớ tài khoản";
            this.ckboxReID.UseVisualStyleBackColor = true;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 261);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtboxId;
        private System.Windows.Forms.TextBox txtboxPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.CheckBox ckboxReID;
    }
}