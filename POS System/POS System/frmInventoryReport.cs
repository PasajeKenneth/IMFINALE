using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace POS_System
{
    public partial class frmInventoryReport : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public frmInventoryReport()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmInventoryReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        public void LoadSoldItems(string sql, string param)
        {
            try
            {
                ReportDataSource rptDs;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptSold.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["dtSoldItems"]);
                cn.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);
                

                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pDate });
               
                rptDs = new ReportDataSource("DataSet1", ds.Tables["dtSoldItems"]);
                reportViewer1.LocalReport.DataSources.Add(rptDs);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LoadTopSelling(string sql, string param, string header)
        {
            try
            {
                ReportDataSource rptDs;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptTop.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["dtTopSelling"]);
                cn.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);
                ReportParameter pHeader = new ReportParameter("pHeader", header);
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pDate });
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pHeader });
                rptDs = new ReportDataSource("DataSet1", ds.Tables["dtTopSelling"]);
                reportViewer1.LocalReport.DataSources.Add(rptDs);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadReport()
        {
            ReportDataSource rptDs;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report3.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand("select p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty, p.reorder from tblProduct as p inner join tblBrand as b on p.bid =b.id inner join tblcategory as c on p.cid = c.id ", cn);
                da.Fill(ds.Tables["dtInventory"]);
                cn.Close();

                rptDs = new ReportDataSource("DataSet1", ds.Tables["dtInventory"]);

                reportViewer1.LocalReport.DataSources.Add(rptDs);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex) 
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadStockInReport(SqlCommand cmd, string param)
        {
            ReportDataSource rptDs;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptStockIn.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter(cmd); // Use the SqlCommand directly

                cn.Open();
                da.Fill(ds.Tables["dtStockIn"]);
                cn.Close();

                rptDs = new ReportDataSource("DataSet1", ds.Tables["dtStockIn"]);
                ReportParameter pDate = new ReportParameter("pDate", param);
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pDate });
                reportViewer1.LocalReport.DataSources.Add(rptDs);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void LoadCancelOrder(SqlCommand cmd, string param)
        {
            ReportDataSource rptDs;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptCancelled.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter(cmd); // Use the SqlCommand directly

                cn.Open();
                da.Fill(ds.Tables["dtCancelled"]);
                cn.Close();

                rptDs = new ReportDataSource("DataSet1", ds.Tables["dtCancelled"]);
                ReportParameter pDate = new ReportParameter("pDate", param);
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pDate });
                reportViewer1.LocalReport.DataSources.Add(rptDs);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
