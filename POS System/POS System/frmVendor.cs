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

namespace POS_System
{
    public partial class frmVendor : Form
    {
        frmVendorList f;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public frmVendor(frmVendorList f)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.f = f;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmVendor_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Save this record ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("insert into tblVendor (vendor, address, contactperson, telephone, email, fax) VALUES (@vendor, @address, @contactperson, @telephone, @email, @fax)", cn);
                    cm.Parameters.AddWithValue("@vendor", txtVendor.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@contactperson", txtPerson.Text);
                    cm.Parameters.AddWithValue("@telephone", txtTel.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@fax", txtFax.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Vendor Added Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    f.LoadRecords();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Clear()
        {
            txtVendor.Clear();
            txtVendor.Focus();
            txtAddress.Clear();
            txtPerson.Clear();
            txtFax.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (MessageBox.Show("Update this record ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("update tblVendor set vendor = @vendor , address =@address , contactperson = @contactperson, telephone = @telephone, email = @email, fax = @fax where id = @id ", cn);
                        cm.Parameters.AddWithValue("@vendor", txtVendor.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@contactperson", txtPerson.Text);
                        cm.Parameters.AddWithValue("@telephone", txtTel.Text);
                        cm.Parameters.AddWithValue("@email", txtEmail.Text);
                        cm.Parameters.AddWithValue("@fax", txtFax.Text);
                        cm.Parameters.AddWithValue("@id", lblID.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Vendor Updated Successfully ", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        f.LoadRecords();
                        this.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
