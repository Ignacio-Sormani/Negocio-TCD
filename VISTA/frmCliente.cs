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
    public partial class frmCliente : Form
    {
        CONTROLADORA.cCLIENTES cCLIENTE;
        MODELO.CLIENTE oCliente;
        string accion;
        public frmCliente(MODELO.CLIENTE miCliente, string miAccion)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            cCLIENTE = CONTROLADORA.cCLIENTES.obtener_instancia();
            oCliente = miCliente;
            accion = miAccion;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            Int64 dni;
            if (!Int64.TryParse(txtDNI.Text, out dni)) {
                MessageBox.Show("El valor del dni es incorrecto");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNOMBREAPELLIDO.Text)) {
                MessageBox.Show("El valor del nombre y apellido es incorrecto");
                return;
            }

            //validacion para que la fecha no sea mayor a la actual

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
            oCliente.dni = dni;
            oCliente.nombreApellido = txtNOMBREAPELLIDO.Text;
            oCliente.fechaNacimiento = dtpNACIMIENTO.Value;
            oCliente.direccion = txtDIRECCION.Text;
            oCliente.telefono = telefono;
            oCliente.mail = txtEMAIL.Text;

            if (accion == "A") {
                cCLIENTE.agregar_cliente(oCliente);
            } else {
                cCLIENTE.modificar_cliente(oCliente);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void completarCampos() {
            txtDNI.Text = oCliente.dni.ToString();
            txtNOMBREAPELLIDO.Text = oCliente.nombreApellido;
            dtpNACIMIENTO.Value = oCliente.fechaNacimiento;
            txtDIRECCION.Text = oCliente.direccion;
            lblLOCALIDAD.Text = oCliente.localidad.ToString();
            txtTELEFONO.Text = oCliente.telefono.ToString();
            txtEMAIL.Text = oCliente.mail;
        }

        public void deshabilitarCampos() {
            lblLOCALIDAD.Enabled = false;
            txtDNI.Enabled = false;
            txtNOMBREAPELLIDO.Enabled = false;
            dtpNACIMIENTO.Enabled = false;
            txtDIRECCION.Enabled = false;
            txtTELEFONO.Enabled = false;
            txtEMAIL.Enabled = false;
            btnLOCALIDAD.Enabled = false;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            if (accion == "M")
            {
                btnLOCALIDAD.Text = "Modificar Localidad";
                completarCampos();
            }
            if (accion == "C")
            {
                completarCampos();
                deshabilitarCampos();
                btnCANCELAR.Text = "Cerrar";
                btnGUARDAR.Visible = false;
            }
        }

        private void btnLOCALIDAD_Click(object sender, EventArgs e)
        {
            frmLocalidades frmLocalidades = new frmLocalidades(oCliente);
            frmLocalidades.ShowDialog();
            if (oCliente.localidad != null) {
                lblLOCALIDAD.Text = oCliente.localidad.ToString();
            }
        }
    }
}
