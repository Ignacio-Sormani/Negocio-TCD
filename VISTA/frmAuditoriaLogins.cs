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
    public partial class frmAuditoriaLogins : Form
    {
        [MODELO.formulario(nombre = "frmCategorias", gestion = "gestionarCategorias", descripcion = "Gestionar Categorias", modulo = "Gestiones")]
        CONTROLADORA.cACCESOS cACCESOS;
        public frmAuditoriaLogins()
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
