using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;

namespace VISTA
{
    [MODELO.formulario(nombre = "frmArchivoDeDatos", gestion = "generarArchivosDeDatos", descripcion = "Gestionar Nuevos Archivos", modulo = "Gerencia")]
    [MODELO.accion(control = "btnGENERARARCHIVO", descripcion = "Generar Archivo de Datos", formulario = "frmArchivoDeDatos", modulo = "Gerencia")]
    public partial class frmArchivoDeDatos : Form
    {
        CONTROLADORA.cORDENESDECOMPRA cORDENESDECOMPRA;
        CONTROLADORA.cVENTAS cVENTAS;
        CONTROLADORA.cCLIENTES cCLIENTES;
        CONTROLADORA.cPROVEEDORES cPROVEEDORES;

        public frmArchivoDeDatos(MODELO.USUARIO oUsuario)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            cmbTIPO.Items.Add("ORDEN DE COMPRA");
            cmbTIPO.Items.Add("VENTAS");
            cmbTIPO.Items.Add("CLIENTES");
            cmbTIPO.Items.Add("PROVEEDORES");

            cmbTIPO.SelectedIndex = 0;

            btnGENERARARCHIVO.Enabled = oUsuario.validar_acciones("btnGENERARARCHIVO", "frmArchivoDeDatos");

            cORDENESDECOMPRA = CONTROLADORA.cORDENESDECOMPRA.obtener_instancia();
            cVENTAS = CONTROLADORA.cVENTAS.obtener_instancia();
            cCLIENTES = CONTROLADORA.cCLIENTES.obtener_instancia();
            cPROVEEDORES = CONTROLADORA.cPROVEEDORES.obtener_instancia();

            armar_grilla(cmbTIPO.SelectedIndex);
        }

        public void armar_grilla(int _indexTipo)
        {
            switch (_indexTipo)
            {
                case 0:
                    dgvPLANILLA.DataSource = null;
                    dgvPLANILLA.DataSource = cORDENESDECOMPRA.obtener_ordenes_fecha(Convert.ToDateTime(dtpDESDE.Value), Convert.ToDateTime(dtpHASTA.Value));
                    break;
                case 1:
                    dgvPLANILLA.DataSource = null;
                    dgvPLANILLA.DataSource = cVENTAS.obtener_ventas_fecha(Convert.ToDateTime(dtpDESDE.Value), Convert.ToDateTime(dtpHASTA.Value));
                    break;
                case 2:
                    dgvPLANILLA.DataSource = null;
                    dgvPLANILLA.DataSource = cCLIENTES.obtener_clientes("");
                    break;
                case 3:
                    dgvPLANILLA.DataSource = null;
                    dgvPLANILLA.DataSource = cPROVEEDORES.obtener_proveedores("");
                    break;
            }
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGENERARARCHIVO_Click(object sender, EventArgs e)
        {
            SLDocument sl = new SLDocument();
            SLStyle headerStyle = new SLStyle();
            headerStyle.Font.Bold = true;

            int iRow = 1;
            int iCol = 1;
            foreach (DataGridViewRow row in dgvPLANILLA.Rows)
            {
                foreach (DataGridViewColumn col in dgvPLANILLA.Columns)
                {
                    //Si es la primer fila, setear headers
                    if (iRow == 1)
                    {
                        sl.SetCellValue(iRow, iCol, col.HeaderText.ToString());
                        sl.SetCellStyle(iRow, iCol, headerStyle);
                    }

                    sl.SetCellValue(iRow + 1, iCol, row.Cells[iCol - 1].Value.ToString());

                    iCol++;
                }
                iRow++;
                iCol = 1;
            }
            try
            {
                string fecha = "";
                if (dtpDESDE.Visible == true && dtpHASTA.Visible == true)
                {
                    var fechaDesde = Convert.ToDateTime(dtpDESDE.Value);
                    var fechaHasta = Convert.ToDateTime(dtpHASTA.Value);
                    fecha = fechaDesde.ToString("dd'-'MM'-'yyyy") + "_Hasta_" + fechaHasta.ToString("dd'-'MM'-'yyyy");
                }
                else {
                    fecha = DateTime.Now.ToString("dd'-'MM'-'yyyy");
                }
                sl.SaveAs(@"C:\Users\nacho\Desktop\Sistema_de_Libreria\Planillas\" + cmbTIPO.Text + "-"+ fecha +".xlsx");
                MessageBox.Show("La planilla se ha generado con exito.");
            }
            catch
            {
                MessageBox.Show("Debe cerrar el archivo excel para guardar la nueva planilla.");
            }
        }

        private void btnFILTRAR_Click(object sender, EventArgs e)
        {
            armar_grilla(cmbTIPO.SelectedIndex);
        }

        private void cmbTIPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cmbTIPO.SelectedIndex)
            {
                case 0:
                    dtpDESDE.Visible = true;
                    dtpHASTA.Visible = true;
                    lblDESDE.Visible = true;
                    lblHASTA.Visible = true;
                    break;
                case 1:
                    dtpDESDE.Visible = true;
                    dtpHASTA.Visible = true;
                    lblDESDE.Visible = true;
                    lblHASTA.Visible = true;
                    break;
                case 2:
                    dtpDESDE.Visible = false;
                    dtpHASTA.Visible = false;
                    lblDESDE.Visible = false;
                    lblHASTA.Visible = false;
                    break;
                case 3:
                    dtpDESDE.Visible = false;
                    dtpHASTA.Visible = false;
                    lblDESDE.Visible = false;
                    lblHASTA.Visible = false;
                    break;
            }

        }
    }
}
