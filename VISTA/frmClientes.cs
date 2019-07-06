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
    [MODELO.formulario(nombre = "frmClientes", gestion = "gestionarClientes", descripcion = "Gestionar Clientes", modulo = "Ventas")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Cliente", formulario = "frmClientes", modulo = "Ventas")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Cliente", formulario = "frmClientes", modulo = "Ventas")]
    [MODELO.accion(control = "btnMODIFICAR", descripcion = "Modificar Cliente", formulario = "frmClientes", modulo = "Ventas")]
    public partial class frmClientes : Form
    {
        CONTROLADORA.cCLIENTES cCLIENTES;
        public frmClientes()
        {
            InitializeComponent();
            cCLIENTES = CONTROLADORA.cCLIENTES.obtener_instancia();
            armarGrilla();
            btnSELECCIONAR.Visible = false;
        }

        public void armarGrilla() {
            dgvCLIENTES.DataSource = null;
            dgvCLIENTES.DataSource = cCLIENTES.obtener_clientes(txtBUSCAR.Text);
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            armarGrilla();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente(new MODELO.CLIENTE(), "A");
            DialogResult dr = frmCliente.ShowDialog();
            if (dr == DialogResult.OK) {
                armarGrilla();
            }
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return;
            }

            MODELO.CLIENTE oCliente = cCLIENTES.obtener_cliente(Convert.ToInt32(dgvCLIENTES.CurrentRow.Cells[0].Value));
            frmCliente frmCliente = new frmCliente(oCliente, "M");
            DialogResult dr = frmCliente.ShowDialog();
            if (dr == DialogResult.OK) {
                armarGrilla();
            }
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return;
            }

            MODELO.CLIENTE oCliente = cCLIENTES.obtener_cliente(Convert.ToInt32(dgvCLIENTES.CurrentRow.Cells[0].Value));
            frmCliente frmCliente = new frmCliente(oCliente, "C");
            frmCliente.ShowDialog();
        }

        private void btnSELECCIONAR_Click(object sender, EventArgs e)
        {

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTODOS_Click(object sender, EventArgs e)
        {
            txtBUSCAR.Text = "";
            armarGrilla();
        }
    }
}
