namespace QuanLyKhachSan // Đảm bảo namespace khớp
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
            this.menuPhong = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.itemDatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCapNhatDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemChuyenPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.itemThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemHoanTatDon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelPhong
            // 
            this.flowLayoutPanelPhong.AutoScroll = true;
            this.flowLayoutPanelPhong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPhong.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanelPhong.Name = "flowLayoutPanelPhong";
            this.flowLayoutPanelPhong.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.flowLayoutPanelPhong.Size = new System.Drawing.Size(1350, 923);
            this.flowLayoutPanelPhong.TabIndex = 0;
            this.flowLayoutPanelPhong.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelPhong_Paint);
            // 
            // menuPhong
            // 
            this.menuPhong.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuPhong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDatPhong,
            this.itemCapNhatDichVu,
            this.itemChuyenPhong,
            this.itemThanhToan,
            this.toolStripSeparator1,
            this.itemHoanTatDon});
            this.menuPhong.Name = "menuPhong";
            this.menuPhong.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.menuPhong.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.menuPhong.RenderStyle.ColorTable = null;
            this.menuPhong.RenderStyle.RoundedEdges = true;
            this.menuPhong.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.menuPhong.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menuPhong.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.menuPhong.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.menuPhong.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.menuPhong.Size = new System.Drawing.Size(317, 170);
            // 
            // itemDatPhong
            // 
            this.itemDatPhong.Name = "itemDatPhong";
            this.itemDatPhong.Size = new System.Drawing.Size(316, 32);
            this.itemDatPhong.Text = "Đặt phòng";
            // 
            // itemCapNhatDichVu
            // 
            this.itemCapNhatDichVu.Name = "itemCapNhatDichVu";
            this.itemCapNhatDichVu.Size = new System.Drawing.Size(316, 32);
            this.itemCapNhatDichVu.Text = "Cập nhật Sản phẩm - Dịch vụ";
            // 
            // itemChuyenPhong
            // 
            this.itemChuyenPhong.Name = "itemChuyenPhong";
            this.itemChuyenPhong.Size = new System.Drawing.Size(316, 32);
            this.itemChuyenPhong.Text = "Chuyển phòng";
            // 
            // itemThanhToan
            // 
            this.itemThanhToan.Name = "itemThanhToan";
            this.itemThanhToan.Size = new System.Drawing.Size(316, 32);
            this.itemThanhToan.Text = "Thanh toán";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(313, 6);
            // 
            // itemHoanTatDon
            // 
            this.itemHoanTatDon.Name = "itemHoanTatDon";
            this.itemHoanTatDon.Size = new System.Drawing.Size(316, 32);
            this.itemHoanTatDon.Text = "Đánh dấu đã dọn xong";
            // 
            // frmSoDoPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 923);
            this.Controls.Add(this.flowLayoutPanelPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSoDoPhong";
            this.Text = "Sơ Đồ Phòng";
            this.Load += new System.EventHandler(this.frmSoDoPhong_Load);
            this.menuPhong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPhong;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip menuPhong;
        private System.Windows.Forms.ToolStripMenuItem itemDatPhong;
        private System.Windows.Forms.ToolStripMenuItem itemCapNhatDichVu;
        private System.Windows.Forms.ToolStripMenuItem itemChuyenPhong;
        private System.Windows.Forms.ToolStripMenuItem itemThanhToan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemHoanTatDon;
    }
}