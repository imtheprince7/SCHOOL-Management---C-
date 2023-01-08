using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SCHOOL_DATABASE
{
    public partial class Studentsdetails : Form
    {
        SqlConnection con = Connection.Connect();

        string filename,filepath,name,pic;
        public Studentsdetails()
        {
            InitializeComponent();
        }

        private void Studentsdetails_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from userregistration where (teacherId=@teacherId)", con);
                cmd.Parameters.AddWithValue("@teacherId", textBox9.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    panel1.Visible = false;
                    groupBox1.Visible = true;
                    groupBox2.Visible = true;
                }
                else
                {
                    textBox9.Text = "";
                    MessageBox.Show("Error at data fetching");

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.....♪" + ex.Message);
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
       
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                filename = textBox1.Text+".jpg";
                filepath = ofd.FileName;
            }
            else
            {
                MessageBox.Show("Upload Image", "Image not Uploaded", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try{
                if (textBox1.Text == "")
                {

                    MessageBox.Show("Student ID is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

              if (textBox2.Text == "")
                {

                    MessageBox.Show("Name is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (textBox3.Text == "")
                {

                    MessageBox.Show("Father Name is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (textBox4.Text == "")
                {

                    MessageBox.Show("Mother Name is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox5.Text == "")
                {

                    MessageBox.Show("ContactNo is Important", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (textBox6.Text == "")
                {

                    MessageBox.Show("Email ID is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Class Field is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (textBox9.Text == "")
                {
                    MessageBox.Show("Roll No Can't be Empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Section Field is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (comboBox3.Text == "")
                {
                    MessageBox.Show("Medium Field  is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (textBox7.Text == "")
                {
                    MessageBox.Show("Address Can't be Empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                if (pictureBox1.ImageLocation == "")
                {
                    MessageBox.Show("Student Picture is Important ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }



            con.Open();
            SqlCommand cmd = new SqlCommand("insert into studentRegistration values(@studentid ,@studentName ,@fatherName,@motherName,@dob,@dot,@gender,@class,@rollNo,@section,@medium,@contact,@email,@address,@studentPicture)", con);
            cmd.Parameters.AddWithValue("@studentid", textBox1.Text);     cmd.Parameters.AddWithValue("@studentName",textBox2.Text);
            cmd.Parameters.AddWithValue("@fatherName", textBox3.Text);     cmd.Parameters.AddWithValue("@motherName", textBox4.Text);
            cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.ToString("yyyy-MM-dd")); cmd.Parameters.AddWithValue("@dot", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@gender",radioButton1.Text);      cmd.Parameters.AddWithValue("@class",comboBox1.Text);
            cmd.Parameters.AddWithValue("@rollNo", textBox8.Text);       cmd.Parameters.AddWithValue("@section",comboBox2.Text);
             cmd.Parameters.AddWithValue("@medium",comboBox3.Text);      cmd.Parameters.AddWithValue("@contact",textBox5.Text);
             cmd.Parameters.AddWithValue("@email",textBox6.Text);       cmd.Parameters.AddWithValue("@address",textBox7.Text);  
             cmd.Parameters.AddWithValue("@studentPicture", pictureBox1.ImageLocation);
             
                cmd.ExecuteNonQuery();

             File.Copy(filepath, Application.StartupPath + "/" + filename);
             MessageBox.Show("Records Saved....►", "Record Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
             con.Close();
             textBox1.Text = "";  textBox2.Text = "";
             textBox3.Text = "";  textBox4.Text = "";
             textBox5.Text = "";  textBox6.Text = "";
             textBox7.Text = "";  textBox8.Text = "";
             comboBox1.Text = ""; comboBox2.Text = "";
             comboBox3.Text = ""; pictureBox1.ImageLocation= "";
        }
        
        catch(Exception ex)
    {
    
    MessageBox.Show("Error"+ex.Message);
    }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";  textBox2.Text = "";
            textBox3.Text = "";  textBox4.Text = "";
            textBox5.Text = "";  textBox6.Text = "";
            textBox7.Text = "";  textBox8.Text = "";
            comboBox1.Text = ""; comboBox2.Text = "";
            comboBox3.Text = ""; pictureBox1.ImageLocation = "";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                if (Regex.IsMatch(textBox6.Text, pattern))
                {
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(this.textBox6, "Enter valid Emailid");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error !\n" + ex.Message);
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
         }
    }

