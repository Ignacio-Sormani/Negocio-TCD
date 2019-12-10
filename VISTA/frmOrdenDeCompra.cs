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
    public partial class frmOrdenDeCompra : Form
    {
        CONTROLADORA.cORDENESDECOMPRA cORDENES;
        CONTROLADORA.cITEMS cITEMS;
        MODELO.ORDENDECOMPRA oORDEN;
        MODELO.PRODUCTO oProducto;
        MODELO.ITEMOC oITEM;
        string ACCION;
        public frmOrdenDeCompra(MODELO.ORDENDECOMPRA miORDEN, string miACCION)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            cORDENES = CONTROLADORA.cORDENESDECOMPRA.obtener_instancia();
            cITEMS = CONTROLADORA.cITEMS.obtener_instancia();
            oORDEN = miORDEN;
            ACCION = miACCION;
        }

        private void frmOrdenDeCompra_Load(object sender, EventArgs e)
        {
            pPRODUCTO.Enabled = false;
            txtTOTALPRODUCTOS.Enabled = false;
            dtpFECHAPEDIDO.Format = DateTimePickerFormat.Custom;
            dtpFECHAPEDIDO.CustomFormat = "MM/dd/yyyy";
            dtpFECHAENTREGA.Format = DateTimePickerFormat.Custom;
            dtpFECHAENTREGA.CustomFormat = "MM/dd/yyyy";
            if (ACCION == "C")
            {
                pPRODUCTO.Visible = false;
                dtpFECHAPEDIDO.Enabled = false;
                dtpFECHAPEDIDO.Value = oORDEN.fechaPedido;
                dtpFECHAENTREGA.Enabled = false;
                dtpFECHAENTREGA.Value = oORDEN.fechaEntrega;
                lblPROVEEDORNOMBRE.Text = oORDEN.proveedor.ToString();
                lblPROVEEDORNOMBRE.Enabled = false;
                btnPROVEEDOR.Visible = false;
                txtTOTALPRODUCTOS.Text = oORDEN.totalPedido.ToString();
                armar_grilla_productos();
                btnCANCELAR.Text = "Cerrar";
                btnGUARDAR.Visible = false;
                btnBUSCARPRODUCTO.Visible = false;
                btnCONFIRMARPRODUCTO.Visible = false;
                btnELIMINARPRODUCTO.Visible = false;
            }
            else
            {
                dtpFECHAPEDIDO.Visible = false;
                lblFECHAPEDIDO.Visible = false;
                dtpFECHAENTREGA.Value = System.DateTime.Now;
            }
        }

        public void armar_grilla_productos()
        {
            dgvPRODUCTOS.DataSource = null;
            dgvPRODUCTOS.DataSource = oORDEN.itemsoc.ToList();

            dgvPRODUCTOS.Columns["ordenCompra"].Visible = false;
            dgvPRODUCTOS.Columns["codigoItem"].Visible = false;
            dgvPRODUCTOS.Columns["producto"].DisplayIndex = 0;
            dgvPRODUCTOS.Columns["producto"].HeaderText = "Producto";
            dgvPRODUCTOS.Columns["cantidad"].DisplayIndex = 1;
            dgvPRODUCTOS.Columns["cantidad"].HeaderText = "Cantidad";
            dgvPRODUCTOS.Columns["precioUnitarioPresupuesto"].DisplayIndex = 2;
            dgvPRODUCTOS.Columns["precioUnitarioPresupuesto"].HeaderText = "PrecioUnitario";
            dgvPRODUCTOS.Columns["subtotal"].DisplayIndex = 3;
            dgvPRODUCTOS.Columns["subtotal"].HeaderText = "Subtotal";
        }

        public decimal calcular_total_productos()
        {
            decimal total = 0;
            foreach (MODELO.ITEMOC producto in oORDEN.itemsoc.ToList())
            {
                total += producto.subtotal;
            }
            return total;
        }

        private void btnPROVEEDOR_Click(object sender, EventArgs e)
        {
            frmProveedores frmProveedores = new frmProveedores(oORDEN);
            frmProveedores.ShowDialog();
            if (oORDEN.proveedor != null)
            {
                lblPROVEEDORNOMBRE.Text = oORDEN.proveedor.ToString();
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
            decimal precioUnitario;
            if (!decimal.TryParse(txtPRECIOUNITARIO.Text, out precioUnitario))
            {
                MessageBox.Show("El precio unitario debe ser numerico");
                return;
            }
            bool b = false;
            foreach (var item in oORDEN.itemsoc.ToList())
            {
                if (item.producto == oProducto)
                {
                    if (item.precioUnitarioPresupuesto != precioUnitario)
                    {
                        MessageBox.Show("El precio unitario debe ser igual al del mismo producto ingresado en la orden de compra");
                        return;
                    }
                    b = true;
                    item.cantidad += (Int32)nudCANTIDADPRODUCTO.Value;
                    cITEMS.modificar_item_orden(item);
                }
            }
            if (!b)
            {
                oITEM = new MODELO.ITEMOC();
                oITEM.producto = oProducto;
                oITEM.cantidad = (Int32)nudCANTIDADPRODUCTO.Value;
                oITEM.precioUnitarioPresupuesto = precioUnitario;
                oORDEN.itemsoc.Add(oITEM);
                cITEMS.agregar_item_orden(oITEM);
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
            oORDEN.itemsoc.Remove((MODELO.ITEMOC)dgvPRODUCTOS.CurrentRow.DataBoundItem);
            txtTOTALPRODUCTOS.Text = calcular_total_productos().ToString();
            armar_grilla_productos();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (oORDEN.proveedor == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor");
                return;
            }
            if (oORDEN.itemsoc.Count < 0)
            {
                MessageBox.Show("Debe ingresar al menos un producto");
                return;
            }
            oORDEN.fechaPedido = System.DateTime.Now;
            if (dtpFECHAENTREGA.Value < oORDEN.fechaPedido)
            {
                MessageBox.Show("Debe ingresar una fecha de entrega futura");
                return;
            }
            oORDEN.fechaEntrega = dtpFECHAENTREGA.Value;
            oORDEN.totalPedido = decimal.Parse(txtTOTALPRODUCTOS.Text);
            oORDEN.estado = "Pedido Realizado";
            cORDENES.agregar_orden(oORDEN);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
