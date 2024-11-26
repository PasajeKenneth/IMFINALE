using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace POS_System
{
    public partial class frmUserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        Form1 f;
        public frmUserAccount(Form1 f)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.f = f;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmUserAccount_Resize(object sender, EventArgs e)
        {
            metroTabControl1.Left =  (this.Width - metroTabControl1.Width) / 2;
            metroTabControl1.Top = (this.Height - metroTabControl1.Height) / 2;

        }

        private void frmUserAccount_Load(object sender, EventArgs e)
        {
          
        }

        private void Clear()
        {
            txtName.Clear();
            txtPass.Clear();
            txtRetype.Clear();
            txtUser.Clear();
            cboRole.Text = "";
            txtUser.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text != txtRetype.Text) 
                {
                    MessageBox.Show("Password did not match!","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                cm = new SqlCommand("insert into tbluser (username,password,role,name)values(@username,@password,@role,@name)",cn);
                cm.Parameters.AddWithValue("@username", txtUser.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                cm.Parameters.AddWithValue("@role", cboRole.Text);
                cm.Parameters.AddWithValue("@name", txtName.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("New account has saved!");
                Clear();
            }
            catch (Exception ex) 
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtOld1.Text != f. _pass)
                {
                    MessageBox.Show("Old password did not match! ","Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txtNew1.Text != txtRetype1.Text)
                {
                    MessageBox.Show("Confirm new password did not match! ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                


                cn.Open();
                cm = new SqlCommand("update tbluser set password = @password where username = @username", cn);
                cm.Parameters.AddWithValue("@password", txtNew1.Text);
                cm.Parameters.AddWithValue("@username", txtUser1.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                
                MessageBox.Show("Password has been successfully changed!  ", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                txtRetype1.Clear();
                txtNew1.Clear();
                txtOld1.Clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtUser2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from tbluser where username = @username", cn);
                cm.Parameters.AddWithValue("@username", txtUser2.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows) 
                {
                    checkBox1.Checked = bool.Parse(dr["isactive"].ToString());
                }
                else
                {
                    checkBox1.Checked = false;
                }
                dr.Close();
                cn.Close ();
            }
            catch(Exception ex) 
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = true;
                cn.Open();
                cm = new SqlCommand("select * from tbluser where username = @username", cn);
                cm.Parameters.AddWithValue("@username", txtUser2.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                }
                else
                {
                    found = false;
                }
                dr.Close();
                cn.Close();

                if (found == true)
                {
                    cn.Open();
                    cm = new SqlCommand("udpate tbluser set isactive = @isactive where username = @username", cn);
                    cm.Parameters.AddWithValue("@isactive", checkBox1.Checked.ToString());
                    cm.Parameters.AddWithValue("@username", txtUser2.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Account status has been successfully updated. ", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser2.Clear();
                    checkBox1.Checked = false;
                }
                else
                {
                    MessageBox.Show("Account not exists! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) 
            {
                cn.Close();
                     MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
