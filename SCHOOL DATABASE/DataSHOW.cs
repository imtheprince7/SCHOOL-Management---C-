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
           SqlConnection con = Connection.Connect();
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
