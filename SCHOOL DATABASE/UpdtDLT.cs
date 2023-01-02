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
        SqlConnection con = new SqlConnection("server=HISMILY-PC\\SQL;database=school;integrated security=true;");

        public UpdtDLT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Logins where Tid=@id", con);
                cmd.Parameters.AddWithValue("@id", textBox4.Text);
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
                SqlCommand cmd = new SqlCommand("select * from  Students where Id=@id", con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
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

    


