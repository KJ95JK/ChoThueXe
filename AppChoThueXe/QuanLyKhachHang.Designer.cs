namespace AppChoThueXe
{
    partial class QuanLyKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyKhachHang));
            this.lbTieuDeQuanLyDonDatXe = new System.Windows.Forms.Label();
            this.lstvQuanLyKhachHang = new System.Windows.Forms.ListView();
            this.lstIDKhachHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTenKhachHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstCCCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstSoDienThoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowPanelThongTinDon = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTenKhachHang = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lbCCCD = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.dateTimeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.flowPanelGioiTinh = new System.Windows.Forms.FlowLayoutPanel();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.grbNutChucNang = new System.Windows.Forms.GroupBox();
            this.btnSuaKhachHang = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnXoaKhachHang = new FontAwesome.Sharp.IconButton();
            this.btnThemKhachHang = new FontAwesome.Sharp.IconButton();
            this.flowPanelThongTinDon.SuspendLayout();
            this.flowPanelGioiTinh.SuspendLayout();
            this.grbNutChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTieuDeQuanLyDonDatXe
            // 
            this.lbTieuDeQuanLyDonDatXe.AutoSize = true;
            this.lbTieuDeQuanLyDonDatXe.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDeQuanLyDonDatXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(196)))), ((int)(((byte)(190)))));
            this.lbTieuDeQuanLyDonDatXe.Location = new System.Drawing.Point(67, 6);
            this.lbTieuDeQuanLyDonDatXe.Name = "lbTieuDeQuanLyDonDatXe";
            this.lbTieuDeQuanLyDonDatXe.Size = new System.Drawing.Size(342, 45);
            this.lbTieuDeQuanLyDonDatXe.TabIndex = 6;
            this.lbTieuDeQuanLyDonDatXe.Text = "Quản Lý Khách Hàng";
            // 
            // lstvQuanLyKhachHang
            // 
            this.lstvQuanLyKhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstIDKhachHang,
            this.lstTenKhachHang,
            this.lstCCCD,
            this.lstNgaySinh,
            this.lstSoDienThoai,
            this.lstEmail,
            this.lstGioiTinh});
            this.lstvQuanLyKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvQuanLyKhachHang.FullRowSelect = true;
            this.lstvQuanLyKhachHang.GridLines = true;
            this.lstvQuanLyKhachHang.HideSelection = false;
            this.lstvQuanLyKhachHang.Location = new System.Drawing.Point(12, 57);
            this.lstvQuanLyKhachHang.Name = "lstvQuanLyKhachHang";
            this.lstvQuanLyKhachHang.Size = new System.Drawing.Size(452, 335);
            this.lstvQuanLyKhachHang.TabIndex = 9;
            this.lstvQuanLyKhachHang.UseCompatibleStateImageBehavior = false;
            this.lstvQuanLyKhachHang.View = System.Windows.Forms.View.Details;
            this.lstvQuanLyKhachHang.SelectedIndexChanged += new System.EventHandler(this.lstvQuanLyDonDatXe_SelectedIndexChanged);
            // 
            // lstIDKhachHang
            // 
            this.lstIDKhachHang.Text = "ID Khách Hàng";
            this.lstIDKhachHang.Width = 90;
            // 
            // lstTenKhachHang
            // 
            this.lstTenKhachHang.Text = "Tên Khách Hàng";
            this.lstTenKhachHang.Width = 120;
            // 
            // lstCCCD
            // 
            this.lstCCCD.Text = "Căn Cước Công Dân";
            // 
            // lstNgaySinh
            // 
            this.lstNgaySinh.Text = "Ngày Sinh";
            this.lstNgaySinh.Width = 80;
            // 
            // lstSoDienThoai
            // 
            this.lstSoDienThoai.Text = "Số Điện Thoại";
            this.lstSoDienThoai.Width = 100;
            // 
            // lstEmail
            // 
            this.lstEmail.Text = "Email";
            this.lstEmail.Width = 70;
            // 
            // lstGioiTinh
            // 
            this.lstGioiTinh.Text = "Giới Tính";
            this.lstGioiTinh.Width = 90;
            // 
            // flowPanelThongTinDon
            // 
            this.flowPanelThongTinDon.Controls.Add(this.lbTenKhachHang);
            this.flowPanelThongTinDon.Controls.Add(this.txtTenKhachHang);
            this.flowPanelThongTinDon.Controls.Add(this.lbCCCD);
            this.flowPanelThongTinDon.Controls.Add(this.txtCCCD);
            this.flowPanelThongTinDon.Controls.Add(this.lbNgaySinh);
            this.flowPanelThongTinDon.Controls.Add(this.dateTimeNgaySinh);
            this.flowPanelThongTinDon.Controls.Add(this.lbGioiTinh);
            this.flowPanelThongTinDon.Controls.Add(this.flowPanelGioiTinh);
            this.flowPanelThongTinDon.Controls.Add(this.lbEmail);
            this.flowPanelThongTinDon.Controls.Add(this.txtEmail);
            this.flowPanelThongTinDon.Controls.Add(this.lbSoDienThoai);
            this.flowPanelThongTinDon.Controls.Add(this.txtSoDienThoai);
            this.flowPanelThongTinDon.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelThongTinDon.Location = new System.Drawing.Point(486, 57);
            this.flowPanelThongTinDon.Name = "flowPanelThongTinDon";
            this.flowPanelThongTinDon.Size = new System.Drawing.Size(356, 218);
            this.flowPanelThongTinDon.TabIndex = 10;
            // 
            // lbTenKhachHang
            // 
            this.lbTenKhachHang.AutoSize = true;
            this.lbTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKhachHang.Location = new System.Drawing.Point(5, 5);
            this.lbTenKhachHang.Margin = new System.Windows.Forms.Padding(5);
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            this.lbTenKhachHang.Size = new System.Drawing.Size(112, 19);
            this.lbTenKhachHang.TabIndex = 21;
            this.lbTenKhachHang.Text = "Tên Khách Hàng";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(5, 34);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(163, 26);
            this.txtTenKhachHang.TabIndex = 22;
            // 
            // lbCCCD
            // 
            this.lbCCCD.AutoSize = true;
            this.lbCCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCCCD.Location = new System.Drawing.Point(5, 70);
            this.lbCCCD.Margin = new System.Windows.Forms.Padding(5);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Size = new System.Drawing.Size(139, 19);
            this.lbCCCD.TabIndex = 15;
            this.lbCCCD.Text = "Căn Cước Công Dân";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(5, 99);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(5);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(163, 26);
            this.txtCCCD.TabIndex = 16;
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(5, 135);
            this.lbNgaySinh.Margin = new System.Windows.Forms.Padding(5);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(72, 19);
            this.lbNgaySinh.TabIndex = 23;
            this.lbNgaySinh.Text = "Ngày Sinh";
            // 
            // dateTimeNgaySinh
            // 
            this.dateTimeNgaySinh.Location = new System.Drawing.Point(5, 164);
            this.dateTimeNgaySinh.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimeNgaySinh.Name = "dateTimeNgaySinh";
            this.dateTimeNgaySinh.Size = new System.Drawing.Size(165, 26);
            this.dateTimeNgaySinh.TabIndex = 33;
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.Location = new System.Drawing.Point(180, 5);
            this.lbGioiTinh.Margin = new System.Windows.Forms.Padding(5);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(64, 19);
            this.lbGioiTinh.TabIndex = 25;
            this.lbGioiTinh.Text = "Giới Tính";
            // 
            // flowPanelGioiTinh
            // 
            this.flowPanelGioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanelGioiTinh.Controls.Add(this.radNam);
            this.flowPanelGioiTinh.Controls.Add(this.radNu);
            this.flowPanelGioiTinh.Location = new System.Drawing.Point(180, 34);
            this.flowPanelGioiTinh.Margin = new System.Windows.Forms.Padding(5);
            this.flowPanelGioiTinh.Name = "flowPanelGioiTinh";
            this.flowPanelGioiTinh.Size = new System.Drawing.Size(167, 28);
            this.flowPanelGioiTinh.TabIndex = 34;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(3, 3);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 23);
            this.radNam.TabIndex = 2;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(66, 3);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(48, 23);
            this.radNu.TabIndex = 3;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(180, 72);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(5);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 19);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(180, 101);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 26);
            this.txtEmail.TabIndex = 31;
            // 
            // lbSoDienThoai
            // 
            this.lbSoDienThoai.AutoSize = true;
            this.lbSoDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDienThoai.Location = new System.Drawing.Point(180, 137);
            this.lbSoDienThoai.Margin = new System.Windows.Forms.Padding(5);
            this.lbSoDienThoai.Name = "lbSoDienThoai";
            this.lbSoDienThoai.Size = new System.Drawing.Size(96, 19);
            this.lbSoDienThoai.TabIndex = 19;
            this.lbSoDienThoai.Text = "Số Điện Thoại";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(180, 166);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(163, 26);
            this.txtSoDienThoai.TabIndex = 32;
            // 
            // grbNutChucNang
            // 
            this.grbNutChucNang.Controls.Add(this.btnSuaKhachHang);
            this.grbNutChucNang.Controls.Add(this.btnThoat);
            this.grbNutChucNang.Controls.Add(this.btnXoaKhachHang);
            this.grbNutChucNang.Controls.Add(this.btnThemKhachHang);
            this.grbNutChucNang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNutChucNang.Location = new System.Drawing.Point(470, 281);
            this.grbNutChucNang.Name = "grbNutChucNang";
            this.grbNutChucNang.Padding = new System.Windows.Forms.Padding(0);
            this.grbNutChucNang.Size = new System.Drawing.Size(380, 126);
            this.grbNutChucNang.TabIndex = 11;
            this.grbNutChucNang.TabStop = false;
            this.grbNutChucNang.Text = "Nút Chức Năng";
            // 
            // btnSuaKhachHang
            // 
            this.btnSuaKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.btnSuaKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnSuaKhachHang.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnSuaKhachHang.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnSuaKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaKhachHang.IconSize = 24;
            this.btnSuaKhachHang.Location = new System.Drawing.Point(196, 25);
            this.btnSuaKhachHang.Margin = new System.Windows.Forms.Padding(0);
            this.btnSuaKhachHang.Name = "btnSuaKhachHang";
            this.btnSuaKhachHang.Size = new System.Drawing.Size(175, 40);
            this.btnSuaKhachHang.TabIndex = 7;
            this.btnSuaKhachHang.Text = "Sửa Khách Hàng";
            this.btnSuaKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaKhachHang.UseVisualStyleBackColor = false;
            this.btnSuaKhachHang.Click += new System.EventHandler(this.btnSuaKhachHang_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.btnThoat.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.IconSize = 24;
            this.btnThoat.Location = new System.Drawing.Point(194, 71);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(178, 40);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaKhachHang
            // 
            this.btnXoaKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.btnXoaKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnXoaKhachHang.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoaKhachHang.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnXoaKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaKhachHang.IconSize = 24;
            this.btnXoaKhachHang.Location = new System.Drawing.Point(15, 71);
            this.btnXoaKhachHang.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoaKhachHang.Name = "btnXoaKhachHang";
            this.btnXoaKhachHang.Size = new System.Drawing.Size(175, 40);
            this.btnXoaKhachHang.TabIndex = 5;
            this.btnXoaKhachHang.Text = "Xoá Khách Hàng";
            this.btnXoaKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaKhachHang.UseVisualStyleBackColor = false;
            this.btnXoaKhachHang.Click += new System.EventHandler(this.btnXoaKhachHang_Click);
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.btnThemKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnThemKhachHang.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnThemKhachHang.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnThemKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemKhachHang.IconSize = 24;
            this.btnThemKhachHang.Location = new System.Drawing.Point(15, 25);
            this.btnThemKhachHang.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(175, 40);
            this.btnThemKhachHang.TabIndex = 3;
            this.btnThemKhachHang.Text = "Thêm Khách Hàng";
            this.btnThemKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemKhachHang.UseVisualStyleBackColor = false;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(861, 404);
            this.Controls.Add(this.grbNutChucNang);
            this.Controls.Add(this.flowPanelThongTinDon);
            this.Controls.Add(this.lstvQuanLyKhachHang);
            this.Controls.Add(this.lbTieuDeQuanLyDonDatXe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            this.flowPanelThongTinDon.ResumeLayout(false);
            this.flowPanelThongTinDon.PerformLayout();
            this.flowPanelGioiTinh.ResumeLayout(false);
            this.flowPanelGioiTinh.PerformLayout();
            this.grbNutChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDeQuanLyDonDatXe;
        private System.Windows.Forms.ListView lstvQuanLyKhachHang;
        private System.Windows.Forms.ColumnHeader lstIDKhachHang;
        private System.Windows.Forms.ColumnHeader lstTenKhachHang;
        private System.Windows.Forms.ColumnHeader lstCCCD;
        private System.Windows.Forms.ColumnHeader lstNgaySinh;
        private System.Windows.Forms.ColumnHeader lstSoDienThoai;
        private System.Windows.Forms.ColumnHeader lstEmail;
        private System.Windows.Forms.ColumnHeader lstGioiTinh;
        private System.Windows.Forms.FlowLayoutPanel flowPanelThongTinDon;
        private System.Windows.Forms.Label lbCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lbTenKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.DateTimePicker dateTimeNgaySinh;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.FlowLayoutPanel flowPanelGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.GroupBox grbNutChucNang;
        private FontAwesome.Sharp.IconButton btnThoat;
        private FontAwesome.Sharp.IconButton btnXoaKhachHang;
        private FontAwesome.Sharp.IconButton btnThemKhachHang;
        private FontAwesome.Sharp.IconButton btnSuaKhachHang;
    }
}