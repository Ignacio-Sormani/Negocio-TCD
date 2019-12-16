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
    [MODELO.formulario(nombre = "frmLocalidades", gestion = "gestionarLocalidades", descripcion = "Gestionar Localidades", modulo = "Gestiones")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Localidad", formulario = "frmLocalidades", modulo = "Gestiones")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Localidad", formulario = "frmLocalidades", modulo = "Gestiones")]
    [MODELO.accion(control = "btnMODIFICAR", descripcion = "Modificar Localidad", formulario = "frmLocalidades", modulo = "Gestiones")]
    public partial class frmLocalidades : Form
    {
        CONTROLADORA.cLOCALIDADES cLOCALIDADES;        
        public frmLocalidades(MODELO.USUARIO oUsuario)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);
            cLOCALIDADES = CONTROLADORA.cLOCALIDADES.obtener_instancia();
            btnSELECCIONAR.Visible = false;
            btnAGREGAR.Enabled = oUsuario.validar_acciones("btnAGREGAR", "frmLocalidades");
            btnCONSULTAR.Enabled = oUsuario.validar_acciones("btnCONSULTAR", "frmLocalidades");
            btnMODIFICAR.Enabled = oUsuario.validar_acciones("btnMODIFICAR", "frmLocalidades");
            armarGrilla();
        }

        MODELO.CLIENTE oCliente;
        bool localidadAlCliente = false;
        public frmLocalidades(MODELO.CLIENTE miCliente)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);
            localidadAlCliente = true;
            oCliente = miCliente;
            cLOCALIDADES = CONTROLADORA.cLOCALIDADES.obtener_instancia();
            armarGrilla();
            btnSELECCIONAR.Visible = true;
        }

        MODELO.PROVEEDOR oProveedor;
        bool localidadAlProveedor = false;
        public frmLocalidades(MODELO.PROVEEDOR miProveedor)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);
            localidadAlProveedor = true;
            oProveedor = miProveedor;
            cLOCALIDADES = CONTROLADORA.cLOCALIDADES.obtener_instancia();
            armarGrilla();
            btnSELECCIONAR.Visible = true;            
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
            if (dr == DialogResult.OK)
                armarGrilla();
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

        private void btnSELECCIONAR_Click(object sender, EventArgs e)
        {
            if (dgvLOCALIDADES.CurrentRow == null) {
                MessageBox.Show("Debe seleccionar una localidad de la lista");
                return;
            }

            if (localidadAlCliente) {
                oCliente.localidad = cLOCALIDADES.obtener_localidad(Convert.ToInt32(dgvLOCALIDADES.CurrentRow.Cells[0].Value));
            }

            if (localidadAlProveedor)
            {
                oProveedor.localidad = cLOCALIDADES.obtener_localidad(Convert.ToInt32(dgvLOCALIDADES.CurrentRow.Cells[0].Value));
            }

            this.Close();            
        }

        private void btnTODOS_Click(object sender, EventArgs e)
        {
            txtBUSCAR.Text = "";
            armarGrilla();
        }
    }
}
