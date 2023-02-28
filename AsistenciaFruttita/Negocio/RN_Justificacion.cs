using AsistenciaFruttita.Datos;
using AsistenciaFruttita.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaFruttita.Negocio
{
     public class RN_Justificacion
    {
        public void RN_Registrar_Justificacion(EN_Justificacion jus)
        {
            BD_Justificacion obj = new BD_Justificacion();
            obj.BD_Registrar_Justificacion(jus);
        }

        public void RN_Editar_Justificacion(EN_Justificacion jus)
        {
            BD_Justificacion obj = new BD_Justificacion();
            obj.BD_Editar_Justificacion(jus);
        }
        public void RN_Aprovar_Justificacion(string idjusti, string idperso)
        {
            BD_Justificacion obj = new BD_Justificacion();
            obj.BD_Aprovar_Justificacion(idjusti, idperso);
        }
        public void RN_Desaprobar_Justificacion(string idjusti, string idperso)
        {
            BD_Justificacion obj = new BD_Justificacion();
            obj.BD_Desaprobar_Justificacion(idjusti, idperso);
        }
        public DataTable RN_Cargar_todos_Justificacion()
        {
            BD_Justificacion obj = new BD_Justificacion();
            return obj.BD_Cargar_todos_Justificacion();
        }
        public DataTable RN_BuscarJustificacion_xValor(string valor)
        {
            BD_Justificacion obj = new BD_Justificacion();
            return obj.BD_BuscarJustificacion_xValor(valor);
        }
        public void RN_Eliminar_Justificacion(string idjusti)
        {
            BD_Justificacion obj = new BD_Justificacion();
            obj.BD_Eliminar_Justificacion(idjusti);
        }
    }
}
