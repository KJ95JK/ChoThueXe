namespace AppChoThueXe
{
    partial class ThongKeDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbTieuDeThongKeDoanhThu = new System.Windows.Forms.Label();
            this.lbKieuThongKe = new System.Windows.Forms.Label();
            this.cbbKieuThongKe = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnChon = new System.Windows.Forms.Button();
            this.lbThongKeTheo = new System.Windows.Forms.Label();
            this.NgayThangNam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTieuDeThongKeDoanhThu
            // 
            this.lbTieuDeThongKeDoanhThu.AutoSize = true;
            this.lbTieuDeThongKeDoanhThu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDeThongKeDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lbTieuDeThongKeDoanhThu.Location = new System.Drawing.Point(3, 0);
            this.lbTieuDeThongKeDoanhThu.Name = "lbTieuDeThongKeDoanhThu";
            this.lbTieuDeThongKeDoanhThu.Size = new System.Drawing.Size(285, 37);
            this.lbTieuDeThongKeDoanhThu.TabIndex = 6;
            this.lbTieuDeThongKeDoanhThu.Text = "Thống Kê Doanh Thu";
            // 
            // lbKieuThongKe
            // 
            this.lbKieuThongKe.AutoSize = true;
            this.lbKieuThongKe.Location = new System.Drawing.Point(6, 57);
            this.lbKieuThongKe.Name = "lbKieuThongKe";
            this.lbKieuThongKe.Size = new System.Drawing.Size(202, 19);
            this.lbKieuThongKe.TabIndex = 7;
            this.lbKieuThongKe.Text = "Vui Lòng Chọn Kiểu Thống Kê:";
            // 
            // cbbKieuThongKe
            // 
            this.cbbKieuThongKe.FormattingEnabled = true;
            this.cbbKieuThongKe.Location = new System.Drawing.Point(10, 92);
            this.cbbKieuThongKe.Name = "cbbKieuThongKe";
            this.cbbKieuThongKe.Size = new System.Drawing.Size(198, 27);
            this.cbbKieuThongKe.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(294, 92);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(653, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(10, 134);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(146, 41);
            this.btnChon.TabIndex = 10;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // lbThongKeTheo
            // 
            this.lbThongKeTheo.AutoSize = true;
            this.lbThongKeTheo.Location = new System.Drawing.Point(294, 62);
            this.lbThongKeTheo.Name = "lbThongKeTheo";
            this.lbThongKeTheo.Size = new System.Drawing.Size(108, 19);
            this.lbThongKeTheo.TabIndex = 11;
            this.lbThongKeTheo.Text = "Thống Kê Theo:";
            // 
            // NgayThangNam
            // 
            this.NgayThangNam.AutoSize = true;
            this.NgayThangNam.Location = new System.Drawing.Point(408, 62);
            this.NgayThangNam.Name = "NgayThangNam";
            this.NgayThangNam.Size = new System.Drawing.Size(126, 19);
            this.NgayThangNam.TabIndex = 12;
            this.NgayThangNam.Text = "(Ngày,Tháng,Năm)";
            // 
            // ThongKeDoanhThu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.NgayThangNam);
            this.Controls.Add(this.lbThongKeTheo);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cbbKieuThongKe);
            this.Controls.Add(this.lbKieuThongKe);
            this.Controls.Add(this.lbTieuDeThongKeDoanhThu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ThongKeDoanhThu";
            this.Size = new System.Drawing.Size(982, 480);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDeThongKeDoanhThu;
        private System.Windows.Forms.Label lbKieuThongKe;
        private System.Windows.Forms.ComboBox cbbKieuThongKe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Label lbThongKeTheo;
        private System.Windows.Forms.Label NgayThangNam;
    }
}
