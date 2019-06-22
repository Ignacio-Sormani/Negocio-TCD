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
    [MODELO.formulario(nombre = "frmUsuarios", descripcion = "Gestionar Usuarios", modulo = "Seguridad")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Usuario", formulario = "frmUsuarios", modulo = "Seguridad")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Usuario", formulario = "frmUsuarios", modulo = "Seguridad")]
    [MODELO.accion(control = "btnMODIFICAR", descripcion = "Modificar Usuario", formulario = "frmUsuarios", modulo = "Seguridad")]
    [MODELO.accion(control = "btnCAMBIARESTADO", descripcion = "Cambiar Estado Usuario", formulario = "frmUsuarios", modulo = "Seguridad")]
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {

        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {

        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {

        }

        private void btnCAMBIARESTADO_Click(object sender, EventArgs e)
        {

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {

        }
    }
}
