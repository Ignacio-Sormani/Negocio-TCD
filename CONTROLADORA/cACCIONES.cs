using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CONTROLADORA
{
    public class cACCIONES
    {

        //CONTROLADORA BASE
        //Lo aqui desarrollado es solo para guiar la creacion de las demas controladores
        //Por lo tanto, estos metodos deben ser desarrollados de acuerdo a las especificaciones correspondientes

        /*
            18 controladoras    -->     1 completada
            [1] CTRLACCIONES ✕
            [2] CTRLCATEGORIAS ✓✓
            [3] CTRLCLIENTES ✓
            [4] CTRLFORMASPAGO ✕
            [5] CTRLGRUPOS ✕
            [6] CTRLITEMS ✕
            [7] CTRLLOCALIDADES ✕ 
            [8] CTRLLOGINS ✕
            [9] CTRLMARCAS ✓✓
            [10] CTRLORDENESDECOMPRA ✕
            [11] CTRLPAGOS ✕
            [12] CTRLPRODUCTOS ✓
            [13] CTRLPROVEEEDORES ✓
            [14] CTRLREMITOS
            [15] CTRLREPORTES
            [16] CTRLUSUARIOS ✕
            [17] CTRLVENTAS ✕
            [18] FUNCIONES
         */

        /*public static List<MODELO.formulario> obtener_acciones(string descripcion, string formulario)
        {

            
            List<MODELO.formulario> FORMULARIOS = new List<MODELO.formulario>();
            Assembly VISTA = Assembly.LoadFrom("VISTA.exe");
            foreach (System.Type type in VISTA.GetTypes())
            {
                //pregunto si es de tipo Formulario
                if (type.IsSubclassOf(typeof(System.Windows.Forms.Form)))
                {
                    object[] attrs = type.GetCustomAttributes(typeof(MODELO.formulario), true);


                    foreach (MODELO.formulario a in attrs)
                    {
                        if (a.SEGURIDAD)
                        {
                            //MessageBox.Show(a.DESCRIPCION + ", " + a.CLASE);
                            //cINICIO.ACTUALIZA_FORMULARIOS(a);


                            object[] acciones = type.GetCustomAttributes(typeof(MODELO.accion), true);

                            foreach (MODELO.accion ac in acciones)
                            {
                                //MessageBox.Show(ac.FORMULARIO + " - " + ac.CONTROL + " - " + ac.DESCRIPCION);
                                //cINICIO.ACTUALIZA_ACCIONES(ac);
                                a.ACCIONES.Add(ac);
                            }
                        }

                        FORMULARIOS.Add(a);

                    }
                }
            }
            return FORMULARIOS;
        }*/
    }
}
