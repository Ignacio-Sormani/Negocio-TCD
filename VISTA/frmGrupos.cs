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
    [MODELO.formulario(nombre = "frmGrupos", gestion = "gestionarGrupos", descripcion = "Gestionar Grupos", modulo = "Seguridad")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Grupo", formulario = "frmGrupos", modulo = "Seguridad")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Grupo", formulario = "frmGrupos", modulo = "Seguridad")]
    [MODELO.accion(control = "btnMODIFICAR", descripcion = "Modificar Grupo", formulario = "frmGrupos", modulo = "Seguridad")]
    [MODELO.accion(control = "btnCAMBIARESTADO", descripcion = "Cambiar Estado Grupo", formulario = "frmGrupos", modulo = "Seguridad")]
    public partial class frmGrupos : Form
    {
        CONTROLADORA.cGRUPOS cGRUPOS;
        public frmGrupos(MODELO.USUARIO oUsuario)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            cGRUPOS = CONTROLADORA.cGRUPOS.obtener_instancia();
            btnAGREGAR.Enabled = oUsuario.validar_acciones("btnAGREGAR", "frmGrupos");
            btnCONSULTAR.Enabled = oUsuario.validar_acciones("btnCONSULTAR", "frmGrupos");
            btnMODIFICAR.Enabled = oUsuario.validar_acciones("btnMODIFICAR", "frmGrupos");
            armar_grilla();
        }

        public void armar_grilla()
        {
            dgvGRUPOS.DataSource = null;
            dgvGRUPOS.DataSource = cGRUPOS.obtener_grupos(txtBUSCAR.Text);
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmGrupo frmGrupo = new frmGrupo(new MODELO.GRUPO(), "A");
            DialogResult dr = frmGrupo.ShowDialog();
            if (dr == DialogResult.OK)
                armar_grilla();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvGRUPOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo de la lista");
                return;
            }
            frmGrupo frmGrupo = new frmGrupo(cGRUPOS.obtener_grupo(Convert.ToInt32(dgvGRUPOS.CurrentRow.Cells[0].Value)), "C");
            frmGrupo.ShowDialog();
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvGRUPOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo de la lista");
                return;
            }
            frmGrupo frmGrupo = new frmGrupo(cGRUPOS.obtener_grupo(Convert.ToInt32(dgvGRUPOS.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = frmGrupo.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                armar_grilla();
        }

        private void btnCAMBIARESTADO_Click(object sender, EventArgs e)
        {
            if (dgvGRUPOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista");
                return;
            }
            MODELO.GRUPO oGrupo = cGRUPOS.obtener_grupo(Convert.ToInt32(dgvGRUPOS.CurrentRow.Cells[0].Value));
            oGrupo.estadoActivo = !oGrupo.estadoActivo;
            cGRUPOS.modificar_grupo(oGrupo);
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

        private void btnTODOS_Click(object sender, EventArgs e)
        {
            txtBUSCAR.Text = "";
            armar_grilla();
        }
    }
}
