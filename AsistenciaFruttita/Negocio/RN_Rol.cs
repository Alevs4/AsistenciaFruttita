using AsistenciaFruttita.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaFruttita.Negocio
{
    public class RN_Rol
    {

        public DataTable RN_Buscar_Todos_Roles()
        {
            BD_Rol obj = new BD_Rol();
            return obj.BD_Buscar_Todos_Roles();
        }

    }
}
