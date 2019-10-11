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
        MODELO.PRODUCTO oProducto;
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
            dtpFECHA.Format = DateTimePickerFormat.Custom;
            dtpFECHA.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            if (ACCION == "C")
            {
                pPRODUCTO.Visible = false;
                dtpFECHA.Enabled = false;
                dtpFECHA.Value = oVENTA.fecha;
                dtpFECHA.Enabled = false;
                lblCLIENTENOMBRE.Text = oVENTA.cliente.ToString();
                lblCLIENTENOMBRE.Enabled = false;
                btnCLIENTE.Visible = false;
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
                dtpFECHA.Visible = false;
                lblFECHA.Visible = false;
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
            frmProductos frmProductos = new frmProductos();
            frmProductos.ShowDialog();
            if (frmProductos.productoActual != null)
            {
                oProducto = frmProductos.productoActual;
                lblPRODUCTO.Text = oProducto.ToString();
                pPRODUCTO.Enabled = true;
                nudCANTIDADPRODUCTO.Value = 1;
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
            bool b = false;
            foreach (var item in oVENTA.itemsv.ToList())
            {
                if (item.producto == oProducto)
                {
                    b = true;
                    item.cantidad += (Int32)nudCANTIDADPRODUCTO.Value;
                    cITEMS.modificar_item_venta(item);
                }
            }
            if (!b)
            {
                oITEM = new MODELO.ITEMV();
                oITEM.producto = oProducto;
                oITEM.cantidad = (Int32)nudCANTIDADPRODUCTO.Value;
                oITEM.precioUnitarioVenta = oITEM.producto.precio;
                oVENTA.itemsv.Add(oITEM);
                cITEMS.agregar_item_venta(oITEM);
            }
            armar_grilla_productos();
            txtTOTALPRODUCTOS.Text = calcular_total_productos().ToString();
            pPRODUCTO.Enabled = false;
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
            if (oVENTA.cliente == null)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return;
            }
            if (oVENTA.itemsv.Count < 0)
            {
                MessageBox.Show("Debe ingresar al menos un producto");
                return;
            }
            if (oVENTA.pagos.Count < 0)
            {
                MessageBox.Show("Debe ingresar al menos un pago");
                return;
            }            
            oVENTA.fecha = System.DateTime.Now;
            oVENTA.precioTotal = decimal.Parse(txtTOTALPRODUCTOS.Text);
            oVENTA.pagoTotal = decimal.Parse(txtTOTALPAGOS.Text);
            if (oVENTA.precioTotal != oVENTA.pagoTotal)
            {
                MessageBox.Show("Debe ingresar un pago igual al total");
                return;
            }
            cVENTAS.agregar_venta(oVENTA);
            //falta disminuir el stock
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
