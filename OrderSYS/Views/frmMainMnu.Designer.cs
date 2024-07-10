namespace OrderSYS.Views
{
    partial class frmMainMnu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnManageAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManageProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManageOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerateStatement = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRevenueAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnManageAccounts,
            this.btnManageProducts,
            this.btnManageOrders,
            this.btnLogout,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1867, 65);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnManageAccounts
            // 
            this.btnManageAccounts.Name = "btnManageAccounts";
            this.btnManageAccounts.Size = new System.Drawing.Size(380, 61);
            this.btnManageAccounts.Text = "Manage Accounts";
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(374, 61);
            this.btnManageProducts.Text = "Manage Products";
            // 
            // btnManageOrders
            // 
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Size = new System.Drawing.Size(337, 61);
            this.btnManageOrders.Text = "Manage Orders";
            // 
            // btnLogout
            // 
            this.btnLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 61);
            this.btnLogout.Text = "Logout";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGenerateStatement,
            this.btnRevenueAnalysis});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(169, 61);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // btnGenerateStatement
            // 
            this.btnGenerateStatement.Name = "btnGenerateStatement";
            this.btnGenerateStatement.Size = new System.Drawing.Size(552, 66);
            this.btnGenerateStatement.Text = "Generate Statement";
            // 
            // btnRevenueAnalysis
            // 
            this.btnRevenueAnalysis.Name = "btnRevenueAnalysis";
            this.btnRevenueAnalysis.Size = new System.Drawing.Size(552, 66);
            this.btnRevenueAnalysis.Text = "Revenue Analysis";
            // 
            // frmMainMnu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1004);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmMainMnu";
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnManageAccounts;
        private System.Windows.Forms.ToolStripMenuItem btnManageProducts;
        private System.Windows.Forms.ToolStripMenuItem btnManageOrders;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnGenerateStatement;
        private System.Windows.Forms.ToolStripMenuItem btnRevenueAnalysis;
    }
}