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
    [MODELO.formulario(nombre = "frmProductos", descripcion = "Gestionar Productos", modulo = "Gestiones")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Producto", formulario = "frmProductos", modulo = "Gestiones")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Producto", formulario = "frmProductos", modulo = "Gestiones")]
    [MODELO.accion(control = "btnMODIFICAR", descripcion = "Modificar Producto", formulario = "frmProductos", modulo = "Gestiones")]
    public partial class frmProductos : Form
    {
        CONTROLADORA.cPRODUCTOS cPRODUCTOS;
        public frmProductos()
        {
            InitializeComponent();
            cPRODUCTOS = CONTROLADORA.cPRODUCTOS.obtener_instancia();
            armarGrilla();
            btnSELECCIONAR.Visible = false;
        }

        public void armarGrilla() {
            dgvPRODUCTOS.DataSource = null;
            dgvPRODUCTOS.DataSource = cPRODUCTOS.obtener_productos(txtBUSCAR.Text);
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmProducto frmProducto = new frmProducto(new MODELO.PRODUCTO(), "A");
            DialogResult dr = frmProducto.ShowDialog();
            if (dr == DialogResult.OK) {
                armarGrilla();
            }
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvPRODUCTOS.CurrentRow == null) {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }

            MODELO.PRODUCTO oProducto = cPRODUCTOS.obtener_producto(Convert.ToInt32(dgvPRODUCTOS.CurrentRow.Cells[0].Value));
            frmProducto frmProducto = new frmProducto(oProducto, "M");
            DialogResult dr = frmProducto.ShowDialog();
            if (dr == DialogResult.OK) {
                armarGrilla();
            }
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {

        }

        private void btnSELECCIONAR_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            armarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBUSCAR.Text = "";
            armarGrilla();
        }
    }
}
