﻿using System;
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

        SqlConnection con = Connection.Connect();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from userregistration where (username=@username and password=@password and usertype=@usertype)", con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                cmd.Parameters.AddWithValue("@usertype", comboBox1.Text);

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
            if (textBox1.Text != "@username" || textBox2.Text != "@password")
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
                SqlCommand cmd = new SqlCommand("select * from userregistration where contact=@contact", con);
                cmd.Parameters.AddWithValue("@contact", textBox3.Text);
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
