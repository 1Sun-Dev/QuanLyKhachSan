// Đảm bảo namespace là QuanLyKhachSan
namespace QuanLyKhachSan
{
    partial class frmSoDoPhong
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
            this.flowLayoutPanelPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelPhong
            // 
            this.flowLayoutPanelPhong.AutoScroll = true;
            this.flowLayoutPanelPhong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPhong.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelPhong.Name = "flowLayoutPanelPhong";
            this.flowLayoutPanelPhong.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanelPhong.Size = new System.Drawing.Size(900, 600);
            this.flowLayoutPanelPhong.TabIndex = 0;
            this.flowLayoutPanelPhong.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelPhong_Paint);
            // 
            // frmSoDoPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.flowLayoutPanelPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSoDoPhong";
            this.Text = "Sơ Đồ Phòng";
            this.Load += new System.EventHandler(this.frmSoDoPhong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        // Chỉ khai báo control của form này
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPhong;
    }
}