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
    public partial class frmLocalidad : Form
    {
        MODELO.LOCALIDAD oLocalidad;
        string Accion;
        CONTROLADORA.cLOCALIDADES cLocalidades;
        public frmLocalidad(MODELO.LOCALIDAD miLocalidad, string miAccion)
        {
            InitializeComponent();

            cLocalidades = CONTROLADORA.cLOCALIDADES.obtener_instancia();
            oLocalidad = miLocalidad;
            Accion = miAccion;
        }

        private void frmLocalidad_Load(object sender, EventArgs e)
        {
            if (Accion == "M")
            {
                txtLOCALIDAD.Text = oLocalidad.localidad;
                txtCP.Text = oLocalidad.codigoPostal.ToString();
            }
            if (Accion == "C")
            {
                txtLOCALIDAD.Enabled = false;
                btnCANCELAR.Text = "Cerrar";
                btnGUARDAR.Visible = false;
            }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLOCALIDAD.Text))
            {
                MessageBox.Show("Debe rellenar el campo localidad");
                return;
            }
            Int32 codigoPostal;
            if (!Int32.TryParse(txtCP.Text, out codigoPostal))
            {
                MessageBox.Show("El Codigo Postal debe ser un valor numerico");
                return;
            }
            oLocalidad.localidad = txtLOCALIDAD.Text;
            oLocalidad.codigoPostal = codigoPostal;
            if (Accion == "A")
            {
                cLocalidades.agregar_localidad(oLocalidad);
            }
            else
            {
                cLocalidades.modificar_localidad(oLocalidad);
            }
            this.DialogResult = DialogResult.OK;
        }


        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.Cancel;
        }
    }
}
