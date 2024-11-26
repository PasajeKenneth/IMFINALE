namespace POS_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdjustment = new System.Windows.Forms.Button();
            this.btnVendor = new System.Windows.Forms.Button();
            this.btnSalesHistory = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.btnAdjustment);
            this.panel2.Controls.Add(this.btnVendor);
            this.panel2.Controls.Add(this.btnSalesHistory);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.btnStockIn);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btnBrand);
            this.panel2.Controls.Add(this.btnCategory);
            this.panel2.Controls.Add(this.btnProduct);
            this.panel2.Controls.Add(this.DashboardButton);
            this.panel2.Controls.Add(this.lblRole);
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 608);
            this.panel2.TabIndex = 1;
            // 
            // btnAdjustment
            // 
            this.btnAdjustment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjustment.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjustment.Image")));
            this.btnAdjustment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdjustment.Location = new System.Drawing.Point(1, 293);
            this.btnAdjustment.Name = "btnAdjustment";
            this.btnAdjustment.Size = new System.Drawing.Size(280, 36);
            this.btnAdjustment.TabIndex = 16;
            this.btnAdjustment.Text = "Stock Adjustment";
            this.btnAdjustment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdjustment.UseVisualStyleBackColor = true;
            this.btnAdjustment.Click += new System.EventHandler(this.btnAdjustment_Click);
            // 
            // btnVendor
            // 
            this.btnVendor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendor.Image = ((System.Drawing.Image)(resources.GetObject("btnVendor.Image")));
            this.btnVendor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendor.Location = new System.Drawing.Point(1, 221);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(280, 36);
            this.btnVendor.TabIndex = 15;
            this.btnVendor.Text = "Supplier";
            this.btnVendor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVendor.UseVisualStyleBackColor = true;
            this.btnVendor.Click += new System.EventHandler(this.btnVendor_Click);
            // 
            // btnSalesHistory
            // 
            this.btnSalesHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSalesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesHistory.Image")));
            this.btnSalesHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesHistory.Location = new System.Drawing.Point(1, 437);
            this.btnSalesHistory.Name = "btnSalesHistory";
            this.btnSalesHistory.Size = new System.Drawing.Size(280, 36);
            this.btnSalesHistory.TabIndex = 14;
            this.btnSalesHistory.Text = "Sales History";
            this.btnSalesHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesHistory.UseVisualStyleBackColor = true;
            this.btnSalesHistory.Click += new System.EventHandler(this.btnSalesHistory_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(163, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(117, 23);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "Cashier Name";
            this.lblUser.Visible = false;
            // 
            // btnStockIn
            // 
            this.btnStockIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockIn.Image = ((System.Drawing.Image)(resources.GetObject("btnStockIn.Image")));
            this.btnStockIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockIn.Location = new System.Drawing.Point(1, 257);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(280, 36);
            this.btnStockIn.TabIndex = 12;
            this.btnStockIn.Text = "Stock Entry";
            this.btnStockIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockIn.UseVisualStyleBackColor = true;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 572);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(280, 36);
            this.button9.TabIndex = 11;
            this.button9.Text = "LOGOUT";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(1, 509);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(280, 36);
            this.button7.TabIndex = 10;
            this.button7.Text = "User Settings";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(1, 473);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(280, 36);
            this.button8.TabIndex = 9;
            this.button8.Text = "Store Settings";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(1, 401);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(280, 36);
            this.button5.TabIndex = 8;
            this.button5.Text = "Records";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrand.Image = ((System.Drawing.Image)(resources.GetObject("btnBrand.Image")));
            this.btnBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrand.Location = new System.Drawing.Point(1, 365);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(280, 36);
            this.btnBrand.TabIndex = 7;
            this.btnBrand.Text = "Manage Brand";
            this.btnBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(1, 329);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(280, 36);
            this.btnCategory.TabIndex = 6;
            this.btnCategory.Text = "Manage Category";
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(1, 185);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(280, 36);
            this.btnProduct.TabIndex = 5;
            this.btnProduct.Text = "Manage Product";
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("DashboardButton.Image")));
            this.DashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardButton.Location = new System.Drawing.Point(1, 149);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(280, 36);
            this.DashboardButton.TabIndex = 3;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // lblRole
            // 
            this.lblRole.ForeColor = System.Drawing.Color.Black;
            this.lblRole.Location = new System.Drawing.Point(36, 124);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(222, 29);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Administrator";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblname.Location = new System.Drawing.Point(36, 97);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(222, 31);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Username";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(286, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 607);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 648);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStockIn;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblname;
        public System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnSalesHistory;
        private System.Windows.Forms.Button btnVendor;
        private System.Windows.Forms.Button btnAdjustment;
    }
}

