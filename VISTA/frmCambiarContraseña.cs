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
    public partial class frmCambiarContraseña : Form
    {
        public frmCambiarContraseña()
        {
            InitializeComponent();
        }

        private void btnVOLVER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCAMBIARCONTRASEÑA_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCONTRANUEVA1.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña antigua", "ERROR - CAMPO INCOMPLETO");
                return;
            }
            //...
        }
    }
}
