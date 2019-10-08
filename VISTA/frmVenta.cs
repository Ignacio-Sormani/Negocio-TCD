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
        CONTROLADORA.cPAGOS cPAGOS;
        CONTROLADORA.cITEMS cITEMS;
        MODELO.VENTA oVENTA;
        MODELO.PAGO oPago;
        MODELO.ITEMV oITEM;
        string ACCION;
        public frmVenta(MODELO.VENTA miVENTA, string miACCION)
        {
            InitializeComponent();

            cVENTAS = CONTROLADORA.cVENTAS.obtener_instancia();
            cPAGOS = CONTROLADORA.cPAGOS.obtener_instancia();
            cITEMS = CONTROLADORA.cITEMS.obtener_instancia();
            oVENTA = miVENTA;
            ACCION = miACCION;            
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            pPRODUCTO.Enabled = false;
            txtTOTALPAGOS.Enabled = false;
            txtTOTALPRODUCTOS.Enabled = false;
            if (ACCION == "C")
            {
                dtpFECHA.Value = oVENTA.fecha;
                dtpFECHA.Enabled = false;
                lblCLIENTENOMBRE.Text = oVENTA.cliente.ToString();
                lblCLIENTENOMBRE.Enabled = false;
                txtTOTALPRODUCTOS.Text = oVENTA.precioTotal.ToString();
                lblTOTALPAGOS.Text = calcular_total_pagos().ToString();
                armar_grilla_productos();
                armar_grilla_pagos();
                btnCANCELAR.Text = "Cerrar";
                btnGUARDAR.Visible = false;
                btnAGREGARPAGO.Visible = false;
                btnELIMINARPAGO.Visible = false;
                btnBUSCARPRODUCTO.Visible = false;
                btnCONFIRMARPRODUCTO.Visible = false;
                btnELIMINARPRODUCTO.Visible = false;
            }
            else
            {                
                dtpFECHA.Value = System.DateTime.Now;
            }
        }

        public void armar_grilla_productos()
        {
            dgvPRODUCTOS.DataSource = null;
            dgvPRODUCTOS.DataSource = oVENTA.itemsv.ToList();
        }
        public void armar_grilla_pagos()
        {
            dgvPAGOS.DataSource = null;
            dgvPAGOS.DataSource = oVENTA.pagos.ToList();
        }

        public decimal calcular_total_productos()
        {
            decimal total = 0;
            foreach (MODELO.ITEMV producto in oVENTA.itemsv.ToList())
            {
                total += producto.subtotal;
            }
            return total;
        }
        public decimal calcular_total_pagos()
        {
            decimal total = 0;
            foreach (MODELO.PAGO pago in oVENTA.pagos.ToList())
            {
                total += pago.total;
            }
            return total;
        }

        private void btnCLIENTE_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes(oVENTA);
            frmClientes.ShowDialog();
            if (oVENTA.cliente != null)
            {
                lblCLIENTE.Text = oVENTA.cliente.ToString();
            }
        }

        private void btnBUSCARPRODUCTO_Click(object sender, EventArgs e)
        {
            oITEM = new MODELO.ITEMV();
            frmProductos frmProductos = new frmProductos();
            frmProductos.ShowDialog();
            if (frmProductos.productoActual != null)
            {
                oITEM.producto = frmProductos.productoActual;
                lblPRODUCTO.Text = oITEM.producto.ToString();
                pPRODUCTO.Enabled = true;                
            }
            else
            {
                lblPRODUCTO.Text = "Nombre Producto";
                pPRODUCTO.Enabled = false;
            }
        }

        private void btnCONFIRMARPRODUCTO_Click(object sender, EventArgs e)
        {
            if (nudCANTIDADPRODUCTO.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0");
                return;
            }
            oITEM.cantidad = (Int32)nudCANTIDADPRODUCTO.Value;
            oITEM.precioUnitarioVenta = oITEM.producto.precio;
            oITEM.calcularSubtotal();
            cITEMS.agregar_item(oITEM);
            oVENTA.itemsv.Add(oITEM);
            armar_grilla_productos();
            txtTOTALPRODUCTOS.Text = calcular_total_productos().ToString();
        }

        private void btnELIMINARPRODUCTO_Click(object sender, EventArgs e)
        {
            if (dgvPRODUCTOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un item de la lista");
                return;
            }
            oVENTA.itemsv.Remove((MODELO.ITEMV)dgvPRODUCTOS.CurrentRow.DataBoundItem);
            txtTOTALPRODUCTOS.Text = calcular_total_productos().ToString();
            armar_grilla_productos();
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

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            oVENTA.fecha = dtpFECHA.Value;
            cVENTAS.agregar_venta(oVENTA);
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        
    }
}
