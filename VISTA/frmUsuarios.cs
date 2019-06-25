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
        CONTROLADORA.cUSUARIOS cUSUARIOS;
        //agregar MODELO.USUARIO oUSUARIO en el parametro y boton seleccionar para el CU-buscar
        public frmUsuarios()
        {
            InitializeComponent();

            cUSUARIOS = CONTROLADORA.cUSUARIOS.obtener_instancia();
            armar_grilla();
        }

        public void armar_grilla()
        {
            dgvUSUARIOS.DataSource = null;
            dgvUSUARIOS.DataSource = cUSUARIOS.obtener_usuarios(txtBUSCAR.Text);
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
            this.Close();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            armar_grilla();
        }
    }
}
