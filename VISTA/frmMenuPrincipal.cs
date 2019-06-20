using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VISTA
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();            
        }

        
        public void GenerarBackUp()
        {
            DateTime d = DateTime.Now;
            string dd = d.Day + "-" + d.Month;

            string servername = "(LocalDb)\\MSSQLLocalDB";
            string dbname = "[DATOS.BANCO]";
            string aaa = @"Data Source=" + servername + "; Initial Catalog= " + dbname + "; Integrated Security=true; MultipleActiveResultSets=True;";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;initial catalog=DATOS.BANCO;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            
            try
            {

                con.Open();
                string str = "USE " + dbname + ";";
                string str1 = "BACKUP DATABASE " + dbname + " TO DISK = 'C:\\Backup_Sistemas\\'" + "BANCO" + "-" + dd + ".Bak' WITH FORMMAT,MEDIANAME = 'Z_SQLserverBackups',NAME = 'full backup of " + "DATOS.BANCO";
                SqlCommand cmd1 = new SqlCommand(str, con);
                SqlCommand cmd2 = new SqlCommand(str1, con);


                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                con.Close();



            }

            catch (Exception ex)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado dbo.GenerarBackUp. " + ex.Message, ex);
            }

            finally
            {
                con.Close();
            }


        }



        private void btnBACKUP_Click(object sender, EventArgs e)
        {
            GenerarBackUp();
        }

        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            CONTROLADORA.FUNCIONES.crear_excel();
        }
    }
}
