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
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms.DataVisualization.Charting;

namespace POS_System
{
    public partial class frmRecords : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string stitle = "Simple POS System";
        public frmRecords()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadRecord()
        {
            int i = 0;
            dataGridView1.Rows.Clear();

            // Determine the query based on the selected sorting option
            string query = "SELECT TOP 10 pcode, pdesc, ISNULL(SUM(qty), 0) AS qty, ISNULL(SUM(total), 0) AS total " +
                           "FROM vwSoldItems " +
                           "WHERE sdate BETWEEN @StartDate AND @EndDate " +
                           "AND status LIKE 'Sold' " +
                           "GROUP BY pcode, pdesc ";

            if (cboTopSelect.Text == "SORT BY QTY")
            {
                query += "ORDER BY qty DESC";
            }
            else if (cboTopSelect.Text == "SORT BY TOTAL AMOUNT")
            {
                query += "ORDER BY total DESC";
            }

            try
            {
                cn.Open();

                // Prepare the command
                using (cm = new SqlCommand(query, cn))
                {
                    cm.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                    cm.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = dateTimePicker2.Value;

                    // Execute the command
                    using (dr = cm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            i++;
                            dataGridView1.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is properly closed
                if (cn.State == ConnectionState.Open) cn.Close();
            }
        }
        public void CancelledOrders()
        {
            int i = 0;
            dataGridView5.Rows.Clear();

            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT * FROM vwCancelledOrder WHERE sdate BETWEEN @StartDate AND @EndDate", cn);
                cm.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = dateTimePicker5.Value;
                cm.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = dateTimePicker6.Value;

                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView5.Rows.Add(i, dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["total"].ToString(), dr["sdate"].ToString(), dr["voidby"].ToString(), dr["cancelledby"].ToString(), dr["reason"].ToString(), dr["action"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cancelled orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr?.Close();
                if (cn.State == ConnectionState.Open) cn.Close();
            }
        }


       
        public void LoadCriticalItems()
        {
            try
            {
                dataGridView3.Rows.Clear();
                int i = 0;
                cn.Open();
                cm = new SqlCommand("select * from vwCriticalItem ", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView3.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadInventory()
        {
            int i = 0;
            dataGridView4.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty, p.reorder from tblProduct as p inner join tblBrand as b on p.bid =b.id inner join tblcategory as c on p.cid = c.id ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView4.Rows.Add(i, dr["pcode"].ToString(), dr["barcode"].ToString(), dr["pdesc"].ToString(), dr["brand"].ToString(), dr["category"].ToString(), dr["price"].ToString(), dr["reorder"].ToString(), dr["qty"].ToString());
            }
            cm.CommandText = "";
            dr.Close();
            cn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInventoryReport frm = new frmInventoryReport();
            frm.LoadReport();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        public void LoadStockInHistory()
        {
            int i = 0;
            dataGridView6.Rows.Clear();
            try
            {
                cn.Open();
                string query = "SELECT * FROM vwStockin WHERE CAST(sdate AS date) BETWEEN @startDate AND @endDate AND status LIKE 'Done'";
                cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@startDate", dateTimePicker8.Value.Date);
                cm.Parameters.AddWithValue("@endDate", dateTimePicker7.Value.Date);

                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView6.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr?.Close();
                cn.Close();
            }
        }

       

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmInventoryReport f = new frmInventoryReport())
            {
                string startDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string endDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                string param = $"From : {startDate} To : {endDate}";
                string query;
                string header = ""; // Initialize header variable

                if (cboTopSelect.Text == "SORT BY QTY")
                {
                    query = $"SELECT TOP 10 pcode, pdesc, SUM(qty) AS qty, SUM(total) AS total " +
                            $"FROM vwSoldItems " +
                            $"WHERE sdate BETWEEN '{startDate}' AND '{endDate}' " +
                            "AND status LIKE 'Sold' " +
                            "GROUP BY pcode, pdesc " +
                            "ORDER BY qty DESC";
                    header = "TOP SELLING ITEMS SORT BY QTY"; // Set header for qty sort
                }
                else if (cboTopSelect.Text == "SORT BY TOTAL AMOUNT")
                {
                    query = $"SELECT TOP 10 pcode, pdesc, SUM(qty) AS qty, SUM(total) AS total " +
                            $"FROM vwSoldItems " +
                            $"WHERE sdate BETWEEN '{startDate}' AND '{endDate}' " +
                            "AND status LIKE 'Sold' " +
                            "GROUP BY pcode, pdesc " +
                            "ORDER BY total DESC";
                    header = "TOP SELLING ITEMS SORT BY TOTAL AMOUNT"; // Set header for total amount sort
                }
                else
                {
                    // Handle case where no sort option is selected
                    MessageBox.Show("Please select a sorting option.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Call LoadTopSelling with the query, parameters, and header
                f.LoadTopSelling(query, param, header);
                f.ShowDialog();
            }
        }
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmInventoryReport f = new frmInventoryReport())
            {
                string startDate = dateTimePicker4.Value.ToString("yyyy-MM-dd");
                string endDate = dateTimePicker3.Value.ToString("yyyy-MM-dd");
                string param = $"From : {startDate} To : {endDate}";

                f.LoadSoldItems($"SELECT c.pcode, p.pdesc, c.price, SUM(c.qty) AS tot_qty, SUM(c.disc) AS tot_disc, SUM(c.total) AS total " +
                                "FROM tblCart AS c " +
                                "INNER JOIN tblProduct AS p ON c.pcode = p.pcode " +
                                $"WHERE c.status LIKE 'Sold' AND c.sdate BETWEEN '{startDate}' AND '{endDate}' " +
                                "GROUP BY c.pcode, p.pdesc, c.price", param);
                f.ShowDialog();
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(cboTopSelect.Text == String.Empty)
            {
                MessageBox.Show("Please select from the dropdown list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            LoadRecord();
            LoadChartTopSelling();
        }
        public void LoadChartTopSelling()
        {
            try
            {
                // Prepare the SQL Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();

                // Get date range from DateTimePicker
                string startDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string endDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                // SQL query declaration
                string query;

                // Determine the query based on the selected sorting option
                if (cboTopSelect.Text == "SORT BY QTY")
                {
                    query = $"SELECT TOP 10 pcode, SUM(qty) AS qty " +
                            $"FROM vwSoldItems " +
                            $"WHERE sdate BETWEEN '{startDate}' AND '{endDate}' " +
                            "AND status LIKE 'Sold' " +
                            "GROUP BY pcode " +
                            "ORDER BY qty DESC";
                }
                else if (cboTopSelect.Text == "SORT BY TOTAL AMOUNT")
                {
                    query = $"SELECT TOP 10 pcode, SUM(total) AS total " +
                            $"FROM vwSoldItems " +
                            $"WHERE sdate BETWEEN '{startDate}' AND '{endDate}' " +
                            "AND status LIKE 'Sold' " +
                            "GROUP BY pcode " +
                            "ORDER BY total DESC";
                }
                else
                {
                    MessageBox.Show("Please select a sorting option.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Open the connection
                cn.Open();

                // Set up the SqlDataAdapter with the query and connection
                da.SelectCommand = new SqlCommand(query, cn);
                DataSet ds = new DataSet();

                // Fill the DataSet
                da.Fill(ds, "TOPSELLING");

                // Bind the DataSet to the chart
                chart1.DataSource = ds.Tables["TOPSELLING"];
                Series series = chart1.Series[0];
                series.ChartType = SeriesChartType.Doughnut;

                // Set series properties
                series.Name = "TOP SELLING";
                chart1.Series[0].XValueMember = "pcode";
                chart1.Series[0]["PieLabelStyle"] = "Outside";
                chart1.Series[0].BorderColor = System.Drawing.Color.Gray;
              

                // Set YValueMember based on sorting option
                if (cboTopSelect.Text == "SORT BY QTY")
                {
                    series.YValueMembers = "qty";
                    series.LabelFormat = "#,##0"; // Format for quantity
                }
                else if (cboTopSelect.Text == "SORT BY TOTAL AMOUNT")
                {
                    series.YValueMembers = "total";
                    series.LabelFormat = "#,##0.00"; // Format for total amount
                }

                series.IsValueShownAsLabel = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading chart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed
                if (cn.State == ConnectionState.Open) cn.Close();
            }
        }

        private void cboTopSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                dataGridView2.Rows.Clear();
                int i = 0;

                // Open the connection
                cn.Open();

                // Parameterized query for the first command
                string query1 = "SELECT c.pcode, p.pdesc, c.price, SUM(c.qty) AS tot_qty, SUM(c.disc) AS tot_disc, SUM(c.total) AS total " +
                                "FROM tblCart AS c " +
                                "INNER JOIN tblProduct AS p ON c.pcode = p.pcode " +
                                "WHERE c.status LIKE 'Sold' AND c.sdate BETWEEN @StartDate AND @EndDate " +
                                "GROUP BY c.pcode, p.pdesc, c.price";

                using (cm = new SqlCommand(query1, cn))
                {
                    cm.Parameters.AddWithValue("@StartDate", dateTimePicker4.Value);
                    cm.Parameters.AddWithValue("@EndDate", dateTimePicker3.Value);

                    using (dr = cm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            i++;
                            dataGridView2.Rows.Add(
                                i,
                                dr["pcode"].ToString(),
                                dr["pdesc"].ToString(),
                                double.Parse(dr["price"].ToString()).ToString("#,##0.00"),
                                dr["tot_qty"].ToString(),
                                dr["tot_disc"].ToString(),
                                double.Parse(dr["total"].ToString()).ToString("#,##0.00")
                            );
                        }
                    }
                }

                // Second SQL command for total calculation
                string query2 = "SELECT ISNULL(SUM(total), 0) FROM tblCart WHERE status LIKE 'Sold' AND sdate BETWEEN @StartDate AND @EndDate";

                using (cm = new SqlCommand(query2, cn))
                {
                    cm.Parameters.AddWithValue("@StartDate", dateTimePicker4.Value);
                    cm.Parameters.AddWithValue("@EndDate", dateTimePicker3.Value);
                    lblTotal.Text = double.Parse(cm.ExecuteScalar().ToString()).ToString("#,##0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                // Ensure the connection is properly closed
                if (cn.State == ConnectionState.Open) cn.Close();
            }
        }



        private void linkLabel9_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChart f = new frmChart();
            f.lblTitle.Text = "SOLD ITEMS [" + dateTimePicker4.Value.ToShortDateString() + " - " + dateTimePicker3.Value.ToShortDateString() + "]";

            string sql = "SELECT p.pdesc, SUM(c.total) AS total " +
                         "FROM tblCart AS c " +
                         "INNER JOIN tblProduct AS p ON c.pcode = p.pcode " +
                         "WHERE c.status LIKE 'Sold' AND c.sdate BETWEEN @StartDate AND @EndDate " +
                         "GROUP BY p.pdesc order by total desc";

            // Call LoadChartSold with the SQL query and date parameters
            f.LoadChartSold(sql, dateTimePicker4.Value, dateTimePicker3.Value);
            f.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmInventoryReport frm = new frmInventoryReport())
            {
                // Construct the parameter string for the report
                string startDate = dateTimePicker8.Value.ToShortDateString();
                string endDate = dateTimePicker7.Value.ToShortDateString();
                string param = $"Date Covered: {startDate} - {endDate}";

                // Define the SQL query with parameters
                string sql = "SELECT * FROM vwStockin WHERE CAST(sdate AS date) BETWEEN @startDate AND @endDate AND status LIKE 'Done'";

                // Create a command to execute the query
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    // Add parameters for the date range
                    cmd.Parameters.AddWithValue("@startDate", dateTimePicker8.Value.Date);
                    cmd.Parameters.AddWithValue("@endDate", dateTimePicker7.Value.Date);

                    // Load the report with the SQL command
                    frm.LoadStockInReport(cmd, param);
                }

                // Show the report form
                frm.ShowDialog();
            }
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadStockInHistory();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CancelledOrders();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmInventoryReport frm = new frmInventoryReport())
            {
                // Construct the parameter string for the report
                string startDate = dateTimePicker5.Value.ToShortDateString();
                string endDate = dateTimePicker6.Value.ToShortDateString();
                string param = $"Date Covered: {startDate} - {endDate}";

                // Define the SQL query with parameters
                string sql = "SELECT * FROM vwCancelledOrder WHERE sdate BETWEEN @StartDate AND @EndDate";

                // Create a command to execute the query
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    // Add parameters for the date range
                    cmd.Parameters.AddWithValue("@startDate", dateTimePicker5.Value.Date);
                    cmd.Parameters.AddWithValue("@endDate", dateTimePicker6.Value.Date);

                    // Load the report with the SQL command
                    frm.LoadCancelOrder(cmd, param);
                }

                // Show the report form
                frm.ShowDialog();
            }
        }
    }
}