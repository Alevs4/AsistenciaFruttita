using AsistenciaFruttita.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaFruttita.Negocio
{
    public class RN_Distrito
    {
        public DataTable RN_Buscar_Todos_Distrito()
        {
            BD_Distrito obj = new BD_Distrito();
            return obj.BD_Buscar_Todos_Distrito();
        }
    }
}
