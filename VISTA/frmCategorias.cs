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
    [MODELO.formulario(nombre = "frmCategorias", gestion = "gestionarCategorias", descripcion = "Gestionar Categorias", modulo = "Gestiones")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Categoria", formulario = "frmCategorias", modulo = "Gestiones")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Categoria", formulario = "frmCategorias", modulo = "Gestiones")]
    [MODELO.accion(control = "btnMODIFICAR", descripcion = "Modificar Categoria", formulario = "frmCategorias", modulo = "Gestiones")]
    public partial class frmCategorias : Form
    {
        CONTROLADORA.cCATEGORIAS cCATEGORIAS;
        public frmCategorias(MODELO.USUARIO oUsuario)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            cCATEGORIAS = CONTROLADORA.cCATEGORIAS.obtener_instancia();
            btnSELECCIONAR.Visible = false;
            btnAGREGAR.Enabled = oUsuario.validar_acciones("btnAGREGAR", "frmCategorias");
            btnCONSULTAR.Enabled = oUsuario.validar_acciones("btnCONSULTAR", "frmCategorias");
            btnMODIFICAR.Enabled = oUsuario.validar_acciones("btnMODIFICAR", "frmCategorias");
            armar_grilla();
        }

        MODELO.PRODUCTO oProducto;
        public frmCategorias(MODELO.PRODUCTO miProducto)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            oProducto = miProducto;
            cCATEGORIAS = CONTROLADORA.cCATEGORIAS.obtener_instancia();
            btnSELECCIONAR.Visible = true;
            armar_grilla();
        }

        private void armar_grilla()
        {
            dgvCATEGORIAS.DataSource = null;
            dgvCATEGORIAS.DataSource = cCATEGORIAS.obtener_categorias(txtBUSCAR.Text);
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
            frmCategoria frmCategoria = new frmCategoria(new MODELO.CATEGORIA(), "A");
            DialogResult dr = frmCategoria.ShowDialog();
            if (dr == DialogResult.OK)
                armar_grilla();
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvCATEGORIAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una categoria de la lista");
                return;
            }
            frmCategoria frmCategoria = new frmCategoria(cCATEGORIAS.obtener_categoria(Convert.ToInt32(dgvCATEGORIAS.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = frmCategoria.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                armar_grilla();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvCATEGORIAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una categoria de la lista");
                return;
            }
            frmCategoria frmCategoria = new frmCategoria(cCATEGORIAS.obtener_categoria(Convert.ToInt32(dgvCATEGORIAS.CurrentRow.Cells[0].Value)), "C");
            frmCategoria.ShowDialog();
        }

        private void btnSELECCIONAR_Click(object sender, EventArgs e)
        {
            if (dgvCATEGORIAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una categoria de la lista");
                return;
            }
            oProducto.categoria = cCATEGORIAS.obtener_categoria(Convert.ToInt32(dgvCATEGORIAS.CurrentRow.Cells[0].Value));
            this.Close();
        }

        private void btnTODAS_Click(object sender, EventArgs e)
        {
            txtBUSCAR.Text = "";
            armar_grilla();
        }
    }
}
