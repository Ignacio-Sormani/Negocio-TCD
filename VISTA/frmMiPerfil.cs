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
    public partial class frmMiPerfil : Form
    {
        MODELO.USUARIO oUsuario;
        CONTROLADORA.cUSUARIOS cUSUARIOS;
        public frmMiPerfil(MODELO.USUARIO miUsuario)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            oUsuario = miUsuario;
            cUSUARIOS = CONTROLADORA.cUSUARIOS.obtener_instancia();
        }

        private void frmMiPerfil_Load(object sender, EventArgs e)
        {
            txtUSUARIO.Text = oUsuario.nombreDeUsuario;
            txtNOMBRE.Text = oUsuario.nombreApellido;
            txtMAIL.Text = oUsuario.mail;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUSUARIO.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario correcto");
                return;
            }
            if (!cUSUARIOS.verificar_usuario_existente(txtUSUARIO.Text) && oUsuario.nombreDeUsuario != txtUSUARIO.Text)
            {
                MessageBox.Show("El nombre de usuario ingresado ya existe");
                return;
            }
            if (string.IsNullOrEmpty(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar un nombre y apellido correcto");
                return;
            }
            if (string.IsNullOrEmpty(txtMAIL.Text) || !CONTROLADORA.FUNCIONES.validar_mail(txtMAIL.Text))
            {
                MessageBox.Show("Debe ingresar un mail correcto");
                return;
            }
            oUsuario.nombreDeUsuario = txtUSUARIO.Text;
            oUsuario.nombreApellido = txtNOMBRE.Text;
            oUsuario.mail = txtMAIL.Text;
            cUSUARIOS.modificar_usuario(oUsuario);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
