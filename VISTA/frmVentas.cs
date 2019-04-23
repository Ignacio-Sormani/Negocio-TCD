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
    public partial class frmVentas : Form
    {
        CONTROLADORA.cVENTAS cVENTAS;
        public frmVentas()
        {
            InitializeComponent();

            cVENTAS = CONTROLADORA.cVENTAS.obtener_instancia();
                //ARMAR_GRILLA();
        }

        public void ARMAR_GRILLA()
        {
            dgvVENTAS.DataSource = null;
            //dgvVENTAS.DataSource = cVENTAS.obtener_ventas(txtCLIENTE.Text);
        }

        private void txtCLIENTE_TextChanged(object sender, EventArgs e)
        {
            if (txtCLIENTE.TextLength > 3)
                ARMAR_GRILLA();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmVenta formVenta = new frmVenta(new MODELO.VENTA(), "A");
            DialogResult dr = formVenta.ShowDialog();
            if (dr == DialogResult.OK)
                ARMAR_GRILLA();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvVENTAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una venta para consultar.");
                return;
            }
            MODELO.VENTA oVENTA = cVENTAS.obtener_venta(Convert.ToInt32(dgvVENTAS.CurrentRow.Cells[0].Value));
            frmVenta formVenta = new frmVenta(oVENTA, "C");
            formVenta.ShowDialog();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
