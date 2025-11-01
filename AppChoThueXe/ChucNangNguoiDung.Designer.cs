namespace AppChoThueXe
{
    partial class ChucNangNguoiDung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstvQuanLyNguoiDung = new System.Windows.Forms.ListView();
            this.lstIDNguoiDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstMatKhau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstQuyen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbNutChucNang = new System.Windows.Forms.GroupBox();
            this.btnSuaNguoiDung = new FontAwesome.Sharp.IconButton();
            this.btnXoaNguoiDung = new FontAwesome.Sharp.IconButton();
            this.btnThemNguoiDung = new FontAwesome.Sharp.IconButton();
            this.grbThongTinDonDatXe = new System.Windows.Forms.GroupBox();
            this.flowPanelThongTinDon = new System.Windows.Forms.FlowLayoutPanel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lbQuyen = new System.Windows.Forms.Label();
            this.cbbQuyen = new System.Windows.Forms.ComboBox();
            this.lbTieuDeQuanLyDonDatXe = new System.Windows.Forms.Label();
            this.grbNutChucNang.SuspendLayout();
            this.grbThongTinDonDatXe.SuspendLayout();
            this.flowPanelThongTinDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvQuanLyNguoiDung
            // 
            this.lstvQuanLyNguoiDung.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstIDNguoiDung,
            this.lstUsername,
            this.lstMatKhau,
            this.lstQuyen});
            this.lstvQuanLyNguoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvQuanLyNguoiDung.FullRowSelect = true;
            this.lstvQuanLyNguoiDung.GridLines = true;
            this.lstvQuanLyNguoiDung.HideSelection = false;
            this.lstvQuanLyNguoiDung.Location = new System.Drawing.Point(396, 20);
            this.lstvQuanLyNguoiDung.Name = "lstvQuanLyNguoiDung";
            this.lstvQuanLyNguoiDung.Size = new System.Drawing.Size(385, 322);
            this.lstvQuanLyNguoiDung.TabIndex = 12;
            this.lstvQuanLyNguoiDung.UseCompatibleStateImageBehavior = false;
            this.lstvQuanLyNguoiDung.View = System.Windows.Forms.View.Details;
            this.lstvQuanLyNguoiDung.SelectedIndexChanged += new System.EventHandler(this.lstvQuanLyNguoiDung_SelectedIndexChanged);
            // 
            // lstIDNguoiDung
            // 
            this.lstIDNguoiDung.Text = "ID Người Dùng";
            this.lstIDNguoiDung.Width = 110;
            // 
            // lstUsername
            // 
            this.lstUsername.Text = "Username";
            this.lstUsername.Width = 80;
            // 
            // lstMatKhau
            // 
            this.lstMatKhau.Text = "Mật Khẩu";
            this.lstMatKhau.Width = 80;
            // 
            // lstQuyen
            // 
            this.lstQuyen.Text = "Quyền";
            this.lstQuyen.Width = 100;
            // 
            // grbNutChucNang
            // 
            this.grbNutChucNang.Controls.Add(this.btnSuaNguoiDung);
            this.grbNutChucNang.Controls.Add(this.btnXoaNguoiDung);
            this.grbNutChucNang.Controls.Add(this.btnThemNguoiDung);
            this.grbNutChucNang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNutChucNang.Location = new System.Drawing.Point(6, 185);
            this.grbNutChucNang.Name = "grbNutChucNang";
            this.grbNutChucNang.Size = new System.Drawing.Size(356, 77);
            this.grbNutChucNang.TabIndex = 11;
            this.grbNutChucNang.TabStop = false;
            this.grbNutChucNang.Text = "Nút Chức Năng";
            // 
            // btnSuaNguoiDung
            // 
            this.btnSuaNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.btnSuaNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnSuaNguoiDung.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSuaNguoiDung.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnSuaNguoiDung.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaNguoiDung.IconSize = 24;
            this.btnSuaNguoiDung.Location = new System.Drawing.Point(233, 25);
            this.btnSuaNguoiDung.Name = "btnSuaNguoiDung";
            this.btnSuaNguoiDung.Size = new System.Drawing.Size(112, 40);
            this.btnSuaNguoiDung.TabIndex = 2;
            this.btnSuaNguoiDung.Text = "Sửa";
            this.btnSuaNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaNguoiDung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaNguoiDung.UseVisualStyleBackColor = false;
            this.btnSuaNguoiDung.Click += new System.EventHandler(this.btnSuaDon_Click);
            // 
            // btnXoaNguoiDung
            // 
            this.btnXoaNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.btnXoaNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnXoaNguoiDung.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoaNguoiDung.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnXoaNguoiDung.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaNguoiDung.IconSize = 24;
            this.btnXoaNguoiDung.Location = new System.Drawing.Point(121, 25);
            this.btnXoaNguoiDung.Name = "btnXoaNguoiDung";
            this.btnXoaNguoiDung.Size = new System.Drawing.Size(106, 40);
            this.btnXoaNguoiDung.TabIndex = 1;
            this.btnXoaNguoiDung.Text = "Xoá";
            this.btnXoaNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaNguoiDung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaNguoiDung.UseVisualStyleBackColor = false;
            this.btnXoaNguoiDung.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemNguoiDung
            // 
            this.btnThemNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.btnThemNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnThemNguoiDung.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnThemNguoiDung.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnThemNguoiDung.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemNguoiDung.IconSize = 24;
            this.btnThemNguoiDung.Location = new System.Drawing.Point(11, 25);
            this.btnThemNguoiDung.Name = "btnThemNguoiDung";
            this.btnThemNguoiDung.Size = new System.Drawing.Size(104, 40);
            this.btnThemNguoiDung.TabIndex = 0;
            this.btnThemNguoiDung.Text = "Thêm";
            this.btnThemNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemNguoiDung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemNguoiDung.UseVisualStyleBackColor = false;
            this.btnThemNguoiDung.Click += new System.EventHandler(this.btnThemDon_Click);
            // 
            // grbThongTinDonDatXe
            // 
            this.grbThongTinDonDatXe.Controls.Add(this.flowPanelThongTinDon);
            this.grbThongTinDonDatXe.Controls.Add(this.grbNutChucNang);
            this.grbThongTinDonDatXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinDonDatXe.Location = new System.Drawing.Point(16, 62);
            this.grbThongTinDonDatXe.Name = "grbThongTinDonDatXe";
            this.grbThongTinDonDatXe.Size = new System.Drawing.Size(374, 280);
            this.grbThongTinDonDatXe.TabIndex = 10;
            this.grbThongTinDonDatXe.TabStop = false;
            this.grbThongTinDonDatXe.Text = "Thông Tin Người Dùng";
            // 
            // flowPanelThongTinDon
            // 
            this.flowPanelThongTinDon.Controls.Add(this.lbUsername);
            this.flowPanelThongTinDon.Controls.Add(this.txtUsername);
            this.flowPanelThongTinDon.Controls.Add(this.lbQuyen);
            this.flowPanelThongTinDon.Controls.Add(this.cbbQuyen);
            this.flowPanelThongTinDon.Controls.Add(this.lbMatKhau);
            this.flowPanelThongTinDon.Controls.Add(this.txtMatKhau);
            this.flowPanelThongTinDon.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelThongTinDon.Location = new System.Drawing.Point(6, 25);
            this.flowPanelThongTinDon.Name = "flowPanelThongTinDon";
            this.flowPanelThongTinDon.Size = new System.Drawing.Size(356, 154);
            this.flowPanelThongTinDon.TabIndex = 0;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(5, 5);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(5);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(70, 19);
            this.lbUsername.TabIndex = 15;
            this.lbUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(5, 34);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(163, 26);
            this.txtUsername.TabIndex = 16;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(180, 5);
            this.lbMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(71, 19);
            this.lbMatKhau.TabIndex = 12;
            this.lbMatKhau.Text = "Mật Khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(180, 34);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(163, 26);
            this.txtMatKhau.TabIndex = 27;
            // 
            // lbQuyen
            // 
            this.lbQuyen.AutoSize = true;
            this.lbQuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuyen.Location = new System.Drawing.Point(5, 70);
            this.lbQuyen.Margin = new System.Windows.Forms.Padding(5);
            this.lbQuyen.Name = "lbQuyen";
            this.lbQuyen.Size = new System.Drawing.Size(49, 19);
            this.lbQuyen.TabIndex = 35;
            this.lbQuyen.Text = "Quyền";
            // 
            // cbbQuyen
            // 
            this.cbbQuyen.FormattingEnabled = true;
            this.cbbQuyen.Location = new System.Drawing.Point(3, 97);
            this.cbbQuyen.Name = "cbbQuyen";
            this.cbbQuyen.Size = new System.Drawing.Size(169, 27);
            this.cbbQuyen.TabIndex = 36;
            // 
            // lbTieuDeQuanLyDonDatXe
            // 
            this.lbTieuDeQuanLyDonDatXe.AutoSize = true;
            this.lbTieuDeQuanLyDonDatXe.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDeQuanLyDonDatXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(196)))), ((int)(((byte)(190)))));
            this.lbTieuDeQuanLyDonDatXe.Location = new System.Drawing.Point(30, 14);
            this.lbTieuDeQuanLyDonDatXe.Name = "lbTieuDeQuanLyDonDatXe";
            this.lbTieuDeQuanLyDonDatXe.Size = new System.Drawing.Size(346, 45);
            this.lbTieuDeQuanLyDonDatXe.TabIndex = 9;
            this.lbTieuDeQuanLyDonDatXe.Text = "Quản Lý Người Dùng";
            // 
            // ChucNangNguoiDung
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.lstvQuanLyNguoiDung);
            this.Controls.Add(this.grbThongTinDonDatXe);
            this.Controls.Add(this.lbTieuDeQuanLyDonDatXe);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ChucNangNguoiDung";
            this.Size = new System.Drawing.Size(985, 510);
            this.Load += new System.EventHandler(this.ChucNangNguoiDung_Load);
            this.grbNutChucNang.ResumeLayout(false);
            this.grbThongTinDonDatXe.ResumeLayout(false);
            this.flowPanelThongTinDon.ResumeLayout(false);
            this.flowPanelThongTinDon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvQuanLyNguoiDung;
        private System.Windows.Forms.ColumnHeader lstIDNguoiDung;
        private System.Windows.Forms.ColumnHeader lstUsername;
        private System.Windows.Forms.ColumnHeader lstMatKhau;
        private System.Windows.Forms.ColumnHeader lstQuyen;
        private System.Windows.Forms.GroupBox grbNutChucNang;
        private FontAwesome.Sharp.IconButton btnSuaNguoiDung;
        private FontAwesome.Sharp.IconButton btnXoaNguoiDung;
        private FontAwesome.Sharp.IconButton btnThemNguoiDung;
        private System.Windows.Forms.GroupBox grbThongTinDonDatXe;
        private System.Windows.Forms.FlowLayoutPanel flowPanelThongTinDon;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lbTieuDeQuanLyDonDatXe;
        private System.Windows.Forms.Label lbQuyen;
        private System.Windows.Forms.ComboBox cbbQuyen;
    }
}
