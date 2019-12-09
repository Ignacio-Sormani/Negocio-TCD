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
    public partial class frmPagos : Form
    {
        CONTROLADORA.cPAGOS cPAGOS;
        MODELO.VENTA oVENTA;
        MODELO.PAGO oPago;
        string ACCION;
        public frmPagos(MODELO.VENTA miVENTA, string miACCION)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            cPAGOS = CONTROLADORA.cPAGOS.obtener_instancia();
            oVENTA = miVENTA;
            ACCION = miACCION;
        }
        private void frmPagos_Load(object sender, EventArgs e)
        {
            if (ACCION == "C")
            {
                btnAGREGARPAGO.Visible = false;
                btnELIMINARPAGO.Visible = false;
                txtTOTALPAGOS.Enabled = false;
            }
            armar_grilla_pagos();
            calcular_total_pagos();
        }

        public void armar_grilla_pagos()
        {
            dgvPAGOS.DataSource = null;
            dgvPAGOS.DataSource = oVENTA.pagos.ToList();

            dgvPAGOS.Columns["venta"].Visible = false;
            dgvPAGOS.Columns["codigoPago"].Visible = false;
            dgvPAGOS.Columns["formaPago"].DisplayIndex = 0;
            dgvPAGOS.Columns["formaPago"].HeaderText = "Forma Pago";
            dgvPAGOS.Columns["cantidadCuotas"].DisplayIndex = 1;
            dgvPAGOS.Columns["cantidadCuotas"].HeaderText = "Cuotas";
            dgvPAGOS.Columns["precioCuota"].DisplayIndex = 2;
            dgvPAGOS.Columns["precioCuota"].HeaderText = "Precio Cuota";
            dgvPAGOS.Columns["totalFinal"].DisplayIndex = 3;
            dgvPAGOS.Columns["totalFinal"].HeaderText = "Total Final";
            dgvPAGOS.Columns["total"].DisplayIndex = 4;
            dgvPAGOS.Columns["total"].HeaderText = "Total";
        }

        public decimal calcular_total_pagos()
        {
            decimal total = 0;
            foreach (MODELO.PAGO pago in oVENTA.pagos.ToList())
            {
                total += pago.total;
            }
            txtTOTALPAGOS.Text = total.ToString();
            return total;
        }

        private void btnAGREGARPAGO_Click(object sender, EventArgs e)
        {
            oPago = new MODELO.PAGO();
            frmPago frmPago = new frmPago(oPago);
            if (DialogResult.OK == frmPago.ShowDialog())
            {
                oVENTA.pagos.Add(oPago);
                armar_grilla_pagos();
                txtTOTALPAGOS.Text = calcular_total_pagos().ToString();
            }
            oVENTA.pagoTotal = decimal.Parse(txtTOTALPAGOS.Text);
        }

        private void btnELIMINARPAGO_Click(object sender, EventArgs e)
        {
            if (dgvPAGOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un pago de la lista");
                return;
            }
            oVENTA.pagos.Remove((MODELO.PAGO)dgvPAGOS.CurrentRow.DataBoundItem);
            txtTOTALPAGOS.Text = calcular_total_pagos().ToString();
            armar_grilla_pagos();
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
