using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL_DATABASE
{
    internal class Connection
    {
        public static SqlConnection Connect()
        {
            SqlConnection con = new SqlConnection("Server=tcp:my12server12.database.windows.net,1433;Initial Catalog=project;Persist Security Info=False;User ID=admin1;Password=2@Amit12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            if(con!=null)
            {
                return con;
            }
            else
            {
                MessageBox.Show("Not Connected!!");
                return null;
            }
        }
    }
   
}
