using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaFruttita.Datos
{
    public class BD_Distrito: Conexion
    {
        public DataTable BD_Buscar_Todos_Distrito()
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Ver_Todo_Distrito", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable Dato = new DataTable();
                da.Fill(Dato);
                da = null;
                return Dato;

            }
            catch (Exception ex)
            {

                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error" + ex.Message, ex);

                }

            }
            return null;
        }
    }
}
