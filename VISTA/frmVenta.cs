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
    public partial class frmVenta : Form
    {
        CONTROLADORA.cVENTAS cVENTAS;
        MODELO.VENTA oVENTA;
        string ACCION;
        public frmVenta(MODELO.VENTA miVENTA, string miACCION)
        {
            InitializeComponent();

            cVENTAS = CONTROLADORA.cVENTAS.obtener_instancia();
            oVENTA = miVENTA;
            ACCION = miACCION;            
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            pPRODUCTO.Enabled = false;
            if (ACCION == "C")
            {
                dtpFECHA.Value = oVENTA.fecha;
                dtpFECHA.Enabled = false;
                txtCLIENTE.Text = oVENTA.cliente.ToString();
                txtCLIENTE.Enabled = false;
                txtTOTALPRODUCTOS.Text = oVENTA.total.ToString();
                txtTOTALPRODUCTOS.Enabled = false;
                txtTOTALPAGOS.Text = calcular_total_pagos().ToString();
                txtTOTALPAGOS.Enabled = false;
                armar_grilla_productos();
                armar_grilla_pagos();
                btnCANCELAR.Text = "Cerrar";
                btnGUARDAR.Visible = false;
                btnAGREGARPAGO.Visible = false;
                btnMODIFICARPAGO.Visible = false;
                btnELIMINARPAGO.Visible = false;
                btnBUSCARPRODUCTO.Visible = false;
                btnCONFIRMARPRODUCTO.Visible = false;
                btnELIMINARPRODUCTO.Visible = false;
                btnMODIFICARPRODUCTO.Visible = false;
            }
            else
            {                
                dtpFECHA.Value = System.DateTime.Now;
            }
        }

        public void armar_grilla_productos()
        {
            dgvPRODUCTOS.DataSource = null;
            dgvPRODUCTOS.DataSource = oVENTA.itemsv; //confirmar esto
        }
        public void armar_grilla_pagos()
        {
            dgvPAGOS.DataSource = null;
            dgvPAGOS.DataSource = oVENTA.pagos; //confirmar esto
        }

        public decimal calcular_total_productos()//confirmar esto
        {
            decimal total = 0;
            foreach (MODELO.ITEMV producto in oVENTA.itemsv)
            {
                total += producto.subtotal;
            }
            return 0;
        }
        public decimal calcular_total_pagos()//confirmar esto
        {
            decimal total = 0;
            foreach (MODELO.PAGO pago in oVENTA.pagos)
            {
                total += pago.total;
            }
            return 0;
        }        
    }
}
