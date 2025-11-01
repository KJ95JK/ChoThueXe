namespace AppChoThueXe
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.SapXepChucNangPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTrangChu = new FontAwesome.Sharp.IconButton();
            this.btnQuanLyXe = new FontAwesome.Sharp.IconButton();
            this.btnDonDatXe = new FontAwesome.Sharp.IconButton();
            this.btnNguoiDung = new FontAwesome.Sharp.IconButton();
            this.btnThanhToan = new FontAwesome.Sharp.IconButton();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.lbXinChaoUsername = new System.Windows.Forms.Label();
            this.lbPhienBan = new System.Windows.Forms.Label();
            this.lbTenPhamMem = new System.Windows.Forms.Label();
            this.ptrLogo = new System.Windows.Forms.PictureBox();
            this.PageChucNangThanhToan = new AppChoThueXe.ChucNangThanhToan();
            this.PageChucNangNguoiDung = new AppChoThueXe.ChucNangNguoiDung();
            this.PageChucNangDonDatXe = new AppChoThueXe.ChucNangDonDatXe();
            this.PageChucNangQuanLyXe = new AppChoThueXe.ChucNangQuanLyXe();
            this.PageChucNangTrangChu = new AppChoThueXe.ChucNangTrangChu();
            this.panelControl.SuspendLayout();
            this.SapXepChucNangPanel.SuspendLayout();
            this.panelTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.panelControl.Controls.Add(this.btnDangXuat);
            this.panelControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelControl.Location = new System.Drawing.Point(-8, -1);
            this.panelControl.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(209, 564);
            this.panelControl.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.btnDangXuat.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangXuat.IconSize = 32;
            this.btnDangXuat.Location = new System.Drawing.Point(9, 513);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(200, 46);
            this.btnDangXuat.TabIndex = 14;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.DangXuat_Click);
            // 
            // SapXepChucNangPanel
            // 
            this.SapXepChucNangPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.SapXepChucNangPanel.Controls.Add(this.btnTrangChu);
            this.SapXepChucNangPanel.Controls.Add(this.btnQuanLyXe);
            this.SapXepChucNangPanel.Controls.Add(this.btnDonDatXe);
            this.SapXepChucNangPanel.Controls.Add(this.btnNguoiDung);
            this.SapXepChucNangPanel.Controls.Add(this.btnThanhToan);
            this.SapXepChucNangPanel.Controls.Add(this.btnThongKe);
            this.SapXepChucNangPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SapXepChucNangPanel.Location = new System.Drawing.Point(1, 51);
            this.SapXepChucNangPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SapXepChucNangPanel.Name = "SapXepChucNangPanel";
            this.SapXepChucNangPanel.Size = new System.Drawing.Size(200, 344);
            this.SapXepChucNangPanel.TabIndex = 1;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnTrangChu.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnTrangChu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnTrangChu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrangChu.IconSize = 32;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 0);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(200, 46);
            this.btnTrangChu.TabIndex = 4;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnQuanLyXe
            // 
            this.btnQuanLyXe.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyXe.FlatAppearance.BorderSize = 0;
            this.btnQuanLyXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyXe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnQuanLyXe.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.btnQuanLyXe.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnQuanLyXe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuanLyXe.IconSize = 32;
            this.btnQuanLyXe.Location = new System.Drawing.Point(0, 56);
            this.btnQuanLyXe.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnQuanLyXe.Name = "btnQuanLyXe";
            this.btnQuanLyXe.Size = new System.Drawing.Size(200, 46);
            this.btnQuanLyXe.TabIndex = 5;
            this.btnQuanLyXe.Text = "Quản Lý Xe";
            this.btnQuanLyXe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyXe.UseVisualStyleBackColor = false;
            this.btnQuanLyXe.Click += new System.EventHandler(this.btnQuanLyXe_Click);
            // 
            // btnDonDatXe
            // 
            this.btnDonDatXe.BackColor = System.Drawing.Color.Transparent;
            this.btnDonDatXe.FlatAppearance.BorderSize = 0;
            this.btnDonDatXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonDatXe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonDatXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnDonDatXe.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.btnDonDatXe.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnDonDatXe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDonDatXe.IconSize = 32;
            this.btnDonDatXe.Location = new System.Drawing.Point(0, 112);
            this.btnDonDatXe.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnDonDatXe.Name = "btnDonDatXe";
            this.btnDonDatXe.Size = new System.Drawing.Size(200, 46);
            this.btnDonDatXe.TabIndex = 10;
            this.btnDonDatXe.Text = "Đơn Đặt Xe";
            this.btnDonDatXe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonDatXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDonDatXe.UseVisualStyleBackColor = false;
            this.btnDonDatXe.Click += new System.EventHandler(this.btnDonDatXe_Click);
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.btnNguoiDung.FlatAppearance.BorderSize = 0;
            this.btnNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNguoiDung.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnNguoiDung.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnNguoiDung.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnNguoiDung.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNguoiDung.IconSize = 32;
            this.btnNguoiDung.Location = new System.Drawing.Point(0, 168);
            this.btnNguoiDung.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.Size = new System.Drawing.Size(200, 46);
            this.btnNguoiDung.TabIndex = 11;
            this.btnNguoiDung.Text = "Người Dùng";
            this.btnNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNguoiDung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNguoiDung.UseVisualStyleBackColor = false;
            this.btnNguoiDung.Click += new System.EventHandler(this.btnNguoiDung_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnThanhToan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThanhToan.IconSize = 32;
            this.btnThanhToan.Location = new System.Drawing.Point(0, 224);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(200, 46);
            this.btnThanhToan.TabIndex = 14;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.Signal5;
            this.btnThongKe.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.IconSize = 32;
            this.btnThongKe.Location = new System.Drawing.Point(0, 280);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(200, 46);
            this.btnThongKe.TabIndex = 13;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.panelTieuDe.Controls.Add(this.lbXinChaoUsername);
            this.panelTieuDe.Controls.Add(this.lbPhienBan);
            this.panelTieuDe.Controls.Add(this.lbTenPhamMem);
            this.panelTieuDe.Controls.Add(this.ptrLogo);
            this.panelTieuDe.Location = new System.Drawing.Point(1, -9);
            this.panelTieuDe.Margin = new System.Windows.Forms.Padding(0);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(1185, 58);
            this.panelTieuDe.TabIndex = 2;
            // 
            // lbXinChaoUsername
            // 
            this.lbXinChaoUsername.AutoSize = true;
            this.lbXinChaoUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbXinChaoUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXinChaoUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.lbXinChaoUsername.Location = new System.Drawing.Point(903, 18);
            this.lbXinChaoUsername.Name = "lbXinChaoUsername";
            this.lbXinChaoUsername.Size = new System.Drawing.Size(0, 19);
            this.lbXinChaoUsername.TabIndex = 5;
            // 
            // lbPhienBan
            // 
            this.lbPhienBan.AutoSize = true;
            this.lbPhienBan.BackColor = System.Drawing.Color.Transparent;
            this.lbPhienBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhienBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.lbPhienBan.Location = new System.Drawing.Point(62, 35);
            this.lbPhienBan.Name = "lbPhienBan";
            this.lbPhienBan.Size = new System.Drawing.Size(99, 19);
            this.lbPhienBan.TabIndex = 4;
            this.lbPhienBan.Text = "Phiên Bản 1.0";
            // 
            // lbTenPhamMem
            // 
            this.lbTenPhamMem.AutoSize = true;
            this.lbTenPhamMem.BackColor = System.Drawing.Color.Transparent;
            this.lbTenPhamMem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPhamMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.lbTenPhamMem.Location = new System.Drawing.Point(62, 11);
            this.lbTenPhamMem.Name = "lbTenPhamMem";
            this.lbTenPhamMem.Size = new System.Drawing.Size(252, 24);
            this.lbTenPhamMem.TabIndex = 3;
            this.lbTenPhamMem.Text = "Quản Lý Xe - Cho Thuê Xe";
            // 
            // ptrLogo
            // 
            this.ptrLogo.BackgroundImage = global::AppChoThueXe.Properties.Resources.Artboard_1;
            this.ptrLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptrLogo.Location = new System.Drawing.Point(3, 10);
            this.ptrLogo.Name = "ptrLogo";
            this.ptrLogo.Size = new System.Drawing.Size(53, 49);
            this.ptrLogo.TabIndex = 1;
            this.ptrLogo.TabStop = false;
            // 
            // PageChucNangThanhToan
            // 
            this.PageChucNangThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.PageChucNangThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageChucNangThanhToan.Location = new System.Drawing.Point(202, 50);
            this.PageChucNangThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.PageChucNangThanhToan.Name = "PageChucNangThanhToan";
            this.PageChucNangThanhToan.Size = new System.Drawing.Size(985, 510);
            this.PageChucNangThanhToan.TabIndex = 7;
            // 
            // PageChucNangNguoiDung
            // 
            this.PageChucNangNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.PageChucNangNguoiDung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PageChucNangNguoiDung.Location = new System.Drawing.Point(201, 49);
            this.PageChucNangNguoiDung.Name = "PageChucNangNguoiDung";
            this.PageChucNangNguoiDung.Size = new System.Drawing.Size(985, 510);
            this.PageChucNangNguoiDung.TabIndex = 6;
            // 
            // PageChucNangDonDatXe
            // 
            this.PageChucNangDonDatXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.PageChucNangDonDatXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageChucNangDonDatXe.Location = new System.Drawing.Point(201, 49);
            this.PageChucNangDonDatXe.Margin = new System.Windows.Forms.Padding(4);
            this.PageChucNangDonDatXe.Name = "PageChucNangDonDatXe";
            this.PageChucNangDonDatXe.Size = new System.Drawing.Size(985, 510);
            this.PageChucNangDonDatXe.TabIndex = 5;
            // 
            // PageChucNangQuanLyXe
            // 
            this.PageChucNangQuanLyXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.PageChucNangQuanLyXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageChucNangQuanLyXe.Location = new System.Drawing.Point(201, 50);
            this.PageChucNangQuanLyXe.Margin = new System.Windows.Forms.Padding(0);
            this.PageChucNangQuanLyXe.Name = "PageChucNangQuanLyXe";
            this.PageChucNangQuanLyXe.Size = new System.Drawing.Size(985, 510);
            this.PageChucNangQuanLyXe.TabIndex = 4;
            // 
            // PageChucNangTrangChu
            // 
            this.PageChucNangTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.PageChucNangTrangChu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageChucNangTrangChu.Location = new System.Drawing.Point(201, 49);
            this.PageChucNangTrangChu.Margin = new System.Windows.Forms.Padding(0);
            this.PageChucNangTrangChu.Name = "PageChucNangTrangChu";
            this.PageChucNangTrangChu.Size = new System.Drawing.Size(985, 510);
            this.PageChucNangTrangChu.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 554);
            this.Controls.Add(this.PageChucNangThanhToan);
            this.Controls.Add(this.PageChucNangNguoiDung);
            this.Controls.Add(this.PageChucNangDonDatXe);
            this.Controls.Add(this.PageChucNangQuanLyXe);
            this.Controls.Add(this.PageChucNangTrangChu);
            this.Controls.Add(this.panelTieuDe);
            this.Controls.Add(this.SapXepChucNangPanel);
            this.Controls.Add(this.panelControl);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Trang Điều Khiển";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelControl.ResumeLayout(false);
            this.SapXepChucNangPanel.ResumeLayout(false);
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.PictureBox ptrLogo;
        private System.Windows.Forms.FlowLayoutPanel SapXepChucNangPanel;
        private System.Windows.Forms.Panel panelTieuDe;
        private System.Windows.Forms.Label lbPhienBan;
        private System.Windows.Forms.Label lbTenPhamMem;
        private ChucNangTrangChu PageChucNangTrangChu;
        private FontAwesome.Sharp.IconButton btnTrangChu;
        private FontAwesome.Sharp.IconButton btnQuanLyXe;
        private FontAwesome.Sharp.IconButton btnDonDatXe;
        private FontAwesome.Sharp.IconButton btnNguoiDung;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private ChucNangQuanLyXe PageChucNangQuanLyXe;
        private ChucNangDonDatXe PageChucNangDonDatXe;
        private ChucNangNguoiDung PageChucNangNguoiDung;
        private ChucNangThanhToan PageChucNangThanhToan;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private System.Windows.Forms.Label lbXinChaoUsername;
    }
}