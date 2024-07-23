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
            this.mnuExit = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRegister = new System.Windows.Forms.GroupBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblFirstInitital = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.mnuExit.SuspendLayout();
            this.grpRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuExit
            // 
            this.mnuExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.mnuExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mnuExit.Location = new System.Drawing.Point(0, 0);
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.mnuExit.Size = new System.Drawing.Size(506, 38);
            this.mnuExit.TabIndex = 31;
            this.mnuExit.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(65, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // grpRegister
            // 
            this.grpRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpRegister.Controls.Add(this.cboCategory);
            this.grpRegister.Controls.Add(this.nudStock);
            this.grpRegister.Controls.Add(this.nudPrice);
            this.grpRegister.Controls.Add(this.lblAddress1);
            this.grpRegister.Controls.Add(this.lblEmail);
            this.grpRegister.Controls.Add(this.lblAccountID);
            this.grpRegister.Controls.Add(this.txtAccountID);
            this.grpRegister.Controls.Add(this.lblPhone);
            this.grpRegister.Controls.Add(this.txtDescription);
            this.grpRegister.Controls.Add(this.lblSurname);
            this.grpRegister.Controls.Add(this.txtModel);
            this.grpRegister.Controls.Add(this.txtBrand);
            this.grpRegister.Controls.Add(this.lblFirstInitital);
            this.grpRegister.Controls.Add(this.lblTitle);
            this.grpRegister.Controls.Add(this.btnCancel);
            this.grpRegister.Controls.Add(this.btnUpdate);
            this.grpRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegister.Location = new System.Drawing.Point(-1, 38);
            this.grpRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRegister.Name = "grpRegister";
            this.grpRegister.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRegister.Size = new System.Drawing.Size(490, 698);
            this.grpRegister.TabIndex = 33;
            this.grpRegister.TabStop = false;
            this.grpRegister.Text = "Update Product";
            // 
            // cboCategory
            // 
            this.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(8, 355);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(276, 44);
            this.cboCategory.TabIndex = 7;
            // 
            // nudStock
            // 
            this.nudStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStock.Location = new System.Drawing.Point(10, 516);
            this.nudStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(143, 38);
            this.nudStock.TabIndex = 11;
            this.nudStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrice.Location = new System.Drawing.Point(10, 446);
            this.nudPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(143, 38);
            this.nudPrice.TabIndex = 9;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblAddress1.Location = new System.Drawing.Point(2, 484);
            this.lblAddress1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(83, 31);
            this.lblAddress1.TabIndex = 10;
            this.lblAddress1.Text = "Stock";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblEmail.Location = new System.Drawing.Point(2, 404);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 31);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Price";
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblAccountID.Location = new System.Drawing.Point(75, 34);
            this.lblAccountID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(143, 31);
            this.lblAccountID.TabIndex = 39;
            this.lblAccountID.Text = "Product ID";
            // 
            // txtAccountID
            // 
            this.txtAccountID.BackColor = System.Drawing.Color.Black;
            this.txtAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountID.ForeColor = System.Drawing.Color.White;
            this.txtAccountID.Location = new System.Drawing.Point(231, 28);
            this.txtAccountID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.ReadOnly = true;
            this.txtAccountID.Size = new System.Drawing.Size(126, 41);
            this.txtAccountID.TabIndex = 38;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblPhone.Location = new System.Drawing.Point(2, 323);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(125, 31);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Category";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(8, 276);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(472, 41);
            this.txtDescription.TabIndex = 5;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblSurname.Location = new System.Drawing.Point(2, 242);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(151, 31);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Description";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(8, 195);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(193, 41);
            this.txtModel.TabIndex = 3;
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(8, 115);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(193, 41);
            this.txtBrand.TabIndex = 1;
            // 
            // lblFirstInitital
            // 
            this.lblFirstInitital.AutoSize = true;
            this.lblFirstInitital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFirstInitital.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblFirstInitital.Location = new System.Drawing.Point(2, 161);
            this.lblFirstInitital.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstInitital.Name = "lblFirstInitital";
            this.lblFirstInitital.Size = new System.Drawing.Size(87, 31);
            this.lblFirstInitital.TabIndex = 2;
            this.lblFirstInitital.Text = "Model";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblTitle.Location = new System.Drawing.Point(2, 81);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(86, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Brand";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(99)))), ((int)(((byte)(95)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(8, 634);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(470, 55);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(8, 571);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(470, 55);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // frmUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(527, 582);
            this.Controls.Add(this.grpRegister);
            this.Controls.Add(this.mnuExit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUpdateProduct";
            this.Text = "Update Product";
            this.mnuExit.ResumeLayout(false);
            this.mnuExit.PerformLayout();
            this.grpRegister.ResumeLayout(false);
            this.grpRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuExit;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpRegister;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblFirstInitital;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.ComboBox cboCategory;
    }
}