namespace OrderSYS.Views
{
    partial class frmManageProducts
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.btnDiscontinue = new System.Windows.Forms.Button();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip2";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 61);
            this.btnExit.Text = "Exit";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(149)))), ((int)(((byte)(241)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1511, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(344, 124);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(1511, 166);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(344, 124);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1274, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(231, 62);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 81);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1256, 62);
            this.txtSearch.TabIndex = 15;
            // 
            // grdProducts
            // 
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Location = new System.Drawing.Point(12, 166);
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.RowHeadersWidth = 92;
            this.grdProducts.RowTemplate.Height = 37;
            this.grdProducts.Size = new System.Drawing.Size(1493, 821);
            this.grdProducts.TabIndex = 14;
            // 
            // btnDiscontinue
            // 
            this.btnDiscontinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(99)))), ((int)(((byte)(95)))));
            this.btnDiscontinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscontinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscontinue.ForeColor = System.Drawing.Color.White;
            this.btnDiscontinue.Location = new System.Drawing.Point(1511, 449);
            this.btnDiscontinue.Name = "btnDiscontinue";
            this.btnDiscontinue.Size = new System.Drawing.Size(344, 124);
            this.btnDiscontinue.TabIndex = 19;
            this.btnDiscontinue.Text = "Discontinue";
            this.btnDiscontinue.UseVisualStyleBackColor = false;
            // 
            // frmManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1007);
            this.Controls.Add(this.btnDiscontinue);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grdProducts);
            this.Controls.Add(this.mnuMain);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmManageProducts";
            this.Text = "Manage Products";
            this.Load += new System.EventHandler(this.frmManageProducts_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView grdProducts;
        private System.Windows.Forms.Button btnDiscontinue;
    }
}