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
    public partial class LoginPage : Form
    {
        
        SqlConnection con = new SqlConnection("server=.;database=school;integrated security=true;");
        
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Logins where (Username=@un and Pswd=@pd and Typee=@ty)", con);
                cmd.Parameters.AddWithValue("@un", textBox1.Text);
                cmd.Parameters.AddWithValue("@pd", textBox2.Text);
                cmd.Parameters.AddWithValue("@ty", comboBox1.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    if (comboBox1.Text == "PRINCIPAL")
                    {
                        panel1.Visible = false;
                        panel2.Visible = true;
                    }

                    else if (comboBox1.Text == "VICE-PRINCIPAL")
                    {
                        VicePrincipalMDI ff = new VicePrincipalMDI();
                        this.Hide();
                        ff.Show();
                    }
                    else if
                        (comboBox1.Text == "TEACHER")
                    {
                        TeachersMDI ff = new TeachersMDI();
                        this.Hide();
                        ff.Show();
                    }
                    else if
                       (comboBox1.Text == "LIBRARY-ADMIN")
                    {
                        LibraryAdmin ff = new LibraryAdmin();
                        this.Hide();
                        ff.Show();
                    }
                }
                con.Close();
                textBox1.Text = "";  textBox2.Text = "";  comboBox1.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ☺" + ex.Message);
            }
            if (textBox1.Text != "@un" || textBox2.Text != "@pd")
                 {
                textBox1.Text = "";
                textBox2.Text = "";
                        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Logins where Contact=@cn", con);
                cmd.Parameters.AddWithValue("@cn", textBox3.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    PrincipalMDI ff = new PrincipalMDI();
                    this.Hide();
                    ff.Show();
                }
                else
                {
                    MessageBox.Show("Contact No. not found", "invalid Attempt", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    textBox3.Text = "";
                    panel2.Visible = false;
                    panel1.Visible = true;
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error ☺" + ex.Message);
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllUserLogins ff = new AllUserLogins();
            this.Hide();
            ff.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetUpdate fu = new ForgetUpdate();
            this.Hide();
            fu.Show();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
