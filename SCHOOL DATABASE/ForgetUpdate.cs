using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace SCHOOL_DATABASE
{
    public partial class ForgetUpdate : Form
    {
          SqlConnection con = Connection.Connect();
        // string Name;
        public ForgetUpdate()
        {
            InitializeComponent();
        }

         public ForgetUpdate(string Name)
        {
            InitializeComponent();
            this.Name = Name;
        }


        private void  button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from userregistration where contact=@contact", con);
                cmd.Parameters.AddWithValue("@contact", textBox10.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {   groupBox1.Visible = false;
                    panel1.Visible = true;
                }

                else
                {
                    MessageBox.Show("Sorry...☻☻\n You Need To Register Yourself\n");
                    this.Hide();
                    AllUserLogins rg = new AllUserLogins();
                    rg.Show();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Check Error" + ex.Message);
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
        try
        {
            if (textBox7.Text == "")
            {

                MessageBox.Show("UserName is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



                con.Open();
                
                SqlCommand cmd = new SqlCommand("update userregistration set emailid=@emailid,contact=@contact where username=@username", con);
                cmd.Parameters.AddWithValue("@emailid", textBox8.Text);
                cmd.Parameters.AddWithValue("@contact", textBox9.Text);
                cmd.Parameters.AddWithValue("@username", textBox7.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated.. ");
                con.Close();
                LoginPage ff = new LoginPage();
                this.Hide();
                ff.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {


                if (textBox3.Text == "")
                {

                    MessageBox.Show("UserName is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (textBox4.Text == "")
                {

                    MessageBox.Show("PassWord can't be Empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (textBox5.Text == "")
                {

                    MessageBox.Show("PassWord can't be Empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }



                con.Open();
                SqlCommand cmd = new SqlCommand("update userregistration set password=@password,confirmpassword=@confirmpassword where username=@username", con);
                cmd.Parameters.AddWithValue("@password", textBox4.Text);
                cmd.Parameters.AddWithValue("@confirmpassword", textBox5.Text);
                cmd.Parameters.AddWithValue("@username", textBox3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated.. ►‼◄");
                con.Close();
                LoginPage ff = new LoginPage();
                this.Hide();
                ff.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginPage ff = new LoginPage();
            this.Hide();
            ff.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == textBox4.Text)
            {
                textBox5.ForeColor = Color.Blue;
            }
            else
            {
                textBox5.ForeColor = Color.Red;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                if (Regex.IsMatch(textBox4.Text, pattern))
                {
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(this.textBox4, "Enter valid Email ID");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error !\n" + ex.Message);
            }
        }

      

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginPage ff = new LoginPage();
            this.Hide();
            ff.Show();
        }

        private void ForgetUpdate_Load(object sender, EventArgs e)
        {

        }
    }
    }

