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

            btnGENERARREPORTE.Enabled = oUsuario.validar_acciones("btnGENERARREPORTE", "frmReporte");
        }
        /*
        var cobranza = from row in dgvEconomia.Rows.Cast<DataGridViewRow>()
                       group row by row.Cells["Fecha"].Value into g
                       select new
                       {
                           FECHA = g.Key,
                           TOTAL = g.Sum(x => Convert.ToDecimal(x.Cells["TOTAL"].Value))
                       };
        dgvEconomia.DataSource = cobranza.ToList();
        */ //para hacer el group by de los listar en la grilla

        /*
        foreach (var series in chart2.Series)
        {
            series.Points.Clear();
        }
        */ // para limpiar el grafico
    }
}
