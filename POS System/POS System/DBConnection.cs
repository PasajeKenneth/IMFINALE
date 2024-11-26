using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace POS_System
{
    public class DBConnection
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        //private double dailysales;
        private string con;
        private int productline;
        private int stockonhand;
        private int critical;
        public string MyConnection()
        {
            con = @"Data Source=LAPTOP-KR07DEOP\SQLEXPRESS;Initial Catalog=POS_DEMO_DB;Integrated Security=True";
            return con;
        }
        public double GetVal()
        {
            double vat = 0;
            cn = new SqlConnection(MyConnection());

            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tblVat", cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    vat = Double.Parse(dr["vat"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dr?.Close();
                cn?.Close();
            }

            return vat;
        }

        public double DailySales()
        {
            double dailySales = 0;
            string sdate = DateTime.Now.ToString("yyyy-MM-dd"); 

            try
            {
                using (var cn = new SqlConnection(MyConnection())) 
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SELECT ISNULL(SUM(total), 0) FROM tblCart WHERE CAST(sdate AS DATE) = @sdate AND status = 'Sold'", cn))
                    {
                        cmd.Parameters.AddWithValue("@sdate", sdate);
                        dailySales = Convert.ToDouble(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching daily sales: {ex.Message}");
            }

            return dailySales;
        }

        public double ProductLine()
        {
            cn = new SqlConnection();
            cn.ConnectionString = con;
            cn.Open();
            cm = new SqlCommand("select count(*)  from tblProduct  ", cn);
            productline = int.Parse(cm.ExecuteScalar().ToString());

            cn.Close();
            return productline;
        }

        public double StockOnHand()
        {
            cn = new SqlConnection();
            cn.ConnectionString = con;
            cn.Open();
            cm = new SqlCommand("select isnull(sum(qty),0)  as qty  from tblProduct   ", cn);
            stockonhand = int.Parse(cm.ExecuteScalar().ToString());

            cn.Close();
            return stockonhand;
        }

        public double Critical()
        {
            cn = new SqlConnection();
            cn.ConnectionString = con;
            cn.Open();
            cm = new SqlCommand("select count(*) from vwCriticalItem  ", cn);
            critical = int.Parse(cm.ExecuteScalar().ToString());

            cn.Close();
            return critical;
        }

        public string GetPassword(string user)
        {
            string password = "";
            cn = new SqlConnection(MyConnection());
            cn.Open();
            cm = new SqlCommand("select * from tblUser where username = @username", cn);
            cm.Parameters.AddWithValue("@username", user);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                password = dr["password"].ToString();
            }


            dr.Close();
            cn.Close();


            return password;
        }

    }
}
