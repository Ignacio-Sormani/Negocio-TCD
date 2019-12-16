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
    [MODELO.formulario(nombre = "frmReporte", gestion = "gestionarReportes", descripcion = "Gestionar Reportes", modulo = "Gerencia")]
    [MODELO.accion(control = "btnGENERARREPORTE", descripcion = "Generar Reporte", formulario = "frmReporte", modulo = "Gerencia")]
    public partial class frmReporte : Form
    {
        public frmReporte(MODELO.USUARIO oUsuario)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            lblCANTIDADES.Text = "Estadisticas Generales";
            btnGENERARREPORTE.Enabled = oUsuario.validar_acciones("btnGENERARREPORTE", "frmReporte");
            cmbTIPO.Items.Add("REPORTE DE VENTAS");
            cmbTIPO.Items.Add("REPORTE DE ORD DE COMPRAS");
            cmbTIPO.Items.Add("REPORTE DE PROVEEDORES");
            cmbTIPO.Items.Add("REPORTE DE CLIENTES");
            cmbTIPO.SelectedIndex = 0;
            generarReporte(CONTROLADORA.TipoReporte.Ventas);
        }

        public void generarReporte(CONTROLADORA.TipoReporte tipo)
        {
            CONTROLADORA.REPORTE cReporte = new CONTROLADORA.REPORTE();
            CONTROLADORA.DATOSDEREPORTE cDatosDeReporte = cReporte.CrearReporte(tipo);

            //Generar Cantidades Generales
            string nombreCantUno;
            string nombreCantDos;
            string nombreCantTres;
            int CantUno;
            int CantDos;
            int CantTres;
            cDatosDeReporte.Cantidades(Convert.ToDateTime(dtpINICIO.Value), Convert.ToDateTime(dtpFIN.Value)
                , out nombreCantUno, out nombreCantDos, out nombreCantTres, out CantUno, out CantDos, out CantTres);
            lblUNOTITLE.Text = nombreCantUno;
            lblDOSTITLE.Text = nombreCantDos;
            lblTRESTITLE.Text = nombreCantTres;
            lblUNOCANTIDAD.Text = CantUno.ToString();
            lblDOSCANTIDA.Text = CantDos.ToString();
            lblTRESCANTIDAD.Text = CantTres.ToString();
            //Generar Grafico 1
            string nombreGrafico1;
            dgvUNO.DataSource = null;
            List<string> x1;
            List<int> y1;
            dgvUNO.DataSource = cDatosDeReporte.GenerarDatosParaGrafico1(Convert.ToDateTime(dtpINICIO.Value), Convert.ToDateTime(dtpFIN.Value), out nombreGrafico1, out x1, out y1);
            lblNOMBREGRAFICOUNO.Text = nombreGrafico1;
            chartGRAFICOUNO.Series[0].Points.DataBindXY(x1, y1);
            //Generar Grafico 2
            string nombreGrafico2;
            dgvDOS.DataSource = null;
            List<string> x2;
            List<int> y2;
            dgvDOS.DataSource = cDatosDeReporte.GenerarDatosParaGrafico2(Convert.ToDateTime(dtpINICIO.Value), Convert.ToDateTime(dtpFIN.Value),
                out nombreGrafico2, out x2, out y2);
            lblNOMBREGRAFICODOS.Text = nombreGrafico2;
            chartGRAFICODOS.Series[0].Points.DataBindXY(x2, y2);
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGENERARREPORTE_Click(object sender, EventArgs e)
        {
            switch (cmbTIPO.SelectedIndex) {
                case 0:
                    generarReporte(CONTROLADORA.TipoReporte.Ventas);
                    break;
                case 1:
                    generarReporte(CONTROLADORA.TipoReporte.OrdenesDeCompra);
                    break;
                case 2:
                    generarReporte(CONTROLADORA.TipoReporte.Proveedores);
                    break;
                case 3:
                    generarReporte(CONTROLADORA.TipoReporte.Clientes);
                    break;
            }
        }
    }
}
