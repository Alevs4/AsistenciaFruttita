using AsistenciaFruttita.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaFruttita.Negocio
{
    public class RN_Utilitario
    {
        public static string RN_NroDoc(int Id_Tipo)
        {
            return BD_Utilitario.BD_NroDoc(Id_Tipo);
        }

        public static void RN_Actualiza_Tipo_Doc(int Id_Tipo)
        {
            BD_Utilitario.BD_Actualiza_Tipo_Doc(Id_Tipo);
        }
        public static string RN_Listar_TipoFaltas(int Id_Tipo)
        {
            return BD_Utilitario.BD_Listar_TipoFaltas(Id_Tipo);
        }
        public void RN_Actualizar_RobotFalta(int Id_Tipo, string serie)
        {
            BD_Utilitario obj = new BD_Utilitario();
            obj.BD_Actualizar_RobotFalta(Id_Tipo, serie);
        }
    }
}
