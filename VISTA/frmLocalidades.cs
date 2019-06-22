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
    [MODELO.formulario(nombre = "frmLocalidades", descripcion = "Gestionar Localidades", modulo = "Gestiones")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Localidad", formulario = "frmLocalidades", modulo = "Gestiones")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Localidad", formulario = "frmLocalidades", modulo = "Gestiones")]
    [MODELO.accion(control = "btnMODIFICAR", descripcion = "Modificar Localidad", formulario = "frmLocalidades", modulo = "Gestiones")]
    public partial class frmLocalidades : Form
    {
        CONTROLADORA.cLOCALIDADES cLOCALIDADES;
        public frmLocalidades()
        {
            InitializeComponent();
            cLOCALIDADES = CONTROLADORA.cLOCALIDADES.obtener_instancia();
            armarGrilla("");
        }

        public void armarGrilla(string localidad) {
            dgvLocalidades.DataSource = null;
            dgvLocalidades.DataSource = cLOCALIDADES.obtener_localidades(localidad);
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            armarGrilla(txtBuscar.Text);
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmLocalidad frmLocalidad = new frmLocalidad("A");
            DialogResult dr = frmLocalidad.ShowDialog();
            if (dr == DialogResult.OK) {
                armarGrilla("");
            }
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            MODELO.LOCALIDAD oLocalidad = cLOCALIDADES.obtener_localidad(Convert.ToInt32(dgvLocalidades.CurrentRow.Cells[0].Value));
            DialogResult dr = MessageBox.Show("Desea eliminar la localidad?", "Eliminar", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes) {
                cLOCALIDADES.eliminar_localidad(oLocalidad);
                armarGrilla("");
            }

        }

        private void btnTODOS_Click(object sender, EventArgs e)
        {
            armarGrilla("");
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvLocalidades.CurrentRow == null) {
                MessageBox.Show("Debe seleccionar una localidad a modificar");
                return;
            }
            MODELO.LOCALIDAD oLocalidad = cLOCALIDADES.obtener_localidad(Convert.ToInt32(dgvLocalidades.CurrentRow.Cells[0].Value));
            frmLocalidad frmLocalidad = new frmLocalidad(oLocalidad,"M");
            DialogResult dr = frmLocalidad.ShowDialog();
            if (dr == DialogResult.OK) {
            armarGrilla("");
            }
        }
    }
}
