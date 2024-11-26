using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace POS_System
{
    public partial class frmChart : Form
    {
        SqlConnection cn = new SqlConnection();
        DBConnection dbcon = new DBConnection();
   
        public frmChart()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadChartSold(string sql, DateTime startDate, DateTime endDate)
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    da.SelectCommand = cmd;

                    DataSet ds = new DataSet();
                    da.Fill(ds, "SOLD");
                    chart1.DataSource = ds.Tables["SOLD"];
                    Series series = chart1.Series[0];
                    series.ChartType = SeriesChartType.Doughnut;

                    series.Name = "SOLD ITEMS";
                    chart1.Series[0].XValueMember = "pdesc";
                    chart1.Series[0]["PieLabelStyle"] = "Outside";
                    chart1.Series[0].BorderColor = System.Drawing.Color.Gray;
                    chart1.Series[0].YValueMembers = "total";
                    chart1.Series[0].LabelFormat = "{#,##0.00}";
                    chart1.Series[0].IsValueShownAsLabel = true;
                }
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
    }
}
