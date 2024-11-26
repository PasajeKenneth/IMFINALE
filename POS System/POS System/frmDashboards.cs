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
using System.Windows.Forms.DataVisualization.Charting;

namespace POS_System
{
    public partial class frmDashboards : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public frmDashboards()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadCart();

        }

     

        public void LoadCart()
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT YEAR(CAST(sdate AS DATE)) AS year, ISNULL(SUM(total), 0.0) AS total FROM tblcart WHERE status LIKE 'Sold' GROUP BY YEAR(CAST(sdate AS DATE))", cn);
            DataSet ds = new DataSet();

            da.Fill(ds, "Sales");
            chart1.DataSource = ds.Tables["Sales"];
            Series series1 = chart1.Series["Series1"];
            series1.ChartType = SeriesChartType.Doughnut;

            series1.Name = "SALES";
            var chart = chart1;
            chart.Series[series1.Name].XValueMember = "year";
            chart.Series[series1.Name].YValueMembers = "total";
            chart.Series[0].IsValueShownAsLabel = true;
            cn.Close();
        }

        private void frmDashboards_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
        }
    }
}
