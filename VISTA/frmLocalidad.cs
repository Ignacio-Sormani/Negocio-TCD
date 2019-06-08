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
        public string Accion;
        CONTROLADORA.cLOCALIDADES cLocalidades;
        public frmLocalidad(MODELO.LOCALIDAD miLocalidad, string miAccion)
        {
            InitializeComponent();

            cLocalidades = CONTROLADORA.cLOCALIDADES.obtener_instancia();
            oLocalidad = miLocalidad;
            Accion = miAccion;
        }

        public frmLocalidad(string miAccion) {
            InitializeComponent();
            cLocalidades = CONTROLADORA.cLOCALIDADES.obtener_instancia();
            Accion = miAccion;
        }

        private void frmLocalidad_Load(object sender, EventArgs e)
        {
            if (Accion == "M")
            {
                txtLOCALIDAD.Text = oLocalidad.localidad;
                txtCP.Text = oLocalidad.codigoPostal.ToString();
                btnGUARDAR.Text = "Modificar";
            }

            if (Accion == "C") //esto no va no hay consulta aqui :P
            {
                txtLOCALIDAD.Enabled = false;
                btnCANCELAR.Text = "Cerrar";
                btnGUARDAR.Visible = false;
            }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            //validaciones
            if (string.IsNullOrEmpty(txtLOCALIDAD.Text)) {
                MessageBox.Show("Debe rellenar el campo localidad");
            }

            int codigoPostal;
            if (!int.TryParse(txtLOCALIDAD.Text, out codigoPostal)) {
                MessageBox.Show("El Codigo Postal debe ser un valor numerico");
            }
            //AGREGAR O MODIFICAR?
            if (Accion == "A") oLocalidad = new MODELO.LOCALIDAD();
            oLocalidad.localidad = txtLOCALIDAD.Text;
            oLocalidad.codigoPostal = codigoPostal;
            if (Accion == "A")
            {
                cLocalidades.agregar_localidad(oLocalidad);
            }
            else {
                cLocalidades.modificar_localidad(oLocalidad);
            }
            this.DialogResult = DialogResult.OK;

        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //FIN
    }
}
