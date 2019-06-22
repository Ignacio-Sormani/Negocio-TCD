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
    [MODELO.formulario(nombre = "frmGrupos", descripcion = "Gestionar Grupos", modulo = "Seguridad")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Grupo", formulario = "frmGrupos", modulo = "Seguridad")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Grupo", formulario = "frmGrupos", modulo = "Seguridad")]
    [MODELO.accion(control = "btnMODIFICAR", descripcion = "Modificar Grupo", formulario = "frmGrupos", modulo = "Seguridad")]
    [MODELO.accion(control = "btnCAMBIARESTADO", descripcion = "Cambiar Estado Grupo", formulario = "frmGrupos", modulo = "Seguridad")]
    public partial class frmGrupos : Form
    {
        public frmGrupos()
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
    }
}
