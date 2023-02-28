using AsistenciaFruttita.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistenciaFruttita.Datos
{
    internal class BD_Horario : Conexion
    {
        public static bool sabed = false;
        public void BD_ACtualizar_horario(EN_Horario p)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = cn.CreateCommand();

            try
            {
                cn.ConnectionString = Conectar();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sp_Update_Horario";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                //agrego los parametros
                cmd.Parameters.AddWithValue("@Idhor", p.Idhora);
                cmd.Parameters.AddWithValue("@HoEntrada", p.HoEntrada);
                cmd.Parameters.AddWithValue("@HoTolere", p.HoTole);
                cmd.Parameters.AddWithValue("@Holimite", p.HoLimite);
                cmd.Parameters.AddWithValue("@HoraSalida", p.HoSalida);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                cmd.Dispose();
                cmd = null;
                cn.Dispose();
                cn = null;

                sabed = true;
            }
            catch (Exception ex)
            {
                sabed = false;
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable Bd_Leer_Horarios()
        {
            SqlConnection Cn = new SqlConnection();
            try
            {
                Cn.ConnectionString = Conectar();
                SqlDataAdapter Da = new SqlDataAdapter("Sp_Buscar_Todos_Horarios", Cn);
                Da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //Da.SelectCommand.Parameters.AddWithValue("@Id_ped", Id);
                DataTable Datos = new DataTable();
                Da.Fill(Datos);
                Da = null;
                return Datos;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Herror al consultar Horario" + ex.Message, "Informe de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (Cn.State == ConnectionState.Open) Cn.Close();
                Cn.Dispose();
                Cn = null;
                return null;
            }
        }
    }
}
