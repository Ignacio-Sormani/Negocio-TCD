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
    public partial class frmMarca : Form
    {
        MODELO.MARCA oMarca;
        public string ACCION;
        CONTROLADORA.cMARCAS cMARCAS;
        public frmMarca(MODELO.MARCA miMarca, string miAccion)
        {
            InitializeComponent();

            cMARCAS = CONTROLADORA.cMARCAS.obtener_instancia();
            oMarca = miMarca;
            ACCION = miAccion;
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            if (ACCION != "A")
            {
                txtMARCA.Text = oMarca.marca;
            }

            if (ACCION == "C")
            {
                txtMARCA.Enabled = false;
                btnCANCELAR.Text = "Cerrar";
                btnGUARDAR.Visible = false;
            }

        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMARCA.Text))
            {
                MessageBox.Show("Debe ingresar un valor de marca correcto", "Marca - Atencion!");
                return;
            }
            
            if (!cMARCAS.verificar_marca_existente(txtMARCA.Text)) //verificar este doble if
            {
                if (!(ACCION == "M" && oMarca.marca == txtMARCA.Text))
                {
                    MessageBox.Show("La marca ingresada ya existe", "Marca - Atencion!");
                    return;
                }
            }            

            oMarca.marca = txtMARCA.Text;
            if (ACCION == "A")
            {
                cMARCAS.agregar_marca(oMarca);
            }
            else {
                cMARCAS.modificar_marca(oMarca);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
