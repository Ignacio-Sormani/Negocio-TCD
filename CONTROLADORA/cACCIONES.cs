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
        public static List<MODELO.formulario> obtener_acciones()
        { 
            List<MODELO.formulario> forms = new List<MODELO.formulario>();
            Assembly VISTA = Assembly.LoadFrom("VISTA.exe");
            foreach (System.Type type in VISTA.GetTypes())
            {
                //pregunto si es de tipo Formulario
                if (type.IsSubclassOf(typeof(System.Windows.Forms.Form)))
                {
                    object[] attrs = type.GetCustomAttributes(typeof(MODELO.formulario), true);


                    foreach (MODELO.formulario a in attrs)
                    {
                            object[] acciones = type.GetCustomAttributes(typeof(MODELO.accion), true);
                            foreach (MODELO.accion ac in acciones)
                            {
                                //MessageBox.Show(ac.FORMULARIO + " - " + ac.CONTROL + " - " + ac.DESCRIPCION);
                                //cINICIO.ACTUALIZA_ACCIONES(ac);
                                a.acciones.Add(ac);
                            }
                        forms.Add(a);
                    }
                }
            }
            return forms;
        }
    }
}
