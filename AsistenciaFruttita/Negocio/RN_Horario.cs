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
    public class RN_Horario
    {
        public void RN_ACtualizar_horario(EN_Horario p)
        {
            BD_Horario obj = new BD_Horario();
            obj.BD_ACtualizar_horario(p);
        }
        public DataTable RN_Leer_Horarios()
        {
            BD_Horario obj = new BD_Horario();
            return obj.Bd_Leer_Horarios();
        }
    }
}
