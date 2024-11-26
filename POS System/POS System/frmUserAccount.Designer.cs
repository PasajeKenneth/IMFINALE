namespace POS_System
{
    partial class frmUserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRetype = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNew1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOld1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUser1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRetype1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.txtUser2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 40);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(769, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER ACCOUNT";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.tabPage3);
            this.metroTabControl1.Controls.Add(this.tabPage4);
            this.metroTabControl1.Location = new System.Drawing.Point(75, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(644, 348);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(636, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Account";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cboRole);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtRetype);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 306);
            this.panel2.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(479, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 33);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(404, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 33);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(221, 185);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(331, 30);
            this.txtName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name";
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "System Administrator",
            "Cashier"});
            this.cboRole.Location = new System.Drawing.Point(221, 148);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(331, 31);
            this.cboRole.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Role";
            // 
            // txtRetype
            // 
            this.txtRetype.Location = new System.Drawing.Point(221, 112);
            this.txtRetype.Name = "txtRetype";
            this.txtRetype.PasswordChar = '•';
            this.txtRetype.Size = new System.Drawing.Size(331, 30);
            this.txtRetype.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Re-type Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(221, 76);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(331, 30);
            this.txtPass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(221, 40);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(331, 30);
            this.txtUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(636, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change Password";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(636, 306);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Activate / Deactivate Account";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.txtRetype1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtNew1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtOld1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtUser1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 306);
            this.panel3.TabIndex = 0;
            // 
            // txtNew1
            // 
            this.txtNew1.Location = new System.Drawing.Point(215, 105);
            this.txtNew1.Name = "txtNew1";
            this.txtNew1.PasswordChar = '•';
            this.txtNew1.Size = new System.Drawing.Size(331, 30);
            this.txtNew1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "New Password";
            // 
            // txtOld1
            // 
            this.txtOld1.Location = new System.Drawing.Point(215, 69);
            this.txtOld1.Name = "txtOld1";
            this.txtOld1.PasswordChar = '•';
            this.txtOld1.Size = new System.Drawing.Size(331, 30);
            this.txtOld1.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Old Password";
            // 
            // txtUser1
            // 
            this.txtUser1.Enabled = false;
            this.txtUser1.Location = new System.Drawing.Point(215, 33);
            this.txtUser1.Name = "txtUser1";
            this.txtUser1.Size = new System.Drawing.Size(331, 30);
            this.txtUser1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Username";
            // 
            // txtRetype1
            // 
            this.txtRetype1.Location = new System.Drawing.Point(215, 141);
            this.txtRetype1.Name = "txtRetype1";
            this.txtRetype1.PasswordChar = '•';
            this.txtRetype1.Size = new System.Drawing.Size(331, 30);
            this.txtRetype1.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Re-type Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(473, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(398, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.button4);
            this.Panel4.Controls.Add(this.checkBox1);
            this.Panel4.Controls.Add(this.txtUser2);
            this.Panel4.Controls.Add(this.label11);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel4.Location = new System.Drawing.Point(0, 0);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(636, 306);
            this.Panel4.TabIndex = 0;
            // 
            // txtUser2
            // 
            this.txtUser2.Location = new System.Drawing.Point(199, 3);
            this.txtUser2.Name = "txtUser2";
            this.txtUser2.Size = new System.Drawing.Size(331, 30);
            this.txtUser2.TabIndex = 3;
            this.txtUser2.TextChanged += new System.EventHandler(this.txtUser2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Username";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(199, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 27);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Is Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(203, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 33);
            this.button4.TabIndex = 19;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(636, 306);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "*";
            // 
            // frmUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 452);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUserAccount";
            this.Text = "frmUserAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUserAccount_Load);
            this.Resize += new System.EventHandler(this.frmUserAccount_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRetype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRetype1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNew1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOld1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtUser1;
        private System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtUser2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage4;
    }
}