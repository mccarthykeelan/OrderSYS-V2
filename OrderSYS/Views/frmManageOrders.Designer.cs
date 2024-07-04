namespace OrderSYS.Views
{
    partial class frmManageOrders
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDispatch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1867, 65);
            this.mnuMain.TabIndex = 3;
            this.mnuMain.Text = "menuStrip2";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 61);
            this.btnExit.Text = "Exit";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(99)))), ((int)(((byte)(95)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1512, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(344, 124);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDispatch
            // 
            this.btnDispatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            this.btnDispatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispatch.ForeColor = System.Drawing.Color.White;
            this.btnDispatch.Location = new System.Drawing.Point(1512, 175);
            this.btnDispatch.Name = "btnDispatch";
            this.btnDispatch.Size = new System.Drawing.Size(344, 124);
            this.btnDispatch.TabIndex = 12;
            this.btnDispatch.Text = "Dispatch";
            this.btnDispatch.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1275, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(231, 62);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(13, 90);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1256, 62);
            this.txtSearch.TabIndex = 10;
            // 
            // grdOrders
            // 
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrders.Location = new System.Drawing.Point(13, 175);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.RowHeadersWidth = 92;
            this.grdOrders.RowTemplate.Height = 37;
            this.grdOrders.Size = new System.Drawing.Size(1493, 821);
            this.grdOrders.TabIndex = 9;
            // 
            // frmManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1004);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDispatch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grdOrders);
            this.Controls.Add(this.mnuMain);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmManageOrders";
            this.Text = "Manage Orders";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDispatch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView grdOrders;
    }
}