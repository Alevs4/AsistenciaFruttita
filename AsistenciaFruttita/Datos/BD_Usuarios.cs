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
    internal class BD_Usuarios: Conexion
    {

        public bool BD_Verificar_Acceso(string Usuario, string Contraseña)
        {
            bool funcionReturValue = false;
            Int32 xfil = 0;

            SqlConnection CN = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();
            CN.ConnectionString = Conectar();

            var resp = Cmd;

            resp.CommandText = "Sp_Login";
            resp.Connection = CN;
            resp.CommandTimeout = 20;
            resp.CommandType = CommandType.StoredProcedure;
            //parametros de entrada
            resp.Parameters.AddWithValue("@Usuario", Usuario);
            resp.Parameters.AddWithValue("@Contraseña", Contraseña);
            try
            {
                CN.Open();
                xfil = (Int32)Cmd.ExecuteScalar();
                if (xfil > 0)
                {
                    funcionReturValue = true;
                }
                else
                {
                    funcionReturValue = false;
                }
                Cmd.Parameters.Clear();
                Cmd.Dispose();
                Cmd = null;
                CN.Close();
                CN = null;
            }
            catch (Exception ex)
            {
                if (CN.State == ConnectionState.Open)
                    CN.Close();
                Cmd.Dispose();
                Cmd = null;
                CN.Close();
                CN = null;
                MessageBox.Show("Algo malo pasó: " + ex.Message, "Advertencia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            return funcionReturValue;
        }
        public DataTable BD_Lerr_Datos_Usuario(string Usuario)
        {
            SqlConnection CN = new SqlConnection();
            try
            {
                CN.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Usuario_Login", CN);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Usuario", Usuario);
                DataTable dt = new DataTable();

                da.Fill(dt);
                da = null;
                return dt;

            }
            catch (Exception ex)
            {
                if (CN.State == ConnectionState.Open)
                    CN.Close();
                CN = null;
                MessageBox.Show("Error" + ex.Message, "advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
