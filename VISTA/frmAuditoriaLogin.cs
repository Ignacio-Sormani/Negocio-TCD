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
    [MODELO.formulario(nombre = "frmAuditoriaLogin", gestion = "verLogins", descripcion = "Ver Logins", modulo = "Seguridad")]
    public partial class frmAuditoriaLogin : Form
    {        
        CONTROLADORA.cACCESOS cACCESOS;
        public frmAuditoriaLogin()
        {
            InitializeComponent();
            FormStyle.defaultControlsStyle(this);
            cACCESOS = CONTROLADORA.cACCESOS.obtener_instancia();
            armar_grilla();
        }


        private void armar_grilla()
        {
            dgvAUDITORIAS.DataSource = null;
            dgvAUDITORIAS.DataSource = cACCESOS.obtener_accesos("");
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
