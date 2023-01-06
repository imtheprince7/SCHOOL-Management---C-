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
        /* 1. Address of SQl Server and database;
           2. Establish Conncection
           3. Open Connection
           4. prepare Query
           5. Execute Query
           6. close Connection
        */
        // Step 1:
            // Make ConnectionString String
        // Step2:
        SqlConnection con = new SqlConnection("Server=tcp:my12server12.database.windows.net,1433;Initial Catalog=project;Persist Security Info=False;User ID=admin1;Password=2@Amit12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

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
                MessageBox.Show("Upload Image", "Image isn't Inserted ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            /*
            try
            {
                if(con!=null)
                {
                    MessageBox.Show("Conected to db"+con.Database);
                }
                else
                {
                    MessageBox.Show(" Not Conected to db" );
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */



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
        
                 // Step 3:---
                con.Open();
                // step 4:-
                // Either we create Query first then we use query ( string query = "insert command";
                // SqlCommand cmd = new SqlCommand(query, con) 
                // or best method is written below

                string query = "insert into userregistration values(@name,@username,@contact,@dob,@gender,@usertype,@teacherId,@emailid,@password,@confirmpassword,@address,@userImage)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@username", textBox2.Text);
                cmd.Parameters.AddWithValue("@contact", textBox3.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@gender", radioButton1.Text);
                cmd.Parameters.AddWithValue("@usertype", comboBox1.Text);
                cmd.Parameters.AddWithValue("@teacherId", textBox8.Text);
                cmd.Parameters.AddWithValue("@emailid", textBox4.Text);
                cmd.Parameters.AddWithValue("@password", textBox5.Text);
                cmd.Parameters.AddWithValue("@confirmpassword", textBox6.Text);
                cmd.Parameters.AddWithValue("@address", textBox7.Text);
                cmd.Parameters.AddWithValue("@userImage", filename);
               
            // Step 5:-- Execute Query
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved...☺☻☻♥");
           //  Step  6:-- Close the Connection
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
