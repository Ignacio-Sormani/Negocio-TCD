using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    [MODELO.formulario(nombre = "frmBackup", gestion = "gestionarBackups", descripcion = "Gestionar Backup", modulo = "Seguridad")]
    [MODELO.accion(control = "btnGENERARBACKUP", descripcion = "Generar Backup", formulario = "frmBackup", modulo = "Seguridad")]
    [MODELO.accion(control = "btnRECUPERARBACKUP", descripcion = "Recuperar Backup", formulario = "frmBackup", modulo = "Seguridad")]

    public partial class frmBackup : Form
    {
        string dbname;
        string connectionString;
        CONTROLADORA.FACADEBACKUP oFACADEBACKUP;
        public frmBackup(MODELO.USUARIO oUsuario)
        {
            InitializeComponent();
            FormStyle.windowStyle(this);
            oFACADEBACKUP = CONTROLADORA.FACADEBACKUP.obtener_instancia();

            btnGENERARBACKUP.Enabled = oUsuario.validar_acciones("btnGENERARBACKUP", "frmBackup");
            btnRECUPERARBACKUP.Enabled = oUsuario.validar_acciones("btnRECUPERARBACKUP", "frmBackup");
            dbname = "DATOS.Negocio";
            connectionString = @"Data Source=DESKTOP-Q6GB95M; Initial Catalog=" + dbname + "; Integrated Security=true; MultipleActiveResultSets=True;";
        }

        private void btnRECUPERARBACKUP_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\nacho\Desktop\Sistema_de_Libreria\Backup_Sistemas";
            ofd.Title = "Seleccionar archivo a restaurar";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.DefaultExt = "BAK";
            ofd.Filter = "Text files (*.bak)|*.bak";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            ofd.ReadOnlyChecked = true;
            ofd.ShowReadOnly = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (oFACADEBACKUP.RecuperarBackup(ofd.FileName, dbname, connectionString))
                {
                    MessageBox.Show("Se recupero exitosamente el sistema.");
                }
                else
                {
                    MessageBox.Show("Se produjo un error y no se pudo recuperar el sistema.");
                }
            }
        }

        private void btnVOLVER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGENERARBACKUP_Click(object sender, EventArgs e)
        {
            if (oFACADEBACKUP.GenerarBackup(dbname, connectionString))
            {
                MessageBox.Show("Se genero exitosamente el bakup del sistema.");
            }
            else
            {
                MessageBox.Show("Se produjo un error y no se pudo generar un backup el sistema.");
            }
        }
    }
}
