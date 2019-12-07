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
        MODELO.REMITODECOMPRA oREMITO;
        string ACCION;
        public frmRemito(MODELO.REMITODECOMPRA miREMITO, string miACCION)
        {
            InitializeComponent();
            cREMITOSDECOMPRA = CONTROLADORA.cREMITOSDECOMPRA.obtener_instancia();
            cITEMS = CONTROLADORA.cITEMS.obtener_instancia();

            oREMITO = miREMITO;
            ACCION = miACCION;
        }

        private void frmRemito_Load(object sender, EventArgs e)
        {
            if (ACCION == "C")
            {
                cargar_orden();
                btnCANCELAR.Text = "Cerrar";
            }
            else
            {
                lblNOMBREPROVEEDOR.Text = "";
            }
            pPRODUCTO.Enabled = false;
            btnGUARDAR.Enabled = false;
            desactivar_controles();
        }

        private void btnORDEN_Click(object sender, EventArgs e)
        {
            //frmOrdenesDeCompra frmOrdenesDeCompra = new frmOrdenesDeCompra(oREMITO);
            //frmOrdenesDeCompra.ShowDialog();
            //if (oREMITO.ordenCompra != null)
            //{
            //    lblORDEN.Text = oREMITO.ordenCompra.ToString();
            //}
            //cargar_orden();
            //panREMITO.Enabled = true;
            //btnGUARDAR.Enabled = true;
        }

        public void cargar_orden()
        {
            if (ACCION == "C")
            {
                dtpFECHAENTREGA.Value = oREMITO.fechaRecibida;
                lblPROVEEDOR.Text = oREMITO.proveedor.ToString();
            }
            else
            {
                dtpFECHAENTREGA.Value = oREMITO.ordenCompra.fechaEntrega;
                lblPROVEEDOR.Text = oREMITO.ordenCompra.proveedor.ToString();
                foreach (MODELO.ITEMOC item in oREMITO.ordenCompra.itemsoc.ToList())
                {
                    MODELO.ITEMRC oITEM = new MODELO.ITEMRC();
                }
            }
            armar_grilla();
        }

        public void armar_grilla()
        {
            dgvPRODUCTOS.DataSource = null;
            dgvPRODUCTOS.DataSource = oREMITO.itemsrc.ToList();
        }

        public void desactivar_controles()
        {
            dtpFECHAENTREGA.Enabled = false;
            btnELIMINARPRODUCTO.Enabled = false;
            btnMODIFICARPRODUCTO.Enabled = false;
            txtTOTALPRODUCTOS.Enabled = false;
            dgvPRODUCTOS.Enabled = false;
        }

        public void activar_controles()
        {
            dtpFECHAENTREGA.Enabled = true;
            btnELIMINARPRODUCTO.Enabled = true;
            btnMODIFICARPRODUCTO.Enabled = true;
            txtTOTALPRODUCTOS.Enabled = true;
            dgvPRODUCTOS.Enabled = true;
        }



        /*
        public bool validar_estado(MODELO.ORDENDECOMPRA oORDEN)
        {
            bool a = true;
            foreach (MODELO.ITEMRC item in cREMITOSDECOMPRA.calcular_items_faltantes(oORDEN))
            {
                if (item.cantidad != 0)
                {
                    a = false;
                }
            }
            return a;
        }*/
    }
}
