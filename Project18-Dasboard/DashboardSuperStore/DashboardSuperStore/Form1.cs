using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardSuperStore
{
    public partial class Form1: Form
    {

        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-6PJQ8SH\\SQLEXPRESS; initial catalog=Db18Project; integrated security=true");


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) From superstore", sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            { 
                lblProductCount.Text = reader[0].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand cmd2 = new SqlCommand("Select Count(Distinct(State)) From superstore", sqlConnection);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                lblCityCount.Text = reader2[0].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand cmd3 = new SqlCommand("Select Count(Distinct(Order_ID)) From superstore", sqlConnection);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                lblOrderCount.Text = reader3[0].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand cmd4 = new SqlCommand("Select Count(*) From superstore where country='Turkey'", sqlConnection);
            SqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                lblTrOrder.Text = reader4[0].ToString();
            }
            sqlConnection.Close();
        }
    }
}
