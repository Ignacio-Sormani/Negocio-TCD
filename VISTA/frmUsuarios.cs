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
    [MODELO.formulario(nombre = "frmUsuarios", gestion = "gestionarUsuarios", descripcion = "Gestionar Usuarios", modulo = "Seguridad")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Usuario", formulario = "frmUsuarios", modulo = "Seguridad")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Usuario", formulario = "frmUsuarios", modulo = "Seguridad")]
    [MODELO.accion(control = "btnMODIFICAR", descripcion = "Modificar Usuario", formulario = "frmUsuarios", modulo = "Seguridad")]
    [MODELO.accion(control = "btnCAMBIARESTADO", descripcion = "Cambiar Estado Usuario", formulario = "frmUsuarios", modulo = "Seguridad")]
    public partial class frmUsuarios : Form
    {
        CONTROLADORA.cUSUARIOS cUSUARIOS;
        public frmUsuarios(MODELO.USUARIO oUsuario)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            cUSUARIOS = CONTROLADORA.cUSUARIOS.obtener_instancia();
            btnAGREGAR.Enabled = oUsuario.validar_acciones("btnAGREGAR", "frmUsuarios");
            btnCONSULTAR.Enabled = oUsuario.validar_acciones("btnCONSULTAR", "frmUsuarios");
            btnMODIFICAR.Enabled = oUsuario.validar_acciones("btnMODIFICAR", "frmUsuarios");
            btnCAMBIARESTADO.Enabled = oUsuario.validar_acciones("btnCAMBIARESTADO", "frmUsuarios");
            armar_grilla();
        }

        public void armar_grilla()
        {
            dgvUSUARIOS.DataSource = null;
            dgvUSUARIOS.DataSource = cUSUARIOS.obtener_usuarios(txtBUSCAR.Text);
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario(new MODELO.USUARIO(), "A");
            DialogResult dr = frmUsuario.ShowDialog();
            if (dr == DialogResult.OK)
                armar_grilla();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvUSUARIOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista");
                return;
            }
            frmUsuario frmUsuario = new frmUsuario(cUSUARIOS.obtener_usuario(Convert.ToInt32(dgvUSUARIOS.CurrentRow.Cells[0].Value)), "C");
            DialogResult dr = frmUsuario.ShowDialog();
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvUSUARIOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista");
                return;
            }
            frmUsuario frmUsuario = new frmUsuario(cUSUARIOS.obtener_usuario(Convert.ToInt32(dgvUSUARIOS.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = frmUsuario.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                armar_grilla();
        }

        private void btnCAMBIARESTADO_Click(object sender, EventArgs e)
        {
            if (dgvUSUARIOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista");
                return;
            }
            MODELO.USUARIO oUsuario = cUSUARIOS.obtener_usuario(Convert.ToInt32(dgvUSUARIOS.CurrentRow.Cells[0].Value));
            oUsuario.estadoActivo = !oUsuario.estadoActivo;
            cUSUARIOS.modificar_usuario(oUsuario);
            armar_grilla();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            armar_grilla();
        }

        private void btnTODAS_Click(object sender, EventArgs e)
        {
            txtBUSCAR.Text = "";
            armar_grilla();
        }
    }
}
