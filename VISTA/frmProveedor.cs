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
    public partial class frmProveedor : Form
    {
        CONTROLADORA.cPROVEEDORES cPROVEEDORES;
        MODELO.PROVEEDOR oProveedor;
        string accion;
        public frmProveedor(MODELO.PROVEEDOR miProveedor, string miAccion)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            cPROVEEDORES = CONTROLADORA.cPROVEEDORES.obtener_instancia();
            oProveedor = miProveedor;
            accion = miAccion;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            Int64 cuit;
            if (!Int64.TryParse(txtCUIT.Text, out cuit))
            {
                MessageBox.Show("El valor CUIT es incorrecto");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRAZON_SOCIAL.Text))
            {
                MessageBox.Show("El valor de la direccion es incorrecto");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDIRECCION.Text))
            {
                MessageBox.Show("El valor de la direccion es incorrecto");
                return;
            }
            if (string.IsNullOrEmpty(lblLOCALIDAD.Text))
            {
                MessageBox.Show("Debe seleccionar una localidad");
                return;
            }
            Int64 telefono;
            if (!Int64.TryParse(txtTELEFONO.Text, out telefono))
            {
                MessageBox.Show("El valor del telefono es incorrecto");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEMAIL.Text))
            {
                MessageBox.Show("El valor del email es incorrecto");
                return;
            }
            oProveedor.cuit = cuit;
            oProveedor.razonSocial = txtRAZON_SOCIAL.Text;
            oProveedor.direccion = txtDIRECCION.Text;
            oProveedor.telefono = telefono;
            oProveedor.mail = txtEMAIL.Text;
            if (accion == "A") {
                cPROVEEDORES.agregar_proveedor(oProveedor);
            }
            else {
                cPROVEEDORES.modificar_proveedor(oProveedor);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnLOCALIDAD_Click(object sender, EventArgs e)
        {
            frmLocalidades frmLocalidades = new frmLocalidades(oProveedor);
            frmLocalidades.ShowDialog();
            if (oProveedor.localidad != null)
            {
                lblLOCALIDAD.Text = oProveedor.localidad.ToString();
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void completarCampos() {
            txtCUIT.Text = oProveedor.cuit.ToString();
            txtRAZON_SOCIAL.Text = oProveedor.razonSocial;
            txtDIRECCION.Text = oProveedor.direccion;
            lblLOCALIDAD.Text = oProveedor.localidad.ToString();
            txtTELEFONO.Text = oProveedor.telefono.ToString();
            txtEMAIL.Text = oProveedor.mail;
        }

        public void deshabilitarCampos() {
            txtCUIT.Enabled = false;
            txtRAZON_SOCIAL.Enabled = false;
            txtDIRECCION.Enabled = false;
            lblLOCALIDAD.Enabled = false;
            txtTELEFONO.Enabled = false;
            txtEMAIL.Enabled = false;
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            if (accion == "M")
            {
                btnLOCALIDAD.Text = "Modificar Localidad";
                completarCampos();
            }
            if (accion == "C")
            {
                btnLOCALIDAD.Enabled = false;
                completarCampos();
                deshabilitarCampos();
                btnCANCELAR.Text = "Cerrar";
                btnGUARDAR.Visible = false;
            }
        }
    }
}
