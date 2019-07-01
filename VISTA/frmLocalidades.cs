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
        //agregar MODELO.USUARIO oUSUARIO en el parametro y boton seleccionar para el CU-buscar
        public frmLocalidades()
        {
            InitializeComponent();
            cLOCALIDADES = CONTROLADORA.cLOCALIDADES.obtener_instancia();
            armarGrilla();
        }

        public void armarGrilla()
        {
            dgvLOCALIDADES.DataSource = null;
            dgvLOCALIDADES.DataSource = cLOCALIDADES.obtener_localidades(txtBUSCAR.Text);
        }
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmLocalidad frmLocalidad = new frmLocalidad(new MODELO.LOCALIDAD(), "A");
            DialogResult dr = frmLocalidad.ShowDialog();
            if (dr == DialogResult.OK) {
                armarGrilla();
            }
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvLOCALIDADES.CurrentRow == null) {
                MessageBox.Show("Debe seleccionar una localidad a modificar");
                return;
            }
            frmLocalidad frmLocalidad = new frmLocalidad(cLOCALIDADES.obtener_localidad(Convert.ToInt32(dgvLOCALIDADES.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = frmLocalidad.ShowDialog();
            if (dr == DialogResult.OK) {
            armarGrilla();
            }
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvLOCALIDADES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una localidad a consultar");
                return;
            }
            frmLocalidad frmLocalidad = new frmLocalidad(cLOCALIDADES.obtener_localidad(Convert.ToInt32(dgvLOCALIDADES.CurrentRow.Cells[0].Value)), "C");
            frmLocalidad.ShowDialog();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            armarGrilla();
        }
    }
}
