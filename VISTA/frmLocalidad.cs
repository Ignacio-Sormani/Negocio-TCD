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
            FormStyle.defaultWindowStyle(this);


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
                txtLOCALIDAD.Text = oLocalidad.localidad;
                txtCP.Text = oLocalidad.codigoPostal.ToString();

                txtLOCALIDAD.Enabled = false;
                txtCP.Enabled = false;
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
            Boolean validarLocalidadExistente = cLocalidades.verificar_localidad_existente(codigoPostal, txtLOCALIDAD.Text);
            if (Accion == "A")
            {
                if (validarLocalidadExistente)
                {
                    MessageBox.Show("La Localidad y Codigo Postal ya existe");
                    return;
                }
                oLocalidad.localidad = txtLOCALIDAD.Text;
                oLocalidad.codigoPostal = codigoPostal;
                cLocalidades.agregar_localidad(oLocalidad);
            }
            else if (Accion == "M")
            {
                if (validarLocalidadExistente)
                {
                    MessageBox.Show("La Localidad y Codigo Postal no realizo cambios o ya existe");
                    return;
                }
                oLocalidad.localidad = txtLOCALIDAD.Text;
                oLocalidad.codigoPostal = codigoPostal;
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
