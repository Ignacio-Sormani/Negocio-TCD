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
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnGENERARBACKUP_Click(object sender, EventArgs e)
        {
            CONTROLADORA.FUNCIONES.generar_backup();
        }

        private void btnRECUPERARBACKUP_Click(object sender, EventArgs e)
        {

        }

        private void btnVOLVER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
