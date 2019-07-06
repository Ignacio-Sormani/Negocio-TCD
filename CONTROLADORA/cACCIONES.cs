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
        private static cACCIONES instancia;
        public static cACCIONES obtener_instancia()
        {
            if (instancia == null)
                instancia = new cACCIONES();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cACCIONES()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }

        public static List<MODELO.formulario> listar_acciones()
        { 
            List<MODELO.formulario> forms = new List<MODELO.formulario>();
            Assembly VISTA = Assembly.LoadFrom("VISTA.exe");
            foreach (System.Type type in VISTA.GetTypes())
            {
                if (type.IsSubclassOf(typeof(System.Windows.Forms.Form)))
                {
                    object[] attrs = type.GetCustomAttributes(typeof(MODELO.formulario), true);
                    foreach (MODELO.formulario a in attrs)
                    {
                            object[] acciones = type.GetCustomAttributes(typeof(MODELO.accion), true);
                            foreach (MODELO.accion ac in acciones)
                            {
                            a.acciones.Add(ac);
                            }
                        forms.Add(a);
                    }
                }
            }
            return forms;
        }

        public void verificar_acciones()
        {
            List<MODELO.formulario> FORMULARIOS = listar_acciones();

            var modulos = (from formulario in FORMULARIOS
                          select new { DESCRIPCION = formulario.modulo })
                          .Distinct();

            foreach (var MODULO in modulos)
            {
                var formularios = from formulario in FORMULARIOS
                                  where formulario.modulo == MODULO.DESCRIPCION
                                  select formulario;

                foreach (MODELO.formulario oForm in formularios)
                {
                    if (obtener_acciones().Count(acc => acc.descripcionAccion == oForm.descripcion) == 0)
                    {
                        MODELO.ACCION miForm = new MODELO.ACCION();
                        miForm.descripcionAccion = oForm.descripcion;
                        miForm.nombreFormulario = oForm.nombre;
                        miForm.control = oForm.gestion + "ToolStripMenuItem";
                        miForm.modulo = oForm.modulo;
                        agregar_accion(miForm);
                    }

                    foreach (MODELO.accion oAccion in oForm.acciones)
                    {
                        if (obtener_acciones().Count(acc => acc.descripcionAccion == oAccion.descripcion) == 0)
                        {
                            MODELO.ACCION miAccion = new MODELO.ACCION();
                            miAccion.descripcionAccion = oAccion.descripcion;
                            miAccion.nombreFormulario = oAccion.formulario;
                            miAccion.control = oAccion.control;
                            miAccion.modulo = oAccion.modulo;
                            agregar_accion(miAccion);
                        }
                    }
                }
            }
        }

        public void agregar_accion(MODELO.ACCION oAccion)
        {
            oNegocio.ACCIONES.Add(oAccion);
            oNegocio.SaveChanges();
        }

        public List<MODELO.ACCION> obtener_acciones()
        {
            return oNegocio.ACCIONES.ToList();
        }

        public Int32 verificar_grupos()
        {
            return oNegocio.GRUPOS.Count(g => g.nombre == "Administrador del Sistema");
        }
        
        public Int32 verificar_usuarios()
        {
            return oNegocio.USUARIOS.Count();
        }
    }
}
