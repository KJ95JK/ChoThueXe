namespace AppChoThueXe
{
    partial class ChucNangQuanLyXe
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
            this.components = new System.ComponentModel.Container();
            this.lstvQuanLyXe = new System.Windows.Forms.ListView();
            this.lstIDXe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTenXe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstHangXe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstMauXe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstNamSX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstSoChoNgoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstGiaThue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTrangThaiXe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTieuDeQuanLyXe = new System.Windows.Forms.Label();
            this.grbThongTinXe = new System.Windows.Forms.GroupBox();
            this.btnThemHangXe = new FontAwesome.Sharp.IconButton();
            this.btnDatLaiMacDinh = new FontAwesome.Sharp.IconButton();
            this.flowPanelThongTinXe = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTenXe = new System.Windows.Forms.Label();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.lbHangXe = new System.Windows.Forms.Label();
            this.cbbHangXe = new System.Windows.Forms.ComboBox();
            this.lbMauXe = new System.Windows.Forms.Label();
            this.txtMauXe = new System.Windows.Forms.TextBox();
            this.lbNamSanXuat = new System.Windows.Forms.Label();
            this.cbbNamSanXuat = new System.Windows.Forms.ComboBox();
            this.lbSoChoNgoi = new System.Windows.Forms.Label();
            this.txtSoChoNgoi = new System.Windows.Forms.TextBox();
            this.lbGiaThueTheoNgay = new System.Windows.Forms.Label();
            this.txtGiaThueTheoNgay = new System.Windows.Forms.TextBox();
            this.lbTrangThaiXe = new System.Windows.Forms.Label();
            this.cbbTrangThaiXe = new System.Windows.Forms.ComboBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.grbNutChucNang = new System.Windows.Forms.GroupBox();
            this.btnSuaXe = new FontAwesome.Sharp.IconButton();
            this.btnXoaXe = new FontAwesome.Sharp.IconButton();
            this.btnThemXe = new FontAwesome.Sharp.IconButton();
            this.KiemLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbThongTinXe.SuspendLayout();
            this.flowPanelThongTinXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).BeginInit();
            this.grbNutChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KiemLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvQuanLyXe
            // 
            this.lstvQuanLyXe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstIDXe,
            this.lstTenXe,
            this.lstHangXe,
            this.lstMauXe,
            this.lstNamSX,
            this.lstSoChoNgoi,
            this.lstGiaThue,
            this.lstSoLuong,
            this.lstTrangThaiXe});
            this.lstvQuanLyXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvQuanLyXe.FullRowSelect = true;
            this.lstvQuanLyXe.GridLines = true;
            this.lstvQuanLyXe.HideSelection = false;
            this.lstvQuanLyXe.Location = new System.Drawing.Point(392, 16);
            this.lstvQuanLyXe.Name = "lstvQuanLyXe";
            this.lstvQuanLyXe.Size = new System.Drawing.Size(573, 481);
            this.lstvQuanLyXe.TabIndex = 0;
            this.lstvQuanLyXe.UseCompatibleStateImageBehavior = false;
            this.lstvQuanLyXe.View = System.Windows.Forms.View.Details;
            this.lstvQuanLyXe.SelectedIndexChanged += new System.EventHandler(this.lstvQuanLyXe_SelectedIndexChanged);
            // 
            // lstIDXe
            // 
            this.lstIDXe.Text = "ID_Xe";
            this.lstIDXe.Width = 58;
            // 
            // lstTenXe
            // 
            this.lstTenXe.Text = "Tên Xe";
            this.lstTenXe.Width = 58;
            // 
            // lstHangXe
            // 
            this.lstHangXe.Text = "Hãng Xe";
            this.lstHangXe.Width = 70;
            // 
            // lstMauXe
            // 
            this.lstMauXe.Text = "Mẫu Xe";
            this.lstMauXe.Width = 70;
            // 
            // lstNamSX
            // 
            this.lstNamSX.Text = "Năm SX";
            this.lstNamSX.Width = 70;
            // 
            // lstSoChoNgoi
            // 
            this.lstSoChoNgoi.Text = "Số Chỗ";
            this.lstSoChoNgoi.Width = 70;
            // 
            // lstGiaThue
            // 
            this.lstGiaThue.Text = "Giá Thuê";
            this.lstGiaThue.Width = 70;
            // 
            // lstSoLuong
            // 
            this.lstSoLuong.Text = "Số Lượng";
            this.lstSoLuong.Width = 100;
            // 
            // lstTrangThaiXe
            // 
            this.lstTrangThaiXe.Text = "Trạng Thái";
            this.lstTrangThaiXe.Width = 80;
            // 
            // lbTieuDeQuanLyXe
            // 
            this.lbTieuDeQuanLyXe.AutoSize = true;
            this.lbTieuDeQuanLyXe.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDeQuanLyXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(196)))), ((int)(((byte)(190)))));
            this.lbTieuDeQuanLyXe.Location = new System.Drawing.Point(110, 16);
            this.lbTieuDeQuanLyXe.Name = "lbTieuDeQuanLyXe";
            this.lbTieuDeQuanLyXe.Size = new System.Drawing.Size(195, 45);
            this.lbTieuDeQuanLyXe.TabIndex = 2;
            this.lbTieuDeQuanLyXe.Text = "Quản Lý Xe";
            // 
            // grbThongTinXe
            // 
            this.grbThongTinXe.Controls.Add(this.btnThemHangXe);
            this.grbThongTinXe.Controls.Add(this.btnDatLaiMacDinh);
            this.grbThongTinXe.Controls.Add(this.flowPanelThongTinXe);
            this.grbThongTinXe.Location = new System.Drawing.Point(12, 64);
            this.grbThongTinXe.Name = "grbThongTinXe";
            this.grbThongTinXe.Size = new System.Drawing.Size(374, 352);
            this.grbThongTinXe.TabIndex = 3;
            this.grbThongTinXe.TabStop = false;
            this.grbThongTinXe.Text = "Thông Tin Xe";
            // 
            // btnThemHangXe
            // 
            this.btnThemHangXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.btnThemHangXe.FlatAppearance.BorderSize = 0;
            this.btnThemHangXe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemHangXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnThemHangXe.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.btnThemHangXe.IconColor = System.Drawing.Color.White;
            this.btnThemHangXe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemHangXe.IconSize = 24;
            this.btnThemHangXe.Location = new System.Drawing.Point(11, 306);
            this.btnThemHangXe.Name = "btnThemHangXe";
            this.btnThemHangXe.Size = new System.Drawing.Size(163, 40);
            this.btnThemHangXe.TabIndex = 4;
            this.btnThemHangXe.Text = "Thêm Hãng Xe";
            this.btnThemHangXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemHangXe.UseVisualStyleBackColor = false;
            this.btnThemHangXe.Click += new System.EventHandler(this.btnThemHangXe_Click);
            // 
            // btnDatLaiMacDinh
            // 
            this.btnDatLaiMacDinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.btnDatLaiMacDinh.FlatAppearance.BorderSize = 0;
            this.btnDatLaiMacDinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatLaiMacDinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnDatLaiMacDinh.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDatLaiMacDinh.IconColor = System.Drawing.Color.White;
            this.btnDatLaiMacDinh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDatLaiMacDinh.IconSize = 24;
            this.btnDatLaiMacDinh.Location = new System.Drawing.Point(184, 306);
            this.btnDatLaiMacDinh.Name = "btnDatLaiMacDinh";
            this.btnDatLaiMacDinh.Size = new System.Drawing.Size(178, 40);
            this.btnDatLaiMacDinh.TabIndex = 3;
            this.btnDatLaiMacDinh.Text = "Đặt Lại Mặc Định";
            this.btnDatLaiMacDinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatLaiMacDinh.UseVisualStyleBackColor = false;
            this.btnDatLaiMacDinh.Click += new System.EventHandler(this.btnDatLaiMacDinh_Click);
            // 
            // flowPanelThongTinXe
            // 
            this.flowPanelThongTinXe.Controls.Add(this.lbTenXe);
            this.flowPanelThongTinXe.Controls.Add(this.txtTenXe);
            this.flowPanelThongTinXe.Controls.Add(this.lbHangXe);
            this.flowPanelThongTinXe.Controls.Add(this.cbbHangXe);
            this.flowPanelThongTinXe.Controls.Add(this.lbMauXe);
            this.flowPanelThongTinXe.Controls.Add(this.txtMauXe);
            this.flowPanelThongTinXe.Controls.Add(this.lbNamSanXuat);
            this.flowPanelThongTinXe.Controls.Add(this.cbbNamSanXuat);
            this.flowPanelThongTinXe.Controls.Add(this.lbSoChoNgoi);
            this.flowPanelThongTinXe.Controls.Add(this.txtSoChoNgoi);
            this.flowPanelThongTinXe.Controls.Add(this.lbGiaThueTheoNgay);
            this.flowPanelThongTinXe.Controls.Add(this.txtGiaThueTheoNgay);
            this.flowPanelThongTinXe.Controls.Add(this.lbTrangThaiXe);
            this.flowPanelThongTinXe.Controls.Add(this.cbbTrangThaiXe);
            this.flowPanelThongTinXe.Controls.Add(this.lbSoLuong);
            this.flowPanelThongTinXe.Controls.Add(this.numericUpDownSoLuong);
            this.flowPanelThongTinXe.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelThongTinXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowPanelThongTinXe.Location = new System.Drawing.Point(6, 18);
            this.flowPanelThongTinXe.Name = "flowPanelThongTinXe";
            this.flowPanelThongTinXe.Size = new System.Drawing.Size(356, 268);
            this.flowPanelThongTinXe.TabIndex = 0;
            // 
            // lbTenXe
            // 
            this.lbTenXe.AutoSize = true;
            this.lbTenXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenXe.Location = new System.Drawing.Point(5, 5);
            this.lbTenXe.Margin = new System.Windows.Forms.Padding(5);
            this.lbTenXe.Name = "lbTenXe";
            this.lbTenXe.Size = new System.Drawing.Size(54, 19);
            this.lbTenXe.TabIndex = 15;
            this.lbTenXe.Text = "Tên Xe";
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(5, 34);
            this.txtTenXe.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(163, 26);
            this.txtTenXe.TabIndex = 16;
            // 
            // lbHangXe
            // 
            this.lbHangXe.AutoSize = true;
            this.lbHangXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHangXe.Location = new System.Drawing.Point(5, 70);
            this.lbHangXe.Margin = new System.Windows.Forms.Padding(5);
            this.lbHangXe.Name = "lbHangXe";
            this.lbHangXe.Size = new System.Drawing.Size(63, 19);
            this.lbHangXe.TabIndex = 12;
            this.lbHangXe.Text = "Hãng Xe";
            // 
            // cbbHangXe
            // 
            this.cbbHangXe.FormattingEnabled = true;
            this.cbbHangXe.Location = new System.Drawing.Point(5, 99);
            this.cbbHangXe.Margin = new System.Windows.Forms.Padding(5);
            this.cbbHangXe.Name = "cbbHangXe";
            this.cbbHangXe.Size = new System.Drawing.Size(163, 27);
            this.cbbHangXe.TabIndex = 14;
            this.cbbHangXe.SelectedIndexChanged += new System.EventHandler(this.cbbHangXe_SelectedIndexChanged);
            // 
            // lbMauXe
            // 
            this.lbMauXe.AutoSize = true;
            this.lbMauXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMauXe.Location = new System.Drawing.Point(5, 136);
            this.lbMauXe.Margin = new System.Windows.Forms.Padding(5);
            this.lbMauXe.Name = "lbMauXe";
            this.lbMauXe.Size = new System.Drawing.Size(59, 19);
            this.lbMauXe.TabIndex = 11;
            this.lbMauXe.Text = "Mẫu Xe";
            // 
            // txtMauXe
            // 
            this.txtMauXe.Location = new System.Drawing.Point(5, 165);
            this.txtMauXe.Margin = new System.Windows.Forms.Padding(5);
            this.txtMauXe.Name = "txtMauXe";
            this.txtMauXe.Size = new System.Drawing.Size(163, 26);
            this.txtMauXe.TabIndex = 13;
            // 
            // lbNamSanXuat
            // 
            this.lbNamSanXuat.AutoSize = true;
            this.lbNamSanXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamSanXuat.Location = new System.Drawing.Point(5, 201);
            this.lbNamSanXuat.Margin = new System.Windows.Forms.Padding(5);
            this.lbNamSanXuat.Name = "lbNamSanXuat";
            this.lbNamSanXuat.Size = new System.Drawing.Size(99, 19);
            this.lbNamSanXuat.TabIndex = 19;
            this.lbNamSanXuat.Text = "Năm Sản Xuất";
            // 
            // cbbNamSanXuat
            // 
            this.cbbNamSanXuat.FormattingEnabled = true;
            this.cbbNamSanXuat.Location = new System.Drawing.Point(5, 230);
            this.cbbNamSanXuat.Margin = new System.Windows.Forms.Padding(5);
            this.cbbNamSanXuat.Name = "cbbNamSanXuat";
            this.cbbNamSanXuat.Size = new System.Drawing.Size(163, 27);
            this.cbbNamSanXuat.TabIndex = 20;
            // 
            // lbSoChoNgoi
            // 
            this.lbSoChoNgoi.AutoSize = true;
            this.lbSoChoNgoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoChoNgoi.Location = new System.Drawing.Point(178, 5);
            this.lbSoChoNgoi.Margin = new System.Windows.Forms.Padding(5);
            this.lbSoChoNgoi.Name = "lbSoChoNgoi";
            this.lbSoChoNgoi.Size = new System.Drawing.Size(90, 19);
            this.lbSoChoNgoi.TabIndex = 21;
            this.lbSoChoNgoi.Text = "Số Chỗ Ngồi";
            // 
            // txtSoChoNgoi
            // 
            this.txtSoChoNgoi.Location = new System.Drawing.Point(178, 34);
            this.txtSoChoNgoi.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoChoNgoi.Name = "txtSoChoNgoi";
            this.txtSoChoNgoi.Size = new System.Drawing.Size(163, 26);
            this.txtSoChoNgoi.TabIndex = 22;
            // 
            // lbGiaThueTheoNgay
            // 
            this.lbGiaThueTheoNgay.AutoSize = true;
            this.lbGiaThueTheoNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaThueTheoNgay.Location = new System.Drawing.Point(178, 70);
            this.lbGiaThueTheoNgay.Margin = new System.Windows.Forms.Padding(5);
            this.lbGiaThueTheoNgay.Name = "lbGiaThueTheoNgay";
            this.lbGiaThueTheoNgay.Size = new System.Drawing.Size(136, 19);
            this.lbGiaThueTheoNgay.TabIndex = 23;
            this.lbGiaThueTheoNgay.Text = "Giá Thuê Theo Ngày";
            // 
            // txtGiaThueTheoNgay
            // 
            this.txtGiaThueTheoNgay.Location = new System.Drawing.Point(178, 99);
            this.txtGiaThueTheoNgay.Margin = new System.Windows.Forms.Padding(5);
            this.txtGiaThueTheoNgay.Name = "txtGiaThueTheoNgay";
            this.txtGiaThueTheoNgay.Size = new System.Drawing.Size(163, 26);
            this.txtGiaThueTheoNgay.TabIndex = 24;
            // 
            // lbTrangThaiXe
            // 
            this.lbTrangThaiXe.AutoSize = true;
            this.lbTrangThaiXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThaiXe.Location = new System.Drawing.Point(178, 135);
            this.lbTrangThaiXe.Margin = new System.Windows.Forms.Padding(5);
            this.lbTrangThaiXe.Name = "lbTrangThaiXe";
            this.lbTrangThaiXe.Size = new System.Drawing.Size(95, 19);
            this.lbTrangThaiXe.TabIndex = 25;
            this.lbTrangThaiXe.Text = "Trạng Thái Xe";
            // 
            // cbbTrangThaiXe
            // 
            this.cbbTrangThaiXe.FormattingEnabled = true;
            this.cbbTrangThaiXe.Location = new System.Drawing.Point(178, 164);
            this.cbbTrangThaiXe.Margin = new System.Windows.Forms.Padding(5);
            this.cbbTrangThaiXe.Name = "cbbTrangThaiXe";
            this.cbbTrangThaiXe.Size = new System.Drawing.Size(163, 27);
            this.cbbTrangThaiXe.TabIndex = 26;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(178, 201);
            this.lbSoLuong.Margin = new System.Windows.Forms.Padding(5);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(70, 19);
            this.lbSoLuong.TabIndex = 27;
            this.lbSoLuong.Text = "Số Lượng";
            // 
            // numericUpDownSoLuong
            // 
            this.numericUpDownSoLuong.Location = new System.Drawing.Point(178, 230);
            this.numericUpDownSoLuong.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            this.numericUpDownSoLuong.Size = new System.Drawing.Size(165, 26);
            this.numericUpDownSoLuong.TabIndex = 28;
            // 
            // grbNutChucNang
            // 
            this.grbNutChucNang.Controls.Add(this.btnSuaXe);
            this.grbNutChucNang.Controls.Add(this.btnXoaXe);
            this.grbNutChucNang.Controls.Add(this.btnThemXe);
            this.grbNutChucNang.Location = new System.Drawing.Point(12, 422);
            this.grbNutChucNang.Name = "grbNutChucNang";
            this.grbNutChucNang.Size = new System.Drawing.Size(374, 75);
            this.grbNutChucNang.TabIndex = 4;
            this.grbNutChucNang.TabStop = false;
            this.grbNutChucNang.Text = "Nút Chức Năng";
            // 
            // btnSuaXe
            // 
            this.btnSuaXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.btnSuaXe.FlatAppearance.BorderSize = 0;
            this.btnSuaXe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnSuaXe.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSuaXe.IconColor = System.Drawing.Color.White;
            this.btnSuaXe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaXe.IconSize = 24;
            this.btnSuaXe.Location = new System.Drawing.Point(257, 25);
            this.btnSuaXe.Name = "btnSuaXe";
            this.btnSuaXe.Size = new System.Drawing.Size(105, 40);
            this.btnSuaXe.TabIndex = 2;
            this.btnSuaXe.Text = "Sửa Xe";
            this.btnSuaXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaXe.UseVisualStyleBackColor = false;
            this.btnSuaXe.Click += new System.EventHandler(this.btnSuaXe_Click);
            // 
            // btnXoaXe
            // 
            this.btnXoaXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.btnXoaXe.FlatAppearance.BorderSize = 0;
            this.btnXoaXe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnXoaXe.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoaXe.IconColor = System.Drawing.Color.White;
            this.btnXoaXe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaXe.IconSize = 24;
            this.btnXoaXe.Location = new System.Drawing.Point(136, 25);
            this.btnXoaXe.Name = "btnXoaXe";
            this.btnXoaXe.Size = new System.Drawing.Size(105, 40);
            this.btnXoaXe.TabIndex = 1;
            this.btnXoaXe.Text = "Xoá Xe";
            this.btnXoaXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaXe.UseVisualStyleBackColor = false;
            this.btnXoaXe.Click += new System.EventHandler(this.btnXoaXe_Click);
            // 
            // btnThemXe
            // 
            this.btnThemXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.btnThemXe.FlatAppearance.BorderSize = 0;
            this.btnThemXe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnThemXe.IconChar = FontAwesome.Sharp.IconChar.CarAlt;
            this.btnThemXe.IconColor = System.Drawing.Color.White;
            this.btnThemXe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemXe.IconSize = 24;
            this.btnThemXe.Location = new System.Drawing.Point(15, 25);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(105, 40);
            this.btnThemXe.TabIndex = 0;
            this.btnThemXe.Text = "Thêm Xe";
            this.btnThemXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemXe.UseVisualStyleBackColor = false;
            this.btnThemXe.Click += new System.EventHandler(this.btnThemXe_Click);
            // 
            // KiemLoi
            // 
            this.KiemLoi.ContainerControl = this;
            // 
            // ChucNangQuanLyXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.grbNutChucNang);
            this.Controls.Add(this.grbThongTinXe);
            this.Controls.Add(this.lbTieuDeQuanLyXe);
            this.Controls.Add(this.lstvQuanLyXe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ChucNangQuanLyXe";
            this.Size = new System.Drawing.Size(985, 510);
            this.Load += new System.EventHandler(this.ChucNangQuanLyXe_Load);
            this.grbThongTinXe.ResumeLayout(false);
            this.flowPanelThongTinXe.ResumeLayout(false);
            this.flowPanelThongTinXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).EndInit();
            this.grbNutChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KiemLoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvQuanLyXe;
        private System.Windows.Forms.Label lbTieuDeQuanLyXe;
        private System.Windows.Forms.GroupBox grbThongTinXe;
        private System.Windows.Forms.FlowLayoutPanel flowPanelThongTinXe;
        private System.Windows.Forms.Label lbTenXe;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.Label lbHangXe;
        private System.Windows.Forms.ComboBox cbbHangXe;
        private System.Windows.Forms.Label lbMauXe;
        private System.Windows.Forms.TextBox txtMauXe;
        private System.Windows.Forms.Label lbNamSanXuat;
        private System.Windows.Forms.ComboBox cbbNamSanXuat;
        private System.Windows.Forms.Label lbSoChoNgoi;
        private System.Windows.Forms.TextBox txtSoChoNgoi;
        private System.Windows.Forms.Label lbGiaThueTheoNgay;
        private System.Windows.Forms.TextBox txtGiaThueTheoNgay;
        private System.Windows.Forms.Label lbTrangThaiXe;
        private System.Windows.Forms.ColumnHeader lstIDXe;
        private System.Windows.Forms.ColumnHeader lstTenXe;
        private System.Windows.Forms.ColumnHeader lstHangXe;
        private System.Windows.Forms.ColumnHeader lstMauXe;
        private System.Windows.Forms.ColumnHeader lstNamSX;
        private System.Windows.Forms.ColumnHeader lstSoChoNgoi;
        private System.Windows.Forms.ColumnHeader lstGiaThue;
        private System.Windows.Forms.ColumnHeader lstTrangThaiXe;
        private System.Windows.Forms.GroupBox grbNutChucNang;
        private FontAwesome.Sharp.IconButton btnSuaXe;
        private FontAwesome.Sharp.IconButton btnXoaXe;
        private FontAwesome.Sharp.IconButton btnThemXe;
        private System.Windows.Forms.ComboBox cbbTrangThaiXe;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.NumericUpDown numericUpDownSoLuong;
        private System.Windows.Forms.ColumnHeader lstSoLuong;
        private FontAwesome.Sharp.IconButton btnDatLaiMacDinh;
        private FontAwesome.Sharp.IconButton btnThemHangXe;
        private System.Windows.Forms.ErrorProvider KiemLoi;
    }
}
