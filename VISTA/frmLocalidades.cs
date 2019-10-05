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
        //agregar MODELO.USUARIO oUSUARIO en el parametro y boton seleccionar para el CU-buscar
        public frmLocalidades(MODELO.USUARIO oUsuario)
        {
            InitializeComponent();
            cLOCALIDADES = CONTROLADORA.cLOCALIDADES.obtener_instancia();
            btnSELECCIONAR.Visible = false;
            btnAGREGAR.Enabled = oUsuario.validar_acciones("btnAGREGAR", "frmLocalidades");
            btnCONSULTAR.Enabled = oUsuario.validar_acciones("btnCONSULTAR", "frmLocalidades");
            btnMODIFICAR.Enabled = oUsuario.validar_acciones("btnMODIFICAR", "frmLocalidades");
            armarGrilla();
        }
        //CONSTRUCTOR PARA ENLAZAR DATOS CON EL CLIENTE
        MODELO.CLIENTE oCliente;
        bool localidadAlCliente = false;
        int selectRowIndex = -1;
        public frmLocalidades(MODELO.CLIENTE miCliente)
        {
            InitializeComponent();
            localidadAlCliente = true;
            oCliente = miCliente;
            cLOCALIDADES = CONTROLADORA.cLOCALIDADES.obtener_instancia();
            armarGrilla();
            btnSELECCIONAR.Visible = true;

            //test seleccionar sigue en el load del formulario
            if (oCliente.localidad != null)
            {
                var selectedRow = dgvLOCALIDADES.Rows.Cast<DataGridViewRow>().FirstOrDefault(x => Convert.ToInt32(x.Cells[0].Value) == 6);
                selectRowIndex = selectedRow.Index;
            }
        }

        //CONSTRUCTOR PARA ENLAZAR DATOS CON LOS PROVEEDORES
        MODELO.PROVEEDOR oProveedor;
        bool localidadAlProveedor = false;
        public frmLocalidades(MODELO.PROVEEDOR miProveedor)
        {
            InitializeComponent();
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

        private void btnSELECCIONAR_Click(object sender, EventArgs e)
        {
            if (dgvLOCALIDADES.CurrentRow == null) {
                MessageBox.Show("Debe seleccionar una localidad de la lista");
                return;
            }

            //agregar localidad al cliente?
            if (localidadAlCliente) {
                oCliente.localidad = cLOCALIDADES.obtener_localidad(Convert.ToInt32(dgvLOCALIDADES.CurrentRow.Cells[0].Value));
            }

            //agregar localidad al proveedor?
            if (localidadAlProveedor)
            {
                oProveedor.localidad = cLOCALIDADES.obtener_localidad(Convert.ToInt32(dgvLOCALIDADES.CurrentRow.Cells[0].Value));
            }

            this.Close();
            
        }

        private void frmLocalidades_Load(object sender, EventArgs e)
        {

            //test de selecionar localidad clientes
            if (selectRowIndex != -1)
            {
                dgvLOCALIDADES.ClearSelection();
                dgvLOCALIDADES.Rows[selectRowIndex].Selected = true;
            }
            

        }
    }
}
