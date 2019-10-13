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
        MODELO.ORDENDECOMPRA oOrden;
        public frmProveedores(MODELO.USUARIO oUsuario)
        {
            InitializeComponent();
            cPROVEEDORES = CONTROLADORA.cPROVEEDORES.obtener_instancia();
            btnSELECCIONAR.Visible = false;
            btnAGREGAR.Enabled = oUsuario.validar_acciones("btnAGREGAR", "frmProveedores");
            btnCONSULTAR.Enabled = oUsuario.validar_acciones("btnCONSULTAR", "frmProveedores");
            btnMODIFICAR.Enabled = oUsuario.validar_acciones("btnMODIFICAR", "frmProveedores");

            armarGrilla();
        }

        public frmProveedores(MODELO.ORDENDECOMPRA miOrden)
        {
            InitializeComponent();

            cPROVEEDORES = CONTROLADORA.cPROVEEDORES.obtener_instancia();
            oOrden = miOrden;
            armarGrilla();
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
            if (dgvPROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor de la lista");
                return;
            }
            oOrden.proveedor = cPROVEEDORES.obtener_proveedor(Convert.ToInt32(dgvPROVEEDORES.CurrentRow.Cells[0].Value));
            this.Close();
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
