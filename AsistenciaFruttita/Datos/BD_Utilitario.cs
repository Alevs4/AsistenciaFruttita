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
    public class BD_Utilitario: Conexion
    {
        public static string BD_NroDoc(int Id_Tipo)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar2();
                SqlCommand da = new SqlCommand("Sp_Listado_Tipo", xcn);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@Id_Tipo", Id_Tipo);
                string NroDoc;

                xcn.Open();
                NroDoc = Convert.ToString(da.ExecuteScalar());
                xcn.Close();
                return NroDoc;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                if (xcn.State == ConnectionState.Open) xcn.Close();
                xcn.Dispose();
                xcn = null;
                return null;
            }

        }
        public static void BD_Actualiza_Tipo_Doc(int Id_Tipo)
        {
            SqlConnection xcn = new SqlConnection(Conectar2());
            SqlCommand da = new SqlCommand("Sp_Actualiza_Tipo_Doc", xcn);
            try
            {

                da.CommandTimeout = 20;
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@Id_Tipo", Id_Tipo);
                xcn.Open();
                da.ExecuteNonQuery();
                xcn.Close();
                da.Dispose();
                da = null;
                xcn = null;

            }
            catch (Exception ex)
            {

                if (xcn.State == ConnectionState.Open) xcn.Close();
                xcn.Dispose();
                xcn = null;
                MessageBox.Show("Error" + ex.Message);
            }

        }
        //listar tipo robot
        public static string BD_Listar_TipoFaltas(int Id_Tipo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand("Sp_Listado_TipoFalta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Tipo", Id_Tipo);
                string NroDoc;

                cn.Open();
                NroDoc = Convert.ToString(cmd.ExecuteScalar());
                cn.Close();
                return NroDoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Dispose();
                cn = null;
                return null;
            }
        }

        public static bool falta = false;
        public void BD_Actualizar_RobotFalta(int Id_Tipo, string serie)
        {
            SqlConnection xcn = new SqlConnection(Conectar2());
            SqlCommand da = new SqlCommand("Sp_Activar_Desac_RobotFalta", xcn);
            try
            {

                da.CommandTimeout = 20;
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@IdTipo", Id_Tipo);
                da.Parameters.AddWithValue("@serie", serie);
                xcn.Open();
                da.ExecuteNonQuery();
                xcn.Close();
                falta = true;


            }
            catch (Exception ex)
            {
                falta = false;
                MessageBox.Show("Error" + ex.Message);
                if (xcn.State == ConnectionState.Open) xcn.Close();


            }

        }
    }
}
