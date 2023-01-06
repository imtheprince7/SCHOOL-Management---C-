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
    public partial class UpdtDLT : Form
    {
        SqlConnection con = new SqlConnection("Server=tcp:my12server12.database.windows.net,1433;Initial Catalog=project;Persist Security Info=False;User ID=admin1;Password=2@Amit12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public UpdtDLT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from userregistration where teacherId=@teacherId", con);
                cmd.Parameters.AddWithValue("@teacherId", textBox4.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;

                }
                else 
                {
                    MessageBox.Show("TRY AGAIN\n ☺☻☻☺", "Wrong Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    textBox4.Text = "";
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error ♪♪" + ex.Message);
            }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            TeachersMDI ff = new TeachersMDI();
            this.Hide();
            ff.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try 
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from  studentRegistration where studentid=@studentid", con);
                cmd.Parameters.AddWithValue("@studentid", textBox1.Text);
                 SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    groupBox2.Visible=false;
                    panel1.Visible=true;

                }

                else
                {
                    MessageBox.Show("TRY AGAIN\n ☺☻☻☺", "Wrong Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    textBox1.Text = "";
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error ♪♪" + ex.Message);
            }
            }

        private void UpdtDLT_Load(object sender, EventArgs e)
        {

        }
        }
    }

    


