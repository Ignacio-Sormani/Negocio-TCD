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
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
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
