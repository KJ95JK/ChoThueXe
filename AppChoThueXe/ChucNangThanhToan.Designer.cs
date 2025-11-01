namespace AppChoThueXe
{
    partial class ChucNangThanhToan
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
            this.lstvQuanLyThanhToan = new System.Windows.Forms.ListView();
            this.lstID_ThanhToan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstMaDatXe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstNgayThanhToan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstSoTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCapNhat = new FontAwesome.Sharp.IconButton();
            this.lbTieuDeQuanLyDonDatXe = new System.Windows.Forms.Label();
            this.grbThongTinDonDatXe = new System.Windows.Forms.GroupBox();
            this.flowPanelThongTinDon = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTenKhachHang = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lbTenXe = new System.Windows.Forms.Label();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.lbNgayThanhToan = new System.Windows.Forms.Label();
            this.dateTimeNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.txtSoTienThanhToan = new System.Windows.Forms.TextBox();
            this.lbTieuDeXuatHoaDon = new System.Windows.Forms.Label();
            this.grbNutChucNang = new System.Windows.Forms.GroupBox();
            this.btnThemHoaDon = new FontAwesome.Sharp.IconButton();
            this.grbThongTinDonDatXe.SuspendLayout();
            this.flowPanelThongTinDon.SuspendLayout();
            this.grbNutChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvQuanLyThanhToan
            // 
            this.lstvQuanLyThanhToan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstID_ThanhToan,
            this.lstMaDatXe,
            this.lstNgayThanhToan,
            this.lstSoTien,
            this.lstTrangThai});
            this.lstvQuanLyThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvQuanLyThanhToan.FullRowSelect = true;
            this.lstvQuanLyThanhToan.GridLines = true;
            this.lstvQuanLyThanhToan.HideSelection = false;
            this.lstvQuanLyThanhToan.Location = new System.Drawing.Point(404, 20);
            this.lstvQuanLyThanhToan.Name = "lstvQuanLyThanhToan";
            this.lstvQuanLyThanhToan.Size = new System.Drawing.Size(508, 409);
            this.lstvQuanLyThanhToan.TabIndex = 12;
            this.lstvQuanLyThanhToan.UseCompatibleStateImageBehavior = false;
            this.lstvQuanLyThanhToan.View = System.Windows.Forms.View.Details;
            this.lstvQuanLyThanhToan.SelectedIndexChanged += new System.EventHandler(this.lstvQuanLyThanhToan_SelectedIndexChanged);
            // 
            // lstID_ThanhToan
            // 
            this.lstID_ThanhToan.Text = "ID Thanh Toán";
            this.lstID_ThanhToan.Width = 110;
            // 
            // lstMaDatXe
            // 
            this.lstMaDatXe.Text = "Mã Đặt Xe";
            this.lstMaDatXe.Width = 90;
            // 
            // lstNgayThanhToan
            // 
            this.lstNgayThanhToan.Text = "Ngày Thanh Toán";
            this.lstNgayThanhToan.Width = 120;
            // 
            // lstSoTien
            // 
            this.lstSoTien.Text = "Số Tiền";
            // 
            // lstTrangThai
            // 
            this.lstTrangThai.Text = "Trạng Thái";
            this.lstTrangThai.Width = 120;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnCapNhat.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnCapNhat.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnCapNhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapNhat.IconSize = 24;
            this.btnCapNhat.Location = new System.Drawing.Point(175, 27);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(193, 40);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập Nhật Hoá Đơn";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lbTieuDeQuanLyDonDatXe
            // 
            this.lbTieuDeQuanLyDonDatXe.AutoSize = true;
            this.lbTieuDeQuanLyDonDatXe.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDeQuanLyDonDatXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(196)))), ((int)(((byte)(190)))));
            this.lbTieuDeQuanLyDonDatXe.Location = new System.Drawing.Point(33, 20);
            this.lbTieuDeQuanLyDonDatXe.Name = "lbTieuDeQuanLyDonDatXe";
            this.lbTieuDeQuanLyDonDatXe.Size = new System.Drawing.Size(335, 45);
            this.lbTieuDeQuanLyDonDatXe.TabIndex = 9;
            this.lbTieuDeQuanLyDonDatXe.Text = "Quản Lý Thanh Toán";
            // 
            // grbThongTinDonDatXe
            // 
            this.grbThongTinDonDatXe.Controls.Add(this.flowPanelThongTinDon);
            this.grbThongTinDonDatXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinDonDatXe.Location = new System.Drawing.Point(15, 113);
            this.grbThongTinDonDatXe.Name = "grbThongTinDonDatXe";
            this.grbThongTinDonDatXe.Size = new System.Drawing.Size(374, 183);
            this.grbThongTinDonDatXe.TabIndex = 14;
            this.grbThongTinDonDatXe.TabStop = false;
            this.grbThongTinDonDatXe.Text = "Thông Tin Hoá Đơn";
            // 
            // flowPanelThongTinDon
            // 
            this.flowPanelThongTinDon.Controls.Add(this.lbTenKhachHang);
            this.flowPanelThongTinDon.Controls.Add(this.txtTenKhachHang);
            this.flowPanelThongTinDon.Controls.Add(this.lbTenXe);
            this.flowPanelThongTinDon.Controls.Add(this.txtTenXe);
            this.flowPanelThongTinDon.Controls.Add(this.lbNgayThanhToan);
            this.flowPanelThongTinDon.Controls.Add(this.dateTimeNgayThanhToan);
            this.flowPanelThongTinDon.Controls.Add(this.lbSoTien);
            this.flowPanelThongTinDon.Controls.Add(this.txtSoTienThanhToan);
            this.flowPanelThongTinDon.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelThongTinDon.Location = new System.Drawing.Point(6, 25);
            this.flowPanelThongTinDon.Name = "flowPanelThongTinDon";
            this.flowPanelThongTinDon.Size = new System.Drawing.Size(356, 146);
            this.flowPanelThongTinDon.TabIndex = 0;
            // 
            // lbTenKhachHang
            // 
            this.lbTenKhachHang.AutoSize = true;
            this.lbTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKhachHang.Location = new System.Drawing.Point(5, 5);
            this.lbTenKhachHang.Margin = new System.Windows.Forms.Padding(5);
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            this.lbTenKhachHang.Size = new System.Drawing.Size(112, 19);
            this.lbTenKhachHang.TabIndex = 15;
            this.lbTenKhachHang.Text = "Tên Khách Hàng";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(5, 34);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(163, 26);
            this.txtTenKhachHang.TabIndex = 16;
            // 
            // lbTenXe
            // 
            this.lbTenXe.AutoSize = true;
            this.lbTenXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenXe.Location = new System.Drawing.Point(5, 70);
            this.lbTenXe.Margin = new System.Windows.Forms.Padding(5);
            this.lbTenXe.Name = "lbTenXe";
            this.lbTenXe.Size = new System.Drawing.Size(54, 19);
            this.lbTenXe.TabIndex = 12;
            this.lbTenXe.Text = "Tên Xe";
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(5, 99);
            this.txtTenXe.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(163, 26);
            this.txtTenXe.TabIndex = 27;
            // 
            // lbNgayThanhToan
            // 
            this.lbNgayThanhToan.AutoSize = true;
            this.lbNgayThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThanhToan.Location = new System.Drawing.Point(178, 5);
            this.lbNgayThanhToan.Margin = new System.Windows.Forms.Padding(5);
            this.lbNgayThanhToan.Name = "lbNgayThanhToan";
            this.lbNgayThanhToan.Size = new System.Drawing.Size(117, 19);
            this.lbNgayThanhToan.TabIndex = 11;
            this.lbNgayThanhToan.Text = "Ngày Thanh Toán";
            // 
            // dateTimeNgayThanhToan
            // 
            this.dateTimeNgayThanhToan.CustomFormat = "\"dd/MM/yyyy\"";
            this.dateTimeNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayThanhToan.Location = new System.Drawing.Point(178, 34);
            this.dateTimeNgayThanhToan.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimeNgayThanhToan.Name = "dateTimeNgayThanhToan";
            this.dateTimeNgayThanhToan.Size = new System.Drawing.Size(165, 26);
            this.dateTimeNgayThanhToan.TabIndex = 28;
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTien.Location = new System.Drawing.Point(178, 70);
            this.lbSoTien.Margin = new System.Windows.Forms.Padding(5);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(55, 19);
            this.lbSoTien.TabIndex = 21;
            this.lbSoTien.Text = "Số Tiền";
            // 
            // txtSoTienThanhToan
            // 
            this.txtSoTienThanhToan.Location = new System.Drawing.Point(178, 99);
            this.txtSoTienThanhToan.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoTienThanhToan.Name = "txtSoTienThanhToan";
            this.txtSoTienThanhToan.Size = new System.Drawing.Size(163, 26);
            this.txtSoTienThanhToan.TabIndex = 22;
            // 
            // lbTieuDeXuatHoaDon
            // 
            this.lbTieuDeXuatHoaDon.AutoSize = true;
            this.lbTieuDeXuatHoaDon.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDeXuatHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(196)))), ((int)(((byte)(190)))));
            this.lbTieuDeXuatHoaDon.Location = new System.Drawing.Point(83, 65);
            this.lbTieuDeXuatHoaDon.Name = "lbTieuDeXuatHoaDon";
            this.lbTieuDeXuatHoaDon.Size = new System.Drawing.Size(239, 45);
            this.lbTieuDeXuatHoaDon.TabIndex = 13;
            this.lbTieuDeXuatHoaDon.Text = "Xuất Hoá Đơn";
            // 
            // grbNutChucNang
            // 
            this.grbNutChucNang.Controls.Add(this.btnCapNhat);
            this.grbNutChucNang.Controls.Add(this.btnThemHoaDon);
            this.grbNutChucNang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNutChucNang.Location = new System.Drawing.Point(15, 302);
            this.grbNutChucNang.Name = "grbNutChucNang";
            this.grbNutChucNang.Size = new System.Drawing.Size(374, 88);
            this.grbNutChucNang.TabIndex = 15;
            this.grbNutChucNang.TabStop = false;
            this.grbNutChucNang.Text = "Nút Chức Năng";
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.btnThemHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnThemHoaDon.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnThemHoaDon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnThemHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemHoaDon.IconSize = 24;
            this.btnThemHoaDon.Location = new System.Drawing.Point(13, 27);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(143, 40);
            this.btnThemHoaDon.TabIndex = 0;
            this.btnThemHoaDon.Text = "Xuât Hoá Đơn";
            this.btnThemHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemHoaDon.UseVisualStyleBackColor = false;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // ChucNangThanhToan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.grbNutChucNang);
            this.Controls.Add(this.grbThongTinDonDatXe);
            this.Controls.Add(this.lbTieuDeXuatHoaDon);
            this.Controls.Add(this.lstvQuanLyThanhToan);
            this.Controls.Add(this.lbTieuDeQuanLyDonDatXe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChucNangThanhToan";
            this.Size = new System.Drawing.Size(985, 510);
            this.Load += new System.EventHandler(this.ChucNangThanhToan_Load);
            this.grbThongTinDonDatXe.ResumeLayout(false);
            this.flowPanelThongTinDon.ResumeLayout(false);
            this.flowPanelThongTinDon.PerformLayout();
            this.grbNutChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvQuanLyThanhToan;
        private System.Windows.Forms.ColumnHeader lstID_ThanhToan;
        private System.Windows.Forms.ColumnHeader lstMaDatXe;
        private System.Windows.Forms.ColumnHeader lstNgayThanhToan;
        private System.Windows.Forms.ColumnHeader lstSoTien;
        private System.Windows.Forms.ColumnHeader lstTrangThai;
        private FontAwesome.Sharp.IconButton btnCapNhat;
        private System.Windows.Forms.Label lbTieuDeQuanLyDonDatXe;
        private System.Windows.Forms.GroupBox grbThongTinDonDatXe;
        private System.Windows.Forms.FlowLayoutPanel flowPanelThongTinDon;
        private System.Windows.Forms.Label lbTenKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lbTenXe;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.Label lbNgayThanhToan;
        private System.Windows.Forms.DateTimePicker dateTimeNgayThanhToan;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.TextBox txtSoTienThanhToan;
        private System.Windows.Forms.Label lbTieuDeXuatHoaDon;
        private System.Windows.Forms.GroupBox grbNutChucNang;
        private FontAwesome.Sharp.IconButton btnThemHoaDon;
    }
}
