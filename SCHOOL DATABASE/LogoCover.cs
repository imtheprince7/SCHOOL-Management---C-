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
    public partial class LogoCover : Form
    {
        public LogoCover()
        {
            InitializeComponent();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 20;
            

            if (progressBar1.Value >= 20)
            { panel1.Visible = true; 
            }

            if (progressBar1.Value >= 40)
            {
                 label2.ForeColor = Color.Azure;
                }

            if (progressBar1.Value >= 60)
            {
              //  label1.ForeColor = Color.NavajoWhite;
                label2.ForeColor = Color.MediumSpringGreen;
               // label3.ForeColor = Color.AntiqueWhite;
                label4.ForeColor = Color.PaleGoldenrod;
            }

            
            if (progressBar1.Value >= 80)
            {
                //label1.ForeColor = Color.DarkRed;   label3.ForeColor = Color.DarkRed;
                label2.ForeColor = Color.DarkRed;  label4.ForeColor = Color.Red;
            }
            
            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;

                this.Hide();
                LoginPage ff = new LoginPage();
                ff.Show();
            }
        }

        private void LogoCover_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
