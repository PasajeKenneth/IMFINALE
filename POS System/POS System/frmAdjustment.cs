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
using System.Windows.Controls;
namespace POS_System
{
    public partial class frmAdjustment : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        Form1 f;
        int _qty = 0;
        public frmAdjustment(Form1 f)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.f = f;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void RefrenceNo()
        {
            Random rnd = new Random();
            txtRef.Text = rnd.Next().ToString();
        }

        public void LoadRecords()
        {
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty FROM tblProduct AS p INNER JOIN tblBrand AS b ON b.id = p.bid INNER JOIN tblCategory AS c ON c.id = p.cid WHERE p.pdesc LIKE @search", cn);
            cm.Parameters.AddWithValue("@search", txtSearch.Text + "%");
            dr = cm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                LoadRecords();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                txtPcode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDesc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + " " + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + " " + dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                _qty = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int adjustmentQty = int.Parse(txtQty.Text);

                // Validate quantity
                if (adjustmentQty > _qty)
                {
                    MessageBox.Show("STOCK QUANTITY SHOULD BE GREATER THAN ADJUSTMENT QUANTITY", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Determine the stock update based on the command
                string updateCommand = cboCommand.Text == "REMOVE FROM INVENTORY"
                    ? "UPDATE tblProduct SET qty = qty - @qty WHERE pcode = @pcode"
                    : "UPDATE tblProduct SET qty = qty + @qty WHERE pcode = @pcode";

                // Update stock
                using (SqlConnection cn = new SqlConnection(dbcon.MyConnection()))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand(updateCommand, cn))
                    {
                        cm.Parameters.AddWithValue("@qty", adjustmentQty);
                        cm.Parameters.AddWithValue("@pcode", txtPcode.Text);
                        cm.ExecuteNonQuery();
                    }

                    // Insert adjustment record
                    using (SqlCommand cm = new SqlCommand("INSERT INTO tblAdjustment(referenceno, pcode, qty, action, remarks, sdate, [user]) VALUES (@referenceno, @pcode, @qty, @action, @remarks, @sdate, @user)", cn))
                    {
                        cm.Parameters.AddWithValue("@referenceno", txtRef.Text);
                        cm.Parameters.AddWithValue("@pcode", txtPcode.Text);
                        cm.Parameters.AddWithValue("@qty", adjustmentQty);
                        cm.Parameters.AddWithValue("@action", cboCommand.Text);
                        cm.Parameters.AddWithValue("@remarks", txtRemarks.Text);
                        cm.Parameters.AddWithValue("@sdate", DateTime.Now); // Direct DateTime usage
                        cm.Parameters.AddWithValue("@user", txtUser.Text);
                        cm.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("STOCK HAS BEEN ADJUSTED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecords();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Clear()
        {
            txtDesc.Clear();
            txtPcode.Clear();
            txtQty.Clear();
            txtRef.Clear();
            txtRemarks.Clear();
            cboCommand.Text = "";
            RefrenceNo();
        }
    }
}
