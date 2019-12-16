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
    [MODELO.formulario(nombre = "frmAuditoriaCliente", gestion = "verAuditoriasCliente", descripcion = "Ver Auditorias Cliente", modulo = "Seguridad")]
    public partial class frmAuditoriaCliente : Form
    {
        CONTROLADORA.cAUDITORIAS cAUDITORIAS;    
        public frmAuditoriaCliente()
        {
            InitializeComponent();
            FormStyle.defaultControlsStyle(this);
            cAUDITORIAS = CONTROLADORA.cAUDITORIAS.obtener_instancia();
            armar_grilla();
        }
        private void armar_grilla()
        {
            dgvAUDITORIAS.DataSource = null;
            dgvAUDITORIAS.DataSource = cAUDITORIAS.obtener_auditorias_cliente(txtBUSCAR.Text);
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            armar_grilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBUSCAR.Text = "";
            armar_grilla();
        }
    }
}
