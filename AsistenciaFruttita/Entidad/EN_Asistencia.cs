using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaFruttita.Entidad
{
    public class EN_Asistencia
    {
        string _idAsistencia;
        string _Id_Personal;
        DateTime _FechaAsi;
        DateTime _HoraIngre;
        DateTime _HoraSalida;
        int _Tardanza;
        int _Extra;
        int _minutos;
        double _TotalHoras;
        string _Justificacion;
        double _Adelanto;

        string _identificador;
        string _Nombre_Dia;
        string _estado_Asi;
        string _Seccion;

        public string Id_asis { get => _idAsistencia; set => _idAsistencia = value; }
        public string Id_Pernl { get => _Id_Personal; set => _Id_Personal = value; }
        public DateTime FechaAsis { get => _FechaAsi; set => _FechaAsi = value; }
        public DateTime HoIngreso { get => _HoraIngre; set => _HoraIngre = value; }
        public DateTime HoSalida { get => _HoraSalida; set => _HoraSalida = value; }
        public int Tardanza { get => _Tardanza; set => _Tardanza = value; }
        public int Extra { get => _Extra; set => _Extra = value; }
        public int Minutos { get => _minutos; set => _minutos = value; }
        public double Total_HrsWorked { get => _TotalHoras; set => _TotalHoras = value; }
        public string Justifacion { get => _Justificacion; set => _Justificacion = value; }
        public double Adelanto { get => _Adelanto; set => _Adelanto = value; }
        public string Identificador { get => _identificador; set => _identificador = value; }
        public string Nombre_Dia { get => _Nombre_Dia; set => _Nombre_Dia = value; }
        public string EstadoAsis { get => _estado_Asi; set => _estado_Asi = value; }
        public string Seccion { get => _Seccion; set => _Seccion = value; }
    }
}
