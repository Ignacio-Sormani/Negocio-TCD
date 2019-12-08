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
    public partial class frmPago : Form
    {
        MODELO.PAGO oPago;
        MODELO.FORMAPAGO oFormaPago;
        CONTROLADORA.cPAGOS cPAGOS;
        public frmPago(MODELO.PAGO miPago)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            oPago = miPago;
            cPAGOS = CONTROLADORA.cPAGOS.obtener_instancia();
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            armar_combobox_forma_pago();
            armar_combobox_cantidad_cuotas();
            txtPRECIOCUOTA.Enabled = false;
            txtTOTALFINAL.Enabled = false;
            btnGUARDAR.Enabled = false;
        }

        public void armar_combobox_forma_pago()
        {
            cmbFORMADEPAGO.Items.Add("EFECTIVO");
            cmbFORMADEPAGO.Items.Add("DEBITO");
            cmbFORMADEPAGO.Items.Add("CREDITO");
            cmbFORMADEPAGO.SelectedItem = "EFECTIVO";
        }

        public void armar_combobox_cantidad_cuotas()
        {
            cmbCANTIDADCUOTAS.Items.Add("1");
            cmbCANTIDADCUOTAS.Items.Add("3");
            cmbCANTIDADCUOTAS.Items.Add("6");
            cmbCANTIDADCUOTAS.Items.Add("12");
            cmbCANTIDADCUOTAS.SelectedItem = "1";
        }

        public void calcular_precio()
        {
            decimal total;
            if (!decimal.TryParse(txtTOTAL.Text, out total))
            {
                btnGUARDAR.Enabled = false;
                return;
            }
            switch (cmbFORMADEPAGO.SelectedItem.ToString())
            {
                case "EFECTIVO":
                    oFormaPago = new MODELO.EFECTIVO();
                    break;
                case "DEBITO":
                    oFormaPago = new MODELO.DEBITO();
                    break;
                case "CREDITO":
                    oFormaPago = new MODELO.CREDITO();
                    break;
                default:
                    break;
            }
            oPago.formaPago = oFormaPago;
            oPago.cantidadCuotas = Int32.Parse(cmbCANTIDADCUOTAS.SelectedItem.ToString());
            oPago.total = total;
            oPago.calcular_totales();
            txtPRECIOCUOTA.Text = oPago.precioCuota.ToString();
            txtTOTALFINAL.Text = oPago.totalFinal.ToString();
            btnGUARDAR.Enabled = true;

        }

        private void cmbFORMADEPAGO_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbFORMADEPAGO.SelectedItem.ToString() == "CREDITO")
            {
                cmbCANTIDADCUOTAS.Enabled = true;
            }
            else
            {
                cmbCANTIDADCUOTAS.SelectedItem = "1";
                cmbCANTIDADCUOTAS.Enabled = false;
            }
            calcular_precio();
        }

        private void txtTOTAL_TextChanged(object sender, EventArgs e)
        {
            calcular_precio();
        }

        private void cmbCANTIDADCUOTAS_SelectedValueChanged(object sender, EventArgs e)
        {
            calcular_precio();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            cPAGOS.agregar_pago(oPago);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
