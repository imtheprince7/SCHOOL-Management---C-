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
    public partial class MarksUpdates : Form
    {
        SqlConnection con = Connection.Connect();
        // int n, n1, n2,sum=0;

        public MarksUpdates()
        {
            InitializeComponent();
        }

        private void MarksUpdates_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
             {
                 con.Open();
                 SqlCommand cmd = new SqlCommand("select * from userregistration where teacherId=@teacherId", con);
                 cmd.Parameters.AddWithValue("@teacherId", textBox1.Text);
                 SqlDataReader dr = cmd.ExecuteReader();
                 if (dr.Read())
                 {
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;

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
            panel1.Visible = true; panel2.Visible = true; panel2.Visible = true;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from studentRegistration where studentid=@studentid", con);
                cmd.Parameters.AddWithValue("@studentid", textBox2.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    groupBox2.Visible = false;
                    panel1.Visible = true; panel2.Visible = true; panel2.Visible = true;

                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error ♪♪" + ex.Message);
            }
        }


        // FOR PHYSICS CALCULATION START**

        private void textBox6_Leave(object sender, EventArgs e)
        {
            textBox45.Text = textBox6.Text;
            
        }
       
       private void textBox81_Leave(object sender, EventArgs e)
        {
            try
            {
                textBox45.Text = (Convert.ToInt32(textBox6.Text)+Convert.ToInt32(textBox81.Text)).ToString();
         
            }

            catch (Exception ex)
            {
                MessageBox.Show("\n" + ex.Message);
            }
        }
        //END **


        // FOR CHEMISTRY CALCULATION START ***

        private void textBox7_Leave(object sender, EventArgs e)
        {
            textBox46.Text = textBox7.Text;
        }
        private void textBox82_Leave(object sender, EventArgs e)
        {
            try
            {
                textBox53.Text = (Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox82.Text)).ToString();

            }
      
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        //END**



        // FOR BIOLOGY CALCULATION START**

        private void textBox8_Leave(object sender, EventArgs e)
        {
            textBox47.Text = textBox8.Text;
        }

        private void textBox83_Leave(object sender, EventArgs e)
        {
            try
            {
                textBox54.Text = (Convert.ToInt32(textBox8.Text) + Convert.ToInt32(textBox83.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        //END 


        private void textBox9_Leave(object sender, EventArgs e)
        {
            textBox48.Text = textBox9.Text;
        }

        private void textBox84_Leave(object sender, EventArgs e)
        {
            try
            {
                textBox48.Text = (Convert.ToInt32(textBox9.Text) + Convert.ToInt32(textBox84.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        // FOR MATH CALCULATION***
        private void textBox10_Leave(object sender, EventArgs e)
        {
            textBox49.Text = textBox10.Text;
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            textBox22.Text = textBox45.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox6.Text) > 70)
                {
                    MessageBox.Show("Please Check Number", "WARNING", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    textBox6.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ☺" + ex.Message);
            }
        }
        private void textBox81_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox81.Text) > 30)
            {
                MessageBox.Show("Please Check Number", "WARNING", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                textBox81.Text = "";
            }
        }
        }

    }

