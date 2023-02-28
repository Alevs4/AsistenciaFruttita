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
    public class RN_Personal
    {
        public void RN_Registrar_Personal(EN_Persona per)
        {
            BD_Personal obj = new BD_Personal();
            obj.BD_Registrar_Personal(per);
        }
        public void RN_Desactivar_Personal(string persona)
        {
            BD_Personal obj = new BD_Personal();
            obj.BD_Desactivar_Personal(persona);
        }

        public void RN_Editar_Personal(EN_Persona per)
        {
            BD_Personal obj = new BD_Personal();
            obj.BD_Editar_Personal(per);
        }
        public void RN_Editar_Turno(EN_Persona per)
        {
            BD_Personal obj = new BD_Personal();
            obj.BD_Editar_Turno(per);
        }

        public void RN_Registrar_Huella_Personal(string idper, object finguer)
        {
            BD_Personal obj = new BD_Personal();
            obj.BD_Registrar_Huella_Personal(idper, finguer);
        }
        public DataTable RN_Leer_todaPersona()
        {
            BD_Personal obj = new BD_Personal();
            return obj.BD_Leer_todaPersona();

        }
        public DataTable RN_Informe_todaPersona()
        {
            BD_Personal obj = new BD_Personal();
            return obj.BD_Informe_todaPersona();

        }
        public DataTable RN_Buscar_personal_xValor(string valor)
        {
            BD_Personal obj = new BD_Personal();
            return obj.BD_Buscar_personal_xValor(valor);
        }

        public bool RN_Verificar_RutPersonal(string rut)
        {
            BD_Personal obj = new BD_Personal();
            return obj.BD_Verificar_RutPersonal(rut);
        }
        public void RN_EliminarPersonal(string persona)
        {
            BD_Personal obj = new BD_Personal();
            obj.BD_EliminarPersonal(persona);
        }
    }
}
