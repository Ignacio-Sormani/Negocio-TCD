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
    public partial class frmRemito : Form
    {
        CONTROLADORA.cREMITOSDECOMPRA cREMITOSDECOMPRA;
        CONTROLADORA.cITEMS cITEMS;
        CONTROLADORA.cORDENESDECOMPRA cORDENESDECOMPRA;
        MODELO.REMITODECOMPRA oREMITO;
        MODELO.ITEMRC oITEM;
        string ACCION;
        public frmRemito(MODELO.REMITODECOMPRA miREMITO, string miACCION)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            cREMITOSDECOMPRA = CONTROLADORA.cREMITOSDECOMPRA.obtener_instancia();
            cITEMS = CONTROLADORA.cITEMS.obtener_instancia();
            cORDENESDECOMPRA = CONTROLADORA.cORDENESDECOMPRA.obtener_instancia();
            oREMITO = miREMITO;
            ACCION = miACCION;
        }

        private void frmRemito_Load(object sender, EventArgs e)
        {
            if (ACCION == "C")
            {
                cargar_orden();
                btnCANCELAR.Text = "Cerrar";
                btnORDEN.Visible = false;
            }
            else
            {
                lblNOMBREPROVEEDOR.Text = "";
            }
            pPRODUCTO.Enabled = false;
            btnGUARDAR.Enabled = false;
            dtpFECHAENTREGA.Enabled = false;
            txtTOTALPRODUCTOS.Enabled = false;
            desactivar_controles();
        }

        private void btnORDEN_Click(object sender, EventArgs e)
        {
            frmOrdenesDeCompra frmOrdenesDeCompra = new frmOrdenesDeCompra(oREMITO);
            frmOrdenesDeCompra.ShowDialog();
            if (oREMITO.ordenCompra != null)
            {
                lblORDENSELECCIONADA.Text = oREMITO.ordenCompra.ToString();
            }
            cargar_orden();
            activar_controles();
            btnGUARDAR.Enabled = true;
            btnORDEN.Visible = false;
        }

        public void cargar_orden()
        {
            if (ACCION == "C")
            {
                dtpFECHAENTREGA.Value = oREMITO.fechaRecibida;
                lblPROVEEDOR.Text = oREMITO.proveedor.ToString();
                lblORDENSELECCIONADA.Text = oREMITO.ordenCompra.ToString();
            }
            else
            {
                dtpFECHAENTREGA.Value = System.DateTime.Today;
                oREMITO.proveedor = oREMITO.ordenCompra.proveedor;
                lblNOMBREPROVEEDOR.Text = oREMITO.ordenCompra.proveedor.ToString();               
                foreach (MODELO.ITEMRC item in cREMITOSDECOMPRA.calcular_items_faltantes(oREMITO.ordenCompra))
                {
                    MODELO.ITEMRC oITEM = new MODELO.ITEMRC();
                    oITEM = item;
                    oREMITO.itemsrc.Add(oITEM);
                }
            }
            armar_grilla_productos();
            calular_total_productos();
        }

        public void armar_grilla_productos()
        {
            dgvPRODUCTOS.DataSource = null;
            dgvPRODUCTOS.DataSource = oREMITO.itemsrc.ToList();

            dgvPRODUCTOS.Columns["remitoCompra"].Visible = false;
            dgvPRODUCTOS.Columns["codigoItem"].Visible = false;
            dgvPRODUCTOS.Columns["producto"].DisplayIndex = 0;
            dgvPRODUCTOS.Columns["producto"].HeaderText = "Producto";
            dgvPRODUCTOS.Columns["cantidad"].DisplayIndex = 1;
            dgvPRODUCTOS.Columns["cantidad"].HeaderText = "Cantidad";
            dgvPRODUCTOS.Columns["precioUnitarioCompra"].DisplayIndex = 2;
            dgvPRODUCTOS.Columns["precioUnitarioCompra"].HeaderText = "PrecioUnitario";
            dgvPRODUCTOS.Columns["subtotal"].DisplayIndex = 3;
            dgvPRODUCTOS.Columns["subtotal"].HeaderText = "Subtotal";
        }

        public void calular_total_productos()
        {
            decimal total = 0;
            foreach (MODELO.ITEMRC producto in oREMITO.itemsrc.ToList())
            {
                total += producto.subtotal;
            }
            txtTOTALPRODUCTOS.Text = total.ToString();
            oREMITO.total = total;
        }

        public void desactivar_controles()
        {
            btnELIMINARPRODUCTO.Enabled = false;
            btnMODIFICARPRODUCTO.Enabled = false;
            dgvPRODUCTOS.Enabled = false;
        }

        public void activar_controles()
        {
            btnELIMINARPRODUCTO.Enabled = true;
            btnMODIFICARPRODUCTO.Enabled = true;
            dgvPRODUCTOS.Enabled = true;
        }

        private void btnMODIFICARPRODUCTO_Click(object sender, EventArgs e)
        {
            if (dgvPRODUCTOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un item para modificar.");
                return;
            }
            oITEM = (MODELO.ITEMRC)dgvPRODUCTOS.CurrentRow.DataBoundItem;
            lblPRODUCTO.Text = oITEM.producto.ToString();
            nudCANTIDADPRODUCTO.Value = oITEM.cantidad;
            nudCANTIDADPRODUCTO.Maximum = oITEM.cantidad;
            txtPRECIOUNITARIO.Text = oITEM.precioUnitarioCompra.ToString();
            pPRODUCTO.Enabled = true;
        }
        private void btnELIMINARPRODUCTO_Click(object sender, EventArgs e)
        {
            if (dgvPRODUCTOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un item para eliminar.");
                return;
            }
            oITEM = (MODELO.ITEMRC)dgvPRODUCTOS.CurrentRow.DataBoundItem;
            oREMITO.itemsrc.Remove(oITEM);
            armar_grilla_productos();
            calular_total_productos();
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
            oITEM.cantidad = (Int32)nudCANTIDADPRODUCTO.Value;
            oITEM.precioUnitarioCompra = precioUnitario;
            armar_grilla_productos();
            calular_total_productos();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (oREMITO.itemsrc.Count <= 0)
            {
                MessageBox.Show("Debe ingresar al menos un producto.");
                return;
            }
            oREMITO.fechaEntrega = oREMITO.ordenCompra.fechaEntrega;
            oREMITO.fechaRecibida = System.DateTime.Today;            
            cREMITOSDECOMPRA.agregar_remito(oREMITO);
            List<MODELO.ITEMRC> lista = (List<MODELO.ITEMRC>)cREMITOSDECOMPRA.calcular_items_faltantes(oREMITO.ordenCompra);
            if (lista.Count() == 0)
            {
                oREMITO.ordenCompra.estado = "Pedido Entregado";
            }
            else
            {
                oREMITO.ordenCompra.estado = "Pedido Entregado Incompleto";
            }
            cORDENESDECOMPRA.modificar_orden(oREMITO.ordenCompra);

            // falta disminuir stock
            this.DialogResult = DialogResult.OK;
        }


        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
