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
    [MODELO.formulario(nombre = "frmProveedores", gestion = "gestionarProveedores", descripcion = "Gestionar Proveedores", modulo = "Compras")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Proveedor", formulario = "frmProveedores", modulo = "Compras")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Proveedor", formulario = "frmProveedores", modulo = "Compras")]
    [MODELO.accion(control = "btnMODIFICAR", descripcion = "Modificar Proveedor", formulario = "frmProveedores", modulo = "Compras")]
    public partial class frmProveedores : Form
    {
        CONTROLADORA.cPROVEEDORES cPROVEEDORES;
        public frmProveedores()
        {
            InitializeComponent();
            cPROVEEDORES = CONTROLADORA.cPROVEEDORES.obtener_instancia();
            armarGrilla();
            btnSELECCIONAR.Visible = false;
        }

        public void armarGrilla() {
            dgvPROVEEDORES.DataSource = null;
            dgvPROVEEDORES.DataSource = cPROVEEDORES.obtener_proveedores(txtBUSCAR.Text);
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            armarGrilla();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmProveedor frmProveedor = new frmProveedor(new MODELO.PROVEEDOR(), "A");
            DialogResult dr = frmProveedor.ShowDialog();
            if (dr == DialogResult.OK)
            {
                armarGrilla();
            }
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvPROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor");
                return;
            }

            MODELO.PROVEEDOR oProveedor = cPROVEEDORES.obtener_proveedor(Convert.ToInt32(dgvPROVEEDORES.CurrentRow.Cells[0].Value));
            frmProveedor frmProveedor = new frmProveedor(oProveedor, "M");
            DialogResult dr = frmProveedor.ShowDialog();
            if (dr == DialogResult.OK) {
                armarGrilla();
            }
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvPROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor");
                return;
            }

            MODELO.PROVEEDOR oProveedor = cPROVEEDORES.obtener_proveedor(Convert.ToInt32(dgvPROVEEDORES.CurrentRow.Cells[0].Value));
            frmProveedor frmProveedor = new frmProveedor(oProveedor, "C");
            frmProveedor.ShowDialog();
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
