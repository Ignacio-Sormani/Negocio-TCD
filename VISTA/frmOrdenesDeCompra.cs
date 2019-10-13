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
    [MODELO.formulario(nombre = "frmOrdenesDeCompra", gestion = "gestionarOrdenesDeCompras", descripcion = "Gestionar Ordenes de Compra", modulo = "Compras")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Orden de Compra", formulario = "frmOrdenesDeCompra", modulo = "Compras")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Orden de Compra", formulario = "frmOrdenesDeCompra", modulo = "Compras")]
    public partial class frmOrdenesDeCompra : Form
    {
        CONTROLADORA.cORDENESDECOMPRA cORDENESDECOMPRA;
        public frmOrdenesDeCompra(MODELO.USUARIO oUsuario)
        {
            InitializeComponent();

            cORDENESDECOMPRA = CONTROLADORA.cORDENESDECOMPRA.obtener_instancia();
            btnAGREGAR.Enabled = oUsuario.validar_acciones("btnAGREGAR", "frmOrdenesDeCompra");
            btnCONSULTAR.Enabled = oUsuario.validar_acciones("btnCONSULTAR", "frmOrdenesDeCompra");
            armar_grilla("");
        }

        public void armar_grilla(string proveedor)
        {
            dgvORDENES.DataSource = null;
            dgvORDENES.DataSource = cORDENESDECOMPRA.obtener_ordenes(proveedor);
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            armar_grilla(txtPROVEEDOR.Text);
        }

        private void btnTODAS_Click(object sender, EventArgs e)
        {
            armar_grilla("");
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmOrdenDeCompra frmOrdenDeCompra = new frmOrdenDeCompra(new MODELO.ORDENDECOMPRA(), "A");
            DialogResult dr = frmOrdenDeCompra.ShowDialog();
            if (dr == DialogResult.OK)
                armar_grilla("");
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvORDENES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una venta para consultar.");
                return;
            }
            MODELO.ORDENDECOMPRA oORDEN = cORDENESDECOMPRA.obtener_orden(Convert.ToInt32(dgvORDENES.CurrentRow.Cells[0].Value));
            frmOrdenDeCompra frmOrdenDeCompra = new frmOrdenDeCompra(oORDEN, "C");
            frmOrdenDeCompra.ShowDialog();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
