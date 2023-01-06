using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCHOOL_DATABASE
{
    public partial class DataSHOW : Form
    {
        SqlConnection con = new SqlConnection("Server=tcp:my12server12.database.windows.net,1433;Initial Catalog=project;Persist Security Info=False;User ID=admin1;Password=2@Amit12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public DataSHOW()
        {
            InitializeComponent();
        }

        private void DataSHOW_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void DataSHOW_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from studentRegistration", con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                con.Close();
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error...♪" + ex.Message);
            }
        }
    }
}
