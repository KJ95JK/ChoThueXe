namespace AppChoThueXe
{
    partial class ThongKeSoLuongDonDatXe
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
            this.lbTieuDeThongKeSoLuongDonDatXe = new System.Windows.Forms.Label();
            this.lbThongKeTheo = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbTongSoLuongDonDatXe = new System.Windows.Forms.Label();
            this.txtTongSoLuongDonDatXe = new System.Windows.Forms.TextBox();
            this.txtTongSoLuongDonDatXeDaThanhToan = new System.Windows.Forms.TextBox();
            this.lbTongSoLuongDonDatXeDaThanhToan = new System.Windows.Forms.Label();
            this.txtTongSoLuongDonDatXeChuaThanhToan = new System.Windows.Forms.TextBox();
            this.lbTongSoLuongDonDatXeChuaThanhToan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTieuDeThongKeSoLuongDonDatXe
            // 
            this.lbTieuDeThongKeSoLuongDonDatXe.AutoSize = true;
            this.lbTieuDeThongKeSoLuongDonDatXe.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDeThongKeSoLuongDonDatXe.ForeColor = System.Drawing.Color.Red;
            this.lbTieuDeThongKeSoLuongDonDatXe.Location = new System.Drawing.Point(3, 0);
            this.lbTieuDeThongKeSoLuongDonDatXe.Name = "lbTieuDeThongKeSoLuongDonDatXe";
            this.lbTieuDeThongKeSoLuongDonDatXe.Size = new System.Drawing.Size(420, 37);
            this.lbTieuDeThongKeSoLuongDonDatXe.TabIndex = 7;
            this.lbTieuDeThongKeSoLuongDonDatXe.Text = "Thống Kê Số Lượng Đơn Đặt Xe";
            // 
            // lbThongKeTheo
            // 
            this.lbThongKeTheo.AutoSize = true;
            this.lbThongKeTheo.Location = new System.Drawing.Point(10, 53);
            this.lbThongKeTheo.Name = "lbThongKeTheo";
            this.lbThongKeTheo.Size = new System.Drawing.Size(464, 19);
            this.lbThongKeTheo.TabIndex = 14;
            this.lbThongKeTheo.Text = "Thống Kê Theo Trạng Thái (chưa thanh toán, đã thanh toán, đã hoàn thành)";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 83);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(478, 300);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // lbTongSoLuongDonDatXe
            // 
            this.lbTongSoLuongDonDatXe.AutoSize = true;
            this.lbTongSoLuongDonDatXe.Location = new System.Drawing.Point(523, 53);
            this.lbTongSoLuongDonDatXe.Name = "lbTongSoLuongDonDatXe";
            this.lbTongSoLuongDonDatXe.Size = new System.Drawing.Size(183, 19);
            this.lbTongSoLuongDonDatXe.TabIndex = 16;
            this.lbTongSoLuongDonDatXe.Text = "Tổng Số Lượng Đơn Đặt Xe";
            // 
            // txtTongSoLuongDonDatXe
            // 
            this.txtTongSoLuongDonDatXe.Location = new System.Drawing.Point(527, 83);
            this.txtTongSoLuongDonDatXe.Name = "txtTongSoLuongDonDatXe";
            this.txtTongSoLuongDonDatXe.Size = new System.Drawing.Size(179, 26);
            this.txtTongSoLuongDonDatXe.TabIndex = 17;
            // 
            // txtTongSoLuongDonDatXeDaThanhToan
            // 
            this.txtTongSoLuongDonDatXeDaThanhToan.Location = new System.Drawing.Point(527, 161);
            this.txtTongSoLuongDonDatXeDaThanhToan.Name = "txtTongSoLuongDonDatXeDaThanhToan";
            this.txtTongSoLuongDonDatXeDaThanhToan.Size = new System.Drawing.Size(179, 26);
            this.txtTongSoLuongDonDatXeDaThanhToan.TabIndex = 19;
            // 
            // lbTongSoLuongDonDatXeDaThanhToan
            // 
            this.lbTongSoLuongDonDatXeDaThanhToan.AutoSize = true;
            this.lbTongSoLuongDonDatXeDaThanhToan.Location = new System.Drawing.Point(523, 131);
            this.lbTongSoLuongDonDatXeDaThanhToan.Name = "lbTongSoLuongDonDatXeDaThanhToan";
            this.lbTongSoLuongDonDatXeDaThanhToan.Size = new System.Drawing.Size(280, 19);
            this.lbTongSoLuongDonDatXeDaThanhToan.TabIndex = 18;
            this.lbTongSoLuongDonDatXeDaThanhToan.Text = "Tổng Số Lượng Đơn Đặt Xe Đã Thanh Toán";
            // 
            // txtTongSoLuongDonDatXeChuaThanhToan
            // 
            this.txtTongSoLuongDonDatXeChuaThanhToan.Location = new System.Drawing.Point(527, 241);
            this.txtTongSoLuongDonDatXeChuaThanhToan.Name = "txtTongSoLuongDonDatXeChuaThanhToan";
            this.txtTongSoLuongDonDatXeChuaThanhToan.Size = new System.Drawing.Size(179, 26);
            this.txtTongSoLuongDonDatXeChuaThanhToan.TabIndex = 21;
            // 
            // lbTongSoLuongDonDatXeChuaThanhToan
            // 
            this.lbTongSoLuongDonDatXeChuaThanhToan.AutoSize = true;
            this.lbTongSoLuongDonDatXeChuaThanhToan.Location = new System.Drawing.Point(523, 211);
            this.lbTongSoLuongDonDatXeChuaThanhToan.Name = "lbTongSoLuongDonDatXeChuaThanhToan";
            this.lbTongSoLuongDonDatXeChuaThanhToan.Size = new System.Drawing.Size(296, 19);
            this.lbTongSoLuongDonDatXeChuaThanhToan.TabIndex = 20;
            this.lbTongSoLuongDonDatXeChuaThanhToan.Text = "Tổng Số Lượng Đơn Đặt Xe Chưa Thanh Toán";
            // 
            // ThongKeSoLuongDonDatXe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtTongSoLuongDonDatXeChuaThanhToan);
            this.Controls.Add(this.lbTongSoLuongDonDatXeChuaThanhToan);
            this.Controls.Add(this.txtTongSoLuongDonDatXeDaThanhToan);
            this.Controls.Add(this.lbTongSoLuongDonDatXeDaThanhToan);
            this.Controls.Add(this.txtTongSoLuongDonDatXe);
            this.Controls.Add(this.lbTongSoLuongDonDatXe);
            this.Controls.Add(this.lbThongKeTheo);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lbTieuDeThongKeSoLuongDonDatXe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ThongKeSoLuongDonDatXe";
            this.Size = new System.Drawing.Size(982, 480);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDeThongKeSoLuongDonDatXe;
        private System.Windows.Forms.Label lbThongKeTheo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbTongSoLuongDonDatXe;
        private System.Windows.Forms.TextBox txtTongSoLuongDonDatXe;
        private System.Windows.Forms.TextBox txtTongSoLuongDonDatXeDaThanhToan;
        private System.Windows.Forms.Label lbTongSoLuongDonDatXeDaThanhToan;
        private System.Windows.Forms.TextBox txtTongSoLuongDonDatXeChuaThanhToan;
        private System.Windows.Forms.Label lbTongSoLuongDonDatXeChuaThanhToan;
    }
}
