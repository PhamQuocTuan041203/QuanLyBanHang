namespace GUI
{
    partial class frmStatistic
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
            Guna.Charts.WinForms.ChartFont chartFont9 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont10 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont11 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont12 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid4 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick4 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont13 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid5 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick5 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont14 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid6 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel2 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont15 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick6 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont16 = new Guna.Charts.WinForms.ChartFont();
            this.chtImportProduct = new Guna.Charts.WinForms.GunaChart();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // chtImportProduct
            // 
            this.chtImportProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartFont9.FontName = "Arial";
            this.chtImportProduct.Legend.LabelFont = chartFont9;
            this.chtImportProduct.Location = new System.Drawing.Point(16, 42);
            this.chtImportProduct.Margin = new System.Windows.Forms.Padding(4);
            this.chtImportProduct.Name = "chtImportProduct";
            this.chtImportProduct.Size = new System.Drawing.Size(1216, 657);
            this.chtImportProduct.TabIndex = 0;
            chartFont10.FontName = "Arial";
            chartFont10.Size = 12;
            chartFont10.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.chtImportProduct.Title.Font = chartFont10;
            chartFont11.FontName = "Arial";
            this.chtImportProduct.Tooltips.BodyFont = chartFont11;
            chartFont12.FontName = "Arial";
            chartFont12.Size = 9;
            chartFont12.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.chtImportProduct.Tooltips.TitleFont = chartFont12;
            this.chtImportProduct.XAxes.GridLines = grid4;
            chartFont13.FontName = "Arial";
            tick4.Font = chartFont13;
            this.chtImportProduct.XAxes.Ticks = tick4;
            this.chtImportProduct.YAxes.GridLines = grid5;
            chartFont14.FontName = "Arial";
            tick5.Font = chartFont14;
            this.chtImportProduct.YAxes.Ticks = tick5;
            this.chtImportProduct.ZAxes.GridLines = grid6;
            chartFont15.FontName = "Arial";
            pointLabel2.Font = chartFont15;
            this.chtImportProduct.ZAxes.PointLabels = pointLabel2;
            chartFont16.FontName = "Arial";
            tick6.Font = chartFont16;
            this.chtImportProduct.ZAxes.Ticks = tick6;
            this.chtImportProduct.Load += new System.EventHandler(this.chtImportProduct_Load);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.Animated = true;
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1031, 80);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(171, 50);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 714);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chtImportProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStatistic";
            this.Text = "Thống kê";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.Charts.WinForms.GunaChart chtImportProduct;
        private Guna.UI2.WinForms.Guna2GradientButton btnRefresh;
    }
}