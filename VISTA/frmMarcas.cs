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
    [MODELO.formulario(nombre = "frmMarcas", gestion = "gestionarMarcas", descripcion = "Gestionar Marcas", modulo = "Gestiones")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Marca", formulario = "frmMarcas", modulo = "Gestiones")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Marca", formulario = "frmMarcas", modulo = "Gestiones")]
    [MODELO.accion(control = "btnMODIFICAR", descripcion = "Modificar Marca", formulario = "frmMarcas", modulo = "Gestiones")]
    public partial class frmMarcas : Form
    {
        CONTROLADORA.cMARCAS cMARCAS;
        public frmMarcas(MODELO.USUARIO oUsuario)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            cMARCAS = CONTROLADORA.cMARCAS.obtener_instancia();
            btnSELECCIONAR.Visible = false;
            btnAGREGAR.Enabled = oUsuario.validar_acciones("btnAGREGAR", "frmMarcas");
            btnCONSULTAR.Enabled = oUsuario.validar_acciones("btnCONSULTAR", "frmMarcas");
            btnMODIFICAR.Enabled = oUsuario.validar_acciones("btnMODIFICAR", "frmMarcas");
            armar_grilla();
        }

        MODELO.PRODUCTO oProducto;
        public frmMarcas(MODELO.PRODUCTO miProducto) {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            oProducto = miProducto;
            cMARCAS = CONTROLADORA.cMARCAS.obtener_instancia();
            btnSELECCIONAR.Visible = true;
            armar_grilla();
        }

        private void armar_grilla()
        {
            dgvMARCAS.DataSource = null;
            dgvMARCAS.DataSource = cMARCAS.obtener_marcas(txtBUSCAR.Text);
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            armar_grilla();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmMarca frmMarca = new frmMarca(new MODELO.MARCA(), "A");
            DialogResult dr = frmMarca.ShowDialog();
            if (dr == DialogResult.OK)
                armar_grilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMARCAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una marca de la lista");
                return;
            }
            frmMarca frmMarca = new frmMarca(cMARCAS.obtener_marca(Convert.ToInt32(dgvMARCAS.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = frmMarca.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                armar_grilla();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvMARCAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una marca de la lista");
                return;
            }
            frmMarca frmMarca = new frmMarca(cMARCAS.obtener_marca(Convert.ToInt32(dgvMARCAS.CurrentRow.Cells[0].Value)), "C");
            frmMarca.ShowDialog();
        }

        private void btnSELECCIONAR_Click(object sender, EventArgs e)
        {
            if (dgvMARCAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una marca de la lista");
                return;
            }
 
            oProducto.marca = cMARCAS.obtener_marca(Convert.ToInt32(dgvMARCAS.CurrentRow.Cells[0].Value));
            this.Close();
        }

        private void btnTODAS_Click(object sender, EventArgs e)
        {
            txtBUSCAR.Text = "";
            armar_grilla();
        }
    }
}
