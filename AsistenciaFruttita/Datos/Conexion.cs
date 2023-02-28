using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaFruttita.Datos
{
    public class Conexion
    {
        public string Conectar()
        {
            StreamReader leer;
            leer = new StreamReader(@"c:\ConeccionAsistencia.txt");
            string linea;
            linea = leer.ReadLine();
            return linea;

            //return @"Data Source=DESKTOP-QD5I1N0;Initial Catalog=MicroSisPlani;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            ////return @"Data Source=PC-ADMIN\SQLEXPRESS; Initial Catalog=MicroSisPlani;uid=sa;pwd=admin"; ;
        }

        public static string Conectar2()
        {
            StreamReader leer;
            leer = new StreamReader(@"c:\ConeccionAsistencia.txt");
            string linea;
            linea = leer.ReadLine();
            return linea;

            //return @"Data Source=DESKTOP-QD5I1N0;Initial Catalog=MicroSisPlani;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            ////return @"Data Source=PC-ADMIN\SQLEXPRESS; Initial Catalog=MicroSisPlani;uid=sa;pwd=admin"; ;
        }
    }
}
