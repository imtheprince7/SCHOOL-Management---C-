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
    public partial class PrincipalMDI : Form
    {
        private int childFormNumber = 0;

        SqlConnection con = new SqlConnection("Server=tcp:my12server12.database.windows.net,1433;Initial Catalog=project;Persist Security Info=False;User ID=admin1;Password=2@Amit12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        string msg;
        public PrincipalMDI()
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

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void PrincipalMDI_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoginPage ff = new LoginPage();
            this.Hide();
            ff.Show();
        }

        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cLASSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                }

                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception" + ex.Message);

            }
        }

        private void sTATUSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VicePrincipalMDI ff = new VicePrincipalMDI();
            ff.Show();
        }

        private void aNNOUNCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void mESSAGEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void mESSAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void mESSAGEToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            msg = textBox1.Text;
            textBox1.Text = "";
        }

        private void iNFORMATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = msg;
            button1.Visible = false; label2.Visible = true;
            textBox1.ReadOnly = true;
            label1.Visible = false;
        }
    }
}
