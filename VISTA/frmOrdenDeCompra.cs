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
    public partial class frmOrdenDeCompra : Form
    {
        CONTROLADORA.cORDENESDECOMPRA cORDENES;
        MODELO.ORDENDECOMPRA oORDEN;
        string ACCION;
        public frmOrdenDeCompra(MODELO.ORDENDECOMPRA miORDEN, string miACCION)
        {
            InitializeComponent();

            cORDENES = CONTROLADORA.cORDENESDECOMPRA.obtener_instancia();
            oORDEN = miORDEN;
            ACCION = miACCION;
        }
    }
}
