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
    [MODELO.formulario(nombre = "frmRemitos", gestion = "gestionarRemitosDeCompras", descripcion = "Gestionar Remitos", modulo = "Inventario")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Remito", formulario = "frmRemitos", modulo = "Inventario")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Remito", formulario = "frmRemitos", modulo = "Inventario")]
    public partial class frmRemitos : Form
    {
        CONTROLADORA.cREMITOSDECOMPRA cREMITOSDECOMPRA;
        public frmRemitos(MODELO.USUARIO oUsuario)
        {
            InitializeComponent();

            cREMITOSDECOMPRA = CONTROLADORA.cREMITOSDECOMPRA.obtener_instancia();
            btnAGREGAR.Enabled = oUsuario.validar_acciones("btnAGREGAR", "frmRemitos");
            btnCONSULTAR.Enabled = oUsuario.validar_acciones("btnCONSULTAR", "frmRemitos");
            armar_grilla();
        }
        public void armar_grilla()
        {
            dgvREMITOS.DataSource = null;
            dgvREMITOS.DataSource = cREMITOSDECOMPRA.obtener_remitos(txtPROVEEDOR.Text, txtORDEN.Text);
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            armar_grilla();
        }

        private void btnTODAS_Click(object sender, EventArgs e)
        {
            txtPROVEEDOR.Text = "";
            txtORDEN.Text = "";
            armar_grilla();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmRemito frmRemito = new frmRemito(new MODELO.REMITODECOMPRA(), "A");
            DialogResult dr = frmRemito.ShowDialog();
            if (dr == DialogResult.OK)
                armar_grilla();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvREMITOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un remito para consultar.");
                return;
            }
            MODELO.REMITODECOMPRA oREMITO = cREMITOSDECOMPRA.obtener_remito(Convert.ToInt32(dgvREMITOS.CurrentRow.Cells[0].Value));
            frmRemito frmRemito = new frmRemito(oREMITO, "C");
            frmRemito.ShowDialog();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
