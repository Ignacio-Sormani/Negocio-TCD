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
    public partial class frmLogin : Form
    {
        CONTROLADORA.cUSUARIOS cUSUARIOS;
        MODELO.USUARIO miUsuario;
        public MODELO.USUARIO oUsuario { get { return miUsuario;  } }

        public frmLogin()
        {
            InitializeComponent();
            FormStyle.windowStyle(this);

            cUSUARIOS = CONTROLADORA.cUSUARIOS.obtener_instancia();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUSUARIO.Text))
            {
                MessageBox.Show("Debe ingresar un usuario");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCONTRASEÑA.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña");
                return;
            }
            string claveEncriptada = CONTROLADORA.FUNCIONES.encriptar_clave(txtCONTRASEÑA.Text);
            miUsuario = cUSUARIOS.obtener_usuario_nombre(txtUSUARIO.Text);
            if (miUsuario == null)
            {
                MessageBox.Show("El usuario ingresado no existe");
                return;
            }
            if (miUsuario.clave != claveEncriptada)
            {
                MessageBox.Show("La contraseña ingresada ingresada es incorrecta");
                return;
            }
            if (miUsuario.estadoActivo == false)
            {
                MessageBox.Show("El usuario ingresado esta dado de baja temporal o permanentemente");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void lblRESETEARCONTRASEÑA_Click(object sender, EventArgs e)
        {
            frmResetearContraseña frmResetearContraseña = new frmResetearContraseña();
            frmResetearContraseña.ShowDialog();
        }

        private void lblRESETEARCONTRASEÑA_MouseEnter(object sender, EventArgs e)
        {
            lblRESETEARCONTRASEÑA.ForeColor = Color.Red;
        }

        private void lblRESETEARCONTRASEÑA_MouseLeave(object sender, EventArgs e)
        {
            lblRESETEARCONTRASEÑA.ForeColor = SystemColors.ControlText;
        }
    }
}
