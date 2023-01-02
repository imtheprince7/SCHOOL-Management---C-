using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;

namespace SCHOOL_DATABASE
{
    public partial class AllUserLogins : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=school;integrated security=true;");
        string filename, filepath;
        public AllUserLogins()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                filename = textBox2.Text + ".jpg";
                filepath = ofd.FileName;
            }
            else
            {
                MessageBox.Show("Upload Image", "Image Can't Insert YET", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == "")
                {

                    MessageBox.Show("Name is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox2.Text == "")
                {

                    MessageBox.Show("UserName is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox5.Text == "")
                {

                    MessageBox.Show("PassWord/n can't Leave Empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox6.Text == "")
                {

                    MessageBox.Show("PassWord/n can't Leave Empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox7.Text == "")
                {

                    MessageBox.Show("Address Field is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }




                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Logins Values(@nm,@un,@cn,@db,@gn,@ty,@tid,@eml,@pd,@cpd,@ad,@pic)", con);
                cmd.Parameters.AddWithValue("@nm", textBox1.Text);
                cmd.Parameters.AddWithValue("@un", textBox2.Text);
                cmd.Parameters.AddWithValue("@cn", textBox3.Text);
                cmd.Parameters.AddWithValue("@db", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@gn", radioButton1.Text);
                cmd.Parameters.AddWithValue("@ty",comboBox1.Text);
                cmd.Parameters.AddWithValue("@tid",textBox8.Text);
                cmd.Parameters.AddWithValue("@eml", textBox4.Text);
                cmd.Parameters.AddWithValue("@pd", textBox5.Text);
                cmd.Parameters.AddWithValue("@cpd", textBox6.Text);
                cmd.Parameters.AddWithValue("@ad", textBox7.Text);
                cmd.Parameters.AddWithValue("@pic", filename);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved...☺☻☻♥");
                con.Close();
                File.Copy(filepath, Application.StartupPath + "/" + filename);

                textBox1.Text = "";  textBox2.Text = "";
                textBox3.Text = "";  textBox4.Text = "";
                textBox5.Text = "";  textBox6.Text = "";
                textBox7.Text = "";  textBox8.Text = "";
                comboBox1.Text = ""; pictureBox1.ImageLocation = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error ☺☻"+ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";  textBox2.Text = "";
            textBox3.Text = "";  textBox4.Text = "";
            textBox5.Text = "";  textBox6.Text = "";
            textBox7.Text = "";  textBox8.Text = "";
            comboBox1.Text = ""; pictureBox1.ImageLocation = "";

        }
        private void button3_Click(object sender, EventArgs e)
        {
            LoginPage ff = new LoginPage();
            this.Hide();
            ff.Show();
        }

        private void AllUserLogins_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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
                    errorProvider1.SetError(this.textBox4, "Enter valid Emailid");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error !\n" + ex.Message);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == textBox6.Text)
            {
                textBox6.ForeColor = Color.Blue;
            }
            else 
            {
                textBox6.ForeColor = Color.Red;
            
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

            }
}
