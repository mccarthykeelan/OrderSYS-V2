namespace OrderSYS.Views
{
    partial class frmUpdateProduct
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRegister = new System.Windows.Forms.GroupBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblFirstInitital = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.grpRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 65);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 61);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // grpRegister
            // 
            this.grpRegister.Controls.Add(this.nudStock);
            this.grpRegister.Controls.Add(this.nudPrice);
            this.grpRegister.Controls.Add(this.lblAddress1);
            this.grpRegister.Controls.Add(this.lblEmail);
            this.grpRegister.Controls.Add(this.lblAccountID);
            this.grpRegister.Controls.Add(this.txtAccountID);
            this.grpRegister.Controls.Add(this.txtCategory);
            this.grpRegister.Controls.Add(this.lblPhone);
            this.grpRegister.Controls.Add(this.txtDescription);
            this.grpRegister.Controls.Add(this.lblSurname);
            this.grpRegister.Controls.Add(this.txtModel);
            this.grpRegister.Controls.Add(this.txtBrand);
            this.grpRegister.Controls.Add(this.lblFirstInitital);
            this.grpRegister.Controls.Add(this.lblTitle);
            this.grpRegister.Controls.Add(this.btnCancel);
            this.grpRegister.Controls.Add(this.btnConfirm);
            this.grpRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegister.Location = new System.Drawing.Point(16, 68);
            this.grpRegister.Name = "grpRegister";
            this.grpRegister.Size = new System.Drawing.Size(857, 1266);
            this.grpRegister.TabIndex = 33;
            this.grpRegister.TabStop = false;
            this.grpRegister.Text = "Update Product";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrice.Location = new System.Drawing.Point(17, 809);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(251, 62);
            this.nudPrice.TabIndex = 44;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblAddress1.Location = new System.Drawing.Point(4, 877);
            this.lblAddress1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(144, 55);
            this.lblAddress1.TabIndex = 42;
            this.lblAddress1.Text = "Stock";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblEmail.Location = new System.Drawing.Point(4, 733);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(133, 55);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "Price";
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblAccountID.Location = new System.Drawing.Point(132, 61);
            this.lblAccountID.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(251, 55);
            this.lblAccountID.TabIndex = 39;
            this.lblAccountID.Text = "Product ID";
            // 
            // txtAccountID
            // 
            this.txtAccountID.BackColor = System.Drawing.Color.Black;
            this.txtAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountID.ForeColor = System.Drawing.Color.White;
            this.txtAccountID.Location = new System.Drawing.Point(405, 51);
            this.txtAccountID.Margin = new System.Windows.Forms.Padding(7);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.ReadOnly = true;
            this.txtAccountID.Size = new System.Drawing.Size(217, 69);
            this.txtAccountID.TabIndex = 38;
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(14, 648);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(7);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(482, 69);
            this.txtCategory.TabIndex = 37;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblPhone.Location = new System.Drawing.Point(4, 586);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(220, 55);
            this.lblPhone.TabIndex = 36;
            this.lblPhone.Text = "Category";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(14, 501);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(7);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(823, 69);
            this.txtDescription.TabIndex = 35;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblSurname.Location = new System.Drawing.Point(4, 439);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(264, 55);
            this.lblSurname.TabIndex = 34;
            this.lblSurname.Text = "Description";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(14, 354);
            this.txtModel.Margin = new System.Windows.Forms.Padding(7);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(244, 69);
            this.txtModel.TabIndex = 33;
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(14, 208);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(7);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(210, 69);
            this.txtBrand.TabIndex = 32;
            // 
            // lblFirstInitital
            // 
            this.lblFirstInitital.AutoSize = true;
            this.lblFirstInitital.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblFirstInitital.Location = new System.Drawing.Point(4, 292);
            this.lblFirstInitital.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblFirstInitital.Name = "lblFirstInitital";
            this.lblFirstInitital.Size = new System.Drawing.Size(155, 55);
            this.lblFirstInitital.TabIndex = 31;
            this.lblFirstInitital.Text = "Model";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblTitle.Location = new System.Drawing.Point(4, 146);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 55);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "Brand";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(99)))), ((int)(((byte)(95)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(14, 1149);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(823, 100);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(14, 1035);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(7);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(823, 100);
            this.btnConfirm.TabIndex = 28;
            this.btnConfirm.Text = "Update";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // nudStock
            // 
            this.nudStock.DecimalPlaces = 2;
            this.nudStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStock.Location = new System.Drawing.Point(17, 935);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(251, 62);
            this.nudStock.TabIndex = 45;
            this.nudStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(923, 1098);
            this.Controls.Add(this.grpRegister);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmUpdateProduct";
            this.Text = "Update Product";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpRegister.ResumeLayout(false);
            this.grpRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpRegister;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblFirstInitital;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.NumericUpDown nudStock;
    }
}