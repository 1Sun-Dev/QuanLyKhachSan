namespace QuanLyPhong_SyNguyen
{
 partial class Suathongitnphong
 {
 private System.ComponentModel.IContainer components = null;
 protected override void Dispose(bool disposing)
 {
 if (disposing && (components != null))
 {
 components.Dispose();
 }
 base.Dispose(disposing);
 }
 #region Windows Form Designer generated code
 private void InitializeComponent()
 {
            this.pnl = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtRoomID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoomName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtType = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BorderRadius = 8;
            this.pnl.Controls.Add(this.lblHeading);
            this.pnl.Controls.Add(this.txtRoomID);
            this.pnl.Controls.Add(this.txtRoomName);
            this.pnl.Controls.Add(this.txtType);
            this.pnl.Controls.Add(this.txtPrice);
            this.pnl.Controls.Add(this.txtStatus);
            this.pnl.Controls.Add(this.btnSave);
            this.pnl.Controls.Add(this.btnCancel);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.FillColor = System.Drawing.Color.White;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(420, 320);
            this.pnl.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(16, 16);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(220, 30);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Sửa thông tin phòng";
            // 
            // txtRoomID
            // 
            this.txtRoomID.BorderRadius = 6;
            this.txtRoomID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomID.DefaultText = "";
            this.txtRoomID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomID.Location = new System.Drawing.Point(16, 56);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.PlaceholderText = "Mã phòng";
            this.txtRoomID.SelectedText = "";
            this.txtRoomID.Size = new System.Drawing.Size(380, 30);
            this.txtRoomID.TabIndex = 2;
            this.txtRoomID.TextChanged += new System.EventHandler(this.txtRoomID_TextChanged);
            // 
            // txtRoomName
            // 
            this.txtRoomName.BorderRadius = 6;
            this.txtRoomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomName.DefaultText = "";
            this.txtRoomName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomName.Location = new System.Drawing.Point(16, 96);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.PlaceholderText = "Tên phòng";
            this.txtRoomName.SelectedText = "";
            this.txtRoomName.Size = new System.Drawing.Size(380, 30);
            this.txtRoomName.TabIndex = 3;
            // 
            // txtType
            // 
            this.txtType.BorderRadius = 6;
            this.txtType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtType.DefaultText = "";
            this.txtType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtType.Location = new System.Drawing.Point(16, 136);
            this.txtType.Name = "txtType";
            this.txtType.PlaceholderText = "Loại phòng";
            this.txtType.SelectedText = "";
            this.txtType.Size = new System.Drawing.Size(380, 30);
            this.txtType.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderRadius = 6;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.Location = new System.Drawing.Point(16, 176);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "Giá tiền";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(380, 30);
            this.txtPrice.TabIndex = 5;
            // 
            // txtStatus
            // 
            this.txtStatus.BorderRadius = 6;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.DefaultText = "";
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStatus.Location = new System.Drawing.Point(16, 216);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PlaceholderText = "Trạng thái";
            this.txtStatus.SelectedText = "";
            this.txtStatus.Size = new System.Drawing.Size(380, 30);
            this.txtStatus.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 6;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(216, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 6;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(312, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 36);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditRoomForm
            // 
            this.ClientSize = new System.Drawing.Size(420, 320);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "S?a phòng";
            this.Load += new System.EventHandler(this.EditRoomForm_Load);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

 }
 #endregion
 private Guna.UI2.WinForms.Guna2Panel pnl;
 private System.Windows.Forms.Label lblHeading;
 private Guna.UI2.WinForms.Guna2TextBox txtRoomID;
 private Guna.UI2.WinForms.Guna2TextBox txtRoomName;
 private Guna.UI2.WinForms.Guna2TextBox txtType;
 private Guna.UI2.WinForms.Guna2TextBox txtPrice;
 private Guna.UI2.WinForms.Guna2TextBox txtStatus;
 private Guna.UI2.WinForms.Guna2Button btnSave;
 private Guna.UI2.WinForms.Guna2Button btnCancel;
 }
}
