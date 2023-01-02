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
    public partial class TeachersMDI : Form
    {
        SqlConnection con = new SqlConnection("server=HISMILY-PC\\SQL;database=school;integrated security=true;");

        private int childFormNumber = 0;

        public TeachersMDI()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void TeachersMDI_Load(object sender, EventArgs e)
        {

        }

        private void aDMISSIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studentsdetails FF = new Studentsdetails();
           FF.MdiParent=this;
            FF.Show();
        }
        
        private void rECORDSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            UpdtDLT ff = new UpdtDLT();
            ff.MdiParent = this;
            ff.Show();
        }

        private void sTUDENTSDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            UpdtDLT ff = new UpdtDLT();
            ff.MdiParent = this;
            ff.Show();

        }

        private void sHOWRECORDToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            panel2.Visible = true;
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Logins where Tid=@tid", con);
                cmd.Parameters.AddWithValue("@tid", textBox1.Text);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    
                }
                else
                {
                    MessageBox.Show("Teacher ID is not right", "try Again", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    textBox1.Text = "";
                }
                con.Close();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex.Message);
            }

            try
            {
                panel2.Visible = false;
                dataGridView1.Visible = true;
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Logins where Tid=@tid", con);
                cmd.Parameters.AddWithValue("@tid", textBox1.Text);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable tbl = new DataTable();
                ad.Fill(tbl);
                dataGridView1.DataSource = tbl;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error..." + ex.Message);

            }
        
        }

        private void iSEMESTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarksUpdates ff = new MarksUpdates();
            ff.MdiParent = this;
            ff.Show();
        }

        private void iISEMESTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarksUpdates ff = new MarksUpdates();
            ff.MdiParent = this;
            ff.Show();

        }

        private void fINALToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MarksUpdates ff = new MarksUpdates();
            ff.MdiParent = this;
            ff.Show();
        }

        private void uPADTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdtDLT ff = new UpdtDLT();
            ff.MdiParent = this;
            ff.Show();
        }

        private void dELETEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdtDLT ff = new UpdtDLT();
            ff.MdiParent = this;
            ff.Show();
        }

    }
}
