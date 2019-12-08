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
        public frmBackup(MODELO.USUARIO oUsuario)
        {
            InitializeComponent();

            btnGENERARBACKUP.Enabled = oUsuario.validar_acciones("btnGENERARBACKUP", "frmBackup");
            btnRECUPERARBACKUP.Enabled = oUsuario.validar_acciones("btnRECUPERARBACKUP", "frmBackup");
        }

        private void btnRECUPERARBACKUP_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\\Users\\Usuario\\Desktop\\Backup_Sistemas\\";
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
                if (CONTROLADORA.FUNCIONES.recuperar_backup(ofd.FileName))
                {
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("NOK");
                }
            }
        }

        private void btnVOLVER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
