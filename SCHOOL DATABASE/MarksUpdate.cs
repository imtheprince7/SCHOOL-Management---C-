using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCHOOL_DATABASE
{
    public partial class MarksUpdate : Form
    {
        public MarksUpdate()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /* try
             {
                 con.Open();
                 SqlCommand cmd = new SqlCommand("select * from Logins where Tid=@id", con);
                 cmd.Parameters.AddWithValue("@id", textBox1.Text);
                 SqlDataReader dr = cmd.ExecuteReader();
                 if (dr.Read())
                 {*/
            groupBox1.Visible = false;
            groupBox2.Visible = true;

            /* }
             con.Close();
         }

         catch (Exception ex)
         {
             MessageBox.Show("Error ♪♪" + ex.Message);
         }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true; 

            /*try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Students where Id=@id", con);
                cmd.Parameters.AddWithValue("@id", textBox2.Text);
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
            }*/
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            textBox45.Text = textBox6.Text;
           

        }

        private void textBox81_Leave(object sender, EventArgs e)
        {
            try
            {
                textBox45.Text = (Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox81.Text)).ToString();
             
  if (Convert.ToInt32(textBox6.Text) > 70)
                {
                    MessageBox.Show("Please Check Number", "WARNING", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    textBox6.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("\n" + ex.Message);
            }

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
            { }
        }

        private void textBox81_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox81.Text) >30)
                {
                    MessageBox.Show("Please Check Number", "WARNING", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    textBox81.Text="";
                }
            }
            catch (Exception ex)
            { }

        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox45.Text)>100)
                {
                    MessageBox.Show("Please Check Number", "WARNING", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    textBox45.Text="";
                }
            }
            catch (Exception ex)
            { }

        }
    }
}
