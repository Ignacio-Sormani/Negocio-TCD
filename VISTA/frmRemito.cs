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
    public partial class frmRemito : Form
    {
        CONTROLADORA.cREMITOSDECOMPRA cREMITOSDECOMPRA;
        public frmRemito()
        {
            InitializeComponent();
            cREMITOSDECOMPRA = CONTROLADORA.cREMITOSDECOMPRA.obtener_instancia();
        }



        /*
        public bool validar_estado(MODELO.ORDENDECOMPRA oORDEN)
        {
            bool a = true;
            foreach (MODELO.ITEMRC item in cREMITOSDECOMPRA.calcular_items_faltantes(oORDEN))
            {
                if (item.cantidad != 0)
                {
                    a = false;
                }
            }
            return a;
        }*/
    }
}
