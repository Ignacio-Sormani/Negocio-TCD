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
    [MODELO.formulario(nombre = "frmCategorias", descripcion = "Gestionar Categorias", modulo = "Gestiones")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Categoria", formulario = "frmCategorias", modulo = "Gestiones")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Categoria", formulario = "frmCategorias", modulo = "Gestiones")]
    [MODELO.accion(control = "btnMODIFICAR", descripcion = "Modificar Categoria", formulario = "frmCategorias", modulo = "Gestiones")]
    public partial class frmCategorias : Form
    {
        CONTROLADORA.cCATEGORIAS cCATEGORIAS;
        //agregar MODELO.USUARIO oUSUARIO en el parametro y boton seleccionar para el CU-buscar
        public frmCategorias()
        {
            InitializeComponent();

            cCATEGORIAS = CONTROLADORA.cCATEGORIAS.obtener_instancia();
            btnSELECCIONAR.Visible = false;
            armar_grilla();
        }

        #region FUNCIONES 
        private void armar_grilla()
        {
            dgvCATEGORIAS.DataSource = null;
            dgvCATEGORIAS.DataSource = cCATEGORIAS.obtener_categorias(txtBUSCAR.Text);
        }
        #endregion

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
                MessageBox.Show("Debe seleccionar una categoria de la lista", "Categorias - Atencion!");
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
                MessageBox.Show("Debe seleccionar una categoria de la lista", "Categorias - Atencion!");
                return;
            }
            frmCategoria frmCategoria = new frmCategoria(cCATEGORIAS.obtener_categoria(Convert.ToInt32(dgvCATEGORIAS.CurrentRow.Cells[0].Value)), "C");
            frmCategoria.ShowDialog();
        }
    }
}
