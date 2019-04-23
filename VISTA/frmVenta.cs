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
    public partial class frmVenta : Form
    {
        CONTROLADORA.cVENTAS cVENTAS;
        MODELO.VENTA oVENTA;
        string ACCION;
        public frmVenta(MODELO.VENTA miVENTA, string miACCION)
        {
            InitializeComponent();

            cVENTAS = CONTROLADORA.cVENTAS.obtener_instancia();
            oVENTA = miVENTA;
            ACCION = miACCION;

            
            if (ACCION == "C")
            {
                
                dtpFECHA.Enabled = false;
                txtCLIENTE.Enabled = false;
                txtTOTAL.Text = oVENTA.total.ToString();
                btnAGREGAR.Visible = false;
                btnAGREGARPRODUCTO.Visible = false;
                btnELIMINARPRODUCTO.Visible = false;
                panAGREGAR.Visible = false;
            }
            else
            {
                panAGREGAR.Enabled = false;
                dtpFECHA.Value = System.DateTime.Now;
            }
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {

        }
        /* agregar el system.Drawing 
        printdocument y printpreviewdialog (en el previewdialog ponerle en las propiedades el nombre del printdocument)
         en printdocument, agrega el evento printpage y ponerle adentro  e.Graphics.DrawImage(bmp, 0, 0);
         en el boton imprimir:
                            Graphics g = this.CreateGraphics();
                bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
                Graphics mg = Graphics.FromImage(bmp);
                mg.CopyFromScreen(this.Location.X, this.Location.Y, 30, 50, this.Size);
                CargarCliente();

                printPreviewDialog1.ShowDialog();
         crear una variable Bitmap bmp;*/
    }
}
