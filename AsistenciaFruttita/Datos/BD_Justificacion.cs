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
    public class BD_Justificacion: Conexion
    {
        public static bool saved = false;
        public static bool editar = false;
        public static bool aprobar = false;
        public void BD_Registrar_Justificacion(EN_Justificacion jus)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Insert_Justification", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Justi", jus.IdJusti);
                cmd.Parameters.AddWithValue("@Id_Personal", jus.Id_Personal);
                cmd.Parameters.AddWithValue("@Principalmoti", jus.PrincipalMotivo);
                cmd.Parameters.AddWithValue("@Detalle", jus.Detalle);
                cmd.Parameters.AddWithValue("@FechaJusti", jus.Fecha);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                saved = true;
            }
            catch (Exception ex)
            {
                saved = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Editar_Justificacion(EN_Justificacion jus)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Modificar_justificacion", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Justi", jus.IdJusti);
                cmd.Parameters.AddWithValue("@Id_Personal", jus.Id_Personal);
                cmd.Parameters.AddWithValue("@Principalmoti", jus.PrincipalMotivo);
                cmd.Parameters.AddWithValue("@Detalle", jus.Detalle);
                cmd.Parameters.AddWithValue("@FechaJusti", jus.Fecha);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                editar = true;
            }
            catch (Exception ex)
            {
                editar = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void BD_Aprovar_Justificacion(string idjusti, string idperso)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Aprobar_justificacion", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdJusti", idjusti);
                cmd.Parameters.AddWithValue("@Id_Personal", idperso);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                aprobar = true;
            }
            catch (Exception ex)
            {
                aprobar = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void BD_Desaprobar_Justificacion(string idjusti, string idperso)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Desaprobar_justificacion", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdJusti", idjusti);
                cmd.Parameters.AddWithValue("@Id_Personal", idperso);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                aprobar = true;
            }
            catch (Exception ex)
            {
                aprobar = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public DataTable BD_Cargar_todos_Justificacion()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Todas_Justificaciones", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dato = new DataTable();

                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public DataTable BD_BuscarJustificacion_xValor(string valor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Justificacion_xDni", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Id_Personal", valor);
                DataTable dato = new DataTable();

                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public static bool eliminar = false;
        public void BD_Eliminar_Justificacion(string idjusti)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Delete_justificacion", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Justi", idjusti);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                eliminar = true;
            }
            catch (Exception ex)
            {
                eliminar = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
