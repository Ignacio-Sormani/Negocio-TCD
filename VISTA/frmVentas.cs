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
    [MODELO.formulario(nombre = "frmVentas", gestion = "gestionarVentas", descripcion = "Gestionar Ventas", modulo = "Ventas")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Venta", formulario = "frmVentas", modulo = "Ventas")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Venta", formulario = "frmVentas", modulo = "Ventas")]
    public partial class frmVentas : Form
    {
        CONTROLADORA.cVENTAS cVENTAS;
        public frmVentas(MODELO.USUARIO oUsuario)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            cVENTAS = CONTROLADORA.cVENTAS.obtener_instancia();
            btnAGREGAR.Enabled = oUsuario.validar_acciones("btnAGREGAR", "frmVentas");
            btnCONSULTAR.Enabled = oUsuario.validar_acciones("btnCONSULTAR", "frmVentas");
            armar_grilla();
        }

        public void armar_grilla()
        {
            dgvVENTAS.DataSource = null;
            dgvVENTAS.DataSource = cVENTAS.obtener_ventas(txtCLIENTE.Text);
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            armar_grilla();
        }

        private void btnTODAS_Click(object sender, EventArgs e)
        {
            txtCLIENTE.Text = "";
            armar_grilla();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmVenta frmVenta = new frmVenta(new MODELO.VENTA(), "A");
            DialogResult dr = frmVenta.ShowDialog();
            if (dr == DialogResult.OK)
                armar_grilla();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvVENTAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una venta para consultar.");
                return;
            }
            MODELO.VENTA oVENTA = cVENTAS.obtener_venta(Convert.ToInt32(dgvVENTAS.CurrentRow.Cells[0].Value));
            frmVenta frmVenta = new frmVenta(oVENTA, "C");
            frmVenta.ShowDialog();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
