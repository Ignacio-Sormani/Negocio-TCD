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
    public partial class frmCategoria : Form
    {
        MODELO.CATEGORIA oCategoria;
        public string ACCION;
        CONTROLADORA.cCATEGORIAS cCATEGORIAS;
        public frmCategoria(MODELO.CATEGORIA miCategoria, string miAccion)
        {
            InitializeComponent();

            cCATEGORIAS = CONTROLADORA.cCATEGORIAS.obtener_instancia();
            oCategoria = miCategoria;
            ACCION = miAccion;
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            if (ACCION != "A")
            {
                txtCATEGORIA.Text = oCategoria.categoria;
            }

            if (ACCION == "C")
            {
                txtCATEGORIA.Enabled = false;
                btnCANCELAR.Text = "Cerrar";
                btnGUARDAR.Visible = false;
            }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCATEGORIA.Text))
            {
                MessageBox.Show("Debe ingresar un valor de categoria correcto", "Categoria - Atencion!");
                return;
            }
            if (!cCATEGORIAS.verificar_categoria_existente(txtCATEGORIA.Text)) //verificar este doble if
            {
                if (!(ACCION == "M" && oCategoria.categoria == txtCATEGORIA.Text))
                { 
                    MessageBox.Show("La categoria ingresada ya existe", "Categoria - Atencion!");
                    return;
                }
            }

            oCategoria.categoria = txtCATEGORIA.Text;
            if (ACCION == "A")
            {
                cCATEGORIAS.agregar_categoria(oCategoria);
            }
            else
            {
                cCATEGORIAS.modificar_categoria(oCategoria);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
