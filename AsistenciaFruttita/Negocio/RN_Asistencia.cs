using AsistenciaFruttita.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaFruttita.Negocio
{
    public class RN_Asistencia
    {
        public DataTable RN_Ver_Todas_Asistencias()
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Ver_Todas_Asistencias();
        }
        public DataTable RN_Asistencias_Entrada(string valor)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Asistencias_Entrada(valor);
        }
        public DataTable RN_Ver_Asistencias()
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Ver_Asistencias();
        }

        public DataTable RN_Ver_Todas_Asistencia_DlDia(DateTime xfecha)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Ver_Todas_Asistencia_DlDia(xfecha);
        }

        public DataTable RN_Ver_Todas_Asistencia_DelMes(DateTime xfecha)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Ver_Todas_Asistencia_DelMes(xfecha);
        }
        public DataTable RN_Ver_Todas_Asistencia_ParaExplorador(string xvalor)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Ver_Todas_Asistencia_ParaExplorador(xvalor);
        }
        public DataTable RN_Ver_Todas_Asistencia_Informe(string xvalor)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Ver_Todas_Asistencia_Informe(xvalor);
        }
        public void RN_Registrar_Entrada_Personal(string idAsis, string idPerso, DateTime HoIngreso, double tarde, int totalHora, string justificado, string seccion, string turno)
        {
            BD_Asistencia obj = new BD_Asistencia();
            obj.BD_Registrar_Entrada_Personal(idAsis, idPerso, HoIngreso, tarde, totalHora, justificado,seccion, turno);
        }
        public void RN_Registrar_Salida_Personal(string idPerso, DateTime HoSalida, int totalHora, int extra, int totalMinutos)
        {
            BD_Asistencia obj = new BD_Asistencia();
            obj.BD_Registrar_Salida_Personal(idPerso, HoSalida, totalHora, extra, totalMinutos);
        }
        public bool RN_Checar_SiPersonal_YaMarco_Asistencia(string xidPerso)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Checar_SiPersonal_YaMarco_Asistencia(xidPerso);
        }
        public bool RN_Checar_SiPersonal_YaMarco_SuEntrada(string xidPerso)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Checar_SiPersonal_YaMarco_SuEntrada(xidPerso);
        }
        public DataTable RN_RegistroLimitaciones(string xidPerso)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_RegistroLimitaciones(xidPerso);
        }
        public bool RN_Verificar_Justificacion_Aprovado(string xidPerso)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Verificar_Justificacion_Aprovado(xidPerso);
        }
        public DataTable RN_Buscar_asistencia_deEntrada(string idperso)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Buscar_asistencia_deEntrada(idperso);
        }
        public bool RN_Checar_SiPersonal_TieneAsistencia_Registrada(string xidPerso)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Checar_SiPersonal_TieneAsistencia_Registrada(xidPerso);
        }
        public bool RN_Checar_SiPersonal_YaMarco_suFalta(string xidPerso)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Checar_SiPersonal_YaMarco_suFalta(xidPerso);
        }
        public void RN_Registrar_Falta_Personal(string idAsis, string idPerso, string justifi)
        {
            BD_Asistencia obj = new BD_Asistencia();
            obj.BD_Registrar_Falta_Personal(idAsis, idPerso, justifi);
        }
        public DataTable RN_asistencia_Mensual(string Idrut, DateTime xfecha1, DateTime xfecha2)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_asistencia_Mensual(Idrut, xfecha1, xfecha2);
        }
        public DataTable RN_Ver_Todas_Asistencia_xRut(string xvalor)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Ver_Todas_Asistencia_xRut(xvalor);
        }
        public DataTable RN_Ver_Faltas(string Idrut, DateTime xfecha1, DateTime xfecha2)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Ver_Faltas(Idrut, xfecha1, xfecha2);
        }
        public DataTable RN_Contar_asistencia(string Idrut, DateTime xfecha1, DateTime xfecha2)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Contar_asistencia(Idrut, xfecha1, xfecha2);
        }
    }
}
