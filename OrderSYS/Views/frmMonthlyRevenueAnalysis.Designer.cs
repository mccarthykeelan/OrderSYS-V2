namespace OrderSYS.Views
{
    partial class frmMonthlyRevenueAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpMonthlyRevenueAnalysis = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.crtYearlyRevenueAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpMonthlyRevenueAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtYearlyRevenueAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMonthlyRevenueAnalysis
            // 
            this.grpMonthlyRevenueAnalysis.Controls.Add(this.btnGenerate);
            this.grpMonthlyRevenueAnalysis.Controls.Add(this.cboYear);
            this.grpMonthlyRevenueAnalysis.Controls.Add(this.lblYear);
            this.grpMonthlyRevenueAnalysis.Controls.Add(this.crtYearlyRevenueAnalysis);
            this.grpMonthlyRevenueAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMonthlyRevenueAnalysis.Location = new System.Drawing.Point(12, 12);
            this.grpMonthlyRevenueAnalysis.Name = "grpMonthlyRevenueAnalysis";
            this.grpMonthlyRevenueAnalysis.Size = new System.Drawing.Size(1274, 895);
            this.grpMonthlyRevenueAnalysis.TabIndex = 0;
            this.grpMonthlyRevenueAnalysis.TabStop = false;
            this.grpMonthlyRevenueAnalysis.Text = "Monthly Revenue Analysis";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(28, 765);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(1217, 112);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate Analysis";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(163, 686);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(292, 63);
            this.cboYear.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(18, 694);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(139, 55);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Year:";
            // 
            // crtYearlyRevenueAnalysis
            // 
            chartArea1.Name = "ChartArea1";
            this.crtYearlyRevenueAnalysis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crtYearlyRevenueAnalysis.Legends.Add(legend1);
            this.crtYearlyRevenueAnalysis.Location = new System.Drawing.Point(28, 64);
            this.crtYearlyRevenueAnalysis.Name = "crtYearlyRevenueAnalysis";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.crtYearlyRevenueAnalysis.Series.Add(series1);
            this.crtYearlyRevenueAnalysis.Size = new System.Drawing.Size(1217, 606);
            this.crtYearlyRevenueAnalysis.TabIndex = 0;
            this.crtYearlyRevenueAnalysis.Text = "chart1";
            // 
            // frmMonthlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 919);
            this.Controls.Add(this.grpMonthlyRevenueAnalysis);
            this.Name = "frmMonthlyRevenueAnalysis";
            this.Text = "Yearly Revenue Analysis";
            this.grpMonthlyRevenueAnalysis.ResumeLayout(false);
            this.grpMonthlyRevenueAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtYearlyRevenueAnalysis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMonthlyRevenueAnalysis;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtYearlyRevenueAnalysis;
        private System.Windows.Forms.Button btnGenerate;
    }
}