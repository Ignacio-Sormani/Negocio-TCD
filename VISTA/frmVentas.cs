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
    [MODELO.accion(control = "btnDARDEBAJA", descripcion = "Dar de Daja Venta", formulario = "frmVentas", modulo = "Ventas")]
    public partial class frmVentas : Form
    {
        CONTROLADORA.cVENTAS cVENTAS;
        public frmVentas(MODELO.USUARIO oUsuario)
        {
            InitializeComponent();

            cVENTAS = CONTROLADORA.cVENTAS.obtener_instancia();
            btnAGREGAR.Enabled = oUsuario.validar_acciones("btnAGREGAR", "frmVentas");
            btnCONSULTAR.Enabled = oUsuario.validar_acciones("btnCONSULTAR", "frmVentas");
            btnDARDEBAJA.Enabled = oUsuario.validar_acciones("btnDARDEBAJA", "frmVentas");
            armar_grilla(true);
        }
        public void armar_grilla(bool b = false)
        {
            dgvVENTAS.DataSource = null;
            if (b)
            {
                dgvVENTAS.DataSource = cVENTAS.obtener_ventas_todas();
            }
            else
            {
                //pasar todos los params
                //dgvVENTAS.DataSource = cVENTAS.obtener_ventas(txtCLIENTE.Text);
            }
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            armar_grilla();
        }

        private void btnTODAS_Click(object sender, EventArgs e)
        {
            armar_grilla(true);
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmVenta formVenta = new frmVenta(new MODELO.VENTA(), "A");
            DialogResult dr = formVenta.ShowDialog();
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
            frmVenta2 formVenta = new frmVenta2(oVENTA, "C");
            formVenta.ShowDialog();

        }

        private void btnDARDEBAJA_Click(object sender, EventArgs e)
        {
            if (dgvVENTAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una venta para dar de baja.");
                return;
            }
            MODELO.VENTA oVENTA = cVENTAS.obtener_venta(Convert.ToInt32(dgvVENTAS.CurrentRow.Cells[0].Value));
            if (!oVENTA.estado)
            {
                MessageBox.Show("La venta seleccionada ya esta dada de baja");
                return;
            }
            oVENTA.estado = false;
            cVENTAS.modificar_venta(oVENTA);
            armar_grilla();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
