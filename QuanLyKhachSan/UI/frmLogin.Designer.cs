namespace QuanLyKhachSan
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.gnEliptxtUseName = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnEliptxtPassWord = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnLoginUser = new System.Windows.Forms.Panel();
            this.gntxtTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThoat = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDangNhap = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbForgotPasswordLG = new System.Windows.Forms.Label();
            this.rbtnGNT = new System.Windows.Forms.RadioButton();
            this.gntxtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnLoginUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // gnEliptxtUseName
            // 
            this.gnEliptxtUseName.BorderRadius = 25;
            this.gnEliptxtUseName.TargetControl = this.gntxtTaiKhoan;
            // 
            // gnEliptxtPassWord
            // 
            this.gnEliptxtPassWord.BorderRadius = 25;
            this.gnEliptxtPassWord.TargetControl = this.gntxtMatKhau;
            // 
            // pnLoginUser
            // 
            this.pnLoginUser.Controls.Add(this.gntxtTaiKhoan);
            this.pnLoginUser.Controls.Add(this.btnThoat);
            this.pnLoginUser.Controls.Add(this.btnDangNhap);
            this.pnLoginUser.Controls.Add(this.lbForgotPasswordLG);
            this.pnLoginUser.Controls.Add(this.rbtnGNT);
            this.pnLoginUser.Controls.Add(this.gntxtMatKhau);
            this.pnLoginUser.Controls.Add(this.lbMatKhau);
            this.pnLoginUser.Controls.Add(this.lbTaiKhoan);
            this.pnLoginUser.Location = new System.Drawing.Point(658, 33);
            this.pnLoginUser.Name = "pnLoginUser";
            this.pnLoginUser.Size = new System.Drawing.Size(483, 632);
            this.pnLoginUser.TabIndex = 2;
            // 
            // gntxtTaiKhoan
            // 
            this.gntxtTaiKhoan.BackColor = System.Drawing.Color.OldLace;
            this.gntxtTaiKhoan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gntxtTaiKhoan.BorderThickness = 0;
            this.gntxtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtTaiKhoan.DefaultText = "";
            this.gntxtTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTaiKhoan.FillColor = System.Drawing.Color.PaleTurquoise;
            this.gntxtTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.gntxtTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.gntxtTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTaiKhoan.Location = new System.Drawing.Point(48, 65);
            this.gntxtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gntxtTaiKhoan.Name = "gntxtTaiKhoan";
            this.gntxtTaiKhoan.PlaceholderText = "";
            this.gntxtTaiKhoan.SelectedText = "";
            this.gntxtTaiKhoan.Size = new System.Drawing.Size(368, 55);
            this.gntxtTaiKhoan.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.DarkGray;
            this.btnThoat.FillColor2 = System.Drawing.Color.Silver;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(95, 510);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(290, 75);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangNhap.FillColor = System.Drawing.Color.DarkTurquoise;
            this.btnDangNhap.FillColor2 = System.Drawing.Color.MediumPurple;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(130, 360);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(218, 61);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lbForgotPasswordLG
            // 
            this.lbForgotPasswordLG.AutoSize = true;
            this.lbForgotPasswordLG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotPasswordLG.ForeColor = System.Drawing.Color.Blue;
            this.lbForgotPasswordLG.Location = new System.Drawing.Point(178, 454);
            this.lbForgotPasswordLG.Name = "lbForgotPasswordLG";
            this.lbForgotPasswordLG.Size = new System.Drawing.Size(131, 20);
            this.lbForgotPasswordLG.TabIndex = 7;
            this.lbForgotPasswordLG.Text = "Forgot PassWord ?";
            // 
            // rbtnGNT
            // 
            this.rbtnGNT.AutoSize = true;
            this.rbtnGNT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGNT.ForeColor = System.Drawing.Color.DarkGray;
            this.rbtnGNT.Location = new System.Drawing.Point(56, 300);
            this.rbtnGNT.Name = "rbtnGNT";
            this.rbtnGNT.Size = new System.Drawing.Size(121, 27);
            this.rbtnGNT.TabIndex = 5;
            this.rbtnGNT.TabStop = true;
            this.rbtnGNT.Text = "Ghi nhớ tôi";
            this.rbtnGNT.UseVisualStyleBackColor = true;
            // 
            // gntxtMatKhau
            // 
            this.gntxtMatKhau.BackColor = System.Drawing.Color.White;
            this.gntxtMatKhau.BorderColor = System.Drawing.Color.White;
            this.gntxtMatKhau.BorderThickness = 0;
            this.gntxtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtMatKhau.DefaultText = "";
            this.gntxtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtMatKhau.FillColor = System.Drawing.Color.PaleTurquoise;
            this.gntxtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.gntxtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.gntxtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtMatKhau.Location = new System.Drawing.Point(48, 211);
            this.gntxtMatKhau.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gntxtMatKhau.Name = "gntxtMatKhau";
            this.gntxtMatKhau.PasswordChar = '●';
            this.gntxtMatKhau.PlaceholderText = "";
            this.gntxtMatKhau.SelectedText = "";
            this.gntxtMatKhau.Size = new System.Drawing.Size(368, 55);
            this.gntxtMatKhau.TabIndex = 2;
            this.gntxtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyDown);
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(49, 147);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(152, 41);
            this.lbMatKhau.TabIndex = 2;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan.Location = new System.Drawing.Point(41, 3);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(153, 41);
            this.lbTaiKhoan.TabIndex = 0;
            this.lbTaiKhoan.Text = "Tài khoản";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::QuanLyKhachSan.Properties.Resources.thiết_kế_lại_ảnh_bằnggg1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, -2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(637, 686);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 35;
            this.guna2Elipse1.TargetControl = this.btnDangNhap;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 35;
            this.guna2Elipse2.TargetControl = this.btnThoat;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1153, 686);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.pnLoginUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.pnLoginUser.ResumeLayout(false);
            this.pnLoginUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        private Guna.UI2.WinForms.Guna2Elipse gnEliptxtUseName;
        private Guna.UI2.WinForms.Guna2Elipse gnEliptxtPassWord;
        private System.Windows.Forms.Panel pnLoginUser;
        private Guna.UI2.WinForms.Guna2TextBox gntxtTaiKhoan;
        private Guna.UI2.WinForms.Guna2GradientButton btnThoat;
        private Guna.UI2.WinForms.Guna2GradientButton btnDangNhap;
        private System.Windows.Forms.Label lbForgotPasswordLG;
        private System.Windows.Forms.RadioButton rbtnGNT;
        private Guna.UI2.WinForms.Guna2TextBox gntxtMatKhau;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbTaiKhoan;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
