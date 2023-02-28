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
    public class BD_Personal: Conexion
    {

        public static bool saved = false;
        public static bool editar = false;
        //Metodo Para Registrar Personal
        public void BD_Registrar_Personal(EN_Persona per)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Insert_Personal", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //agregamos los parametros del precedimiento de almacenado
                cmd.Parameters.AddWithValue("@Id_Person", per.Idpersonal);
                cmd.Parameters.AddWithValue("@dni", per.Dni);
                cmd.Parameters.AddWithValue("@nombreComplto", per.Nombres);
                cmd.Parameters.AddWithValue("@FechaNacmnto", per.anoNacimiento);
                cmd.Parameters.AddWithValue("@Sexo", per.Sexo);
                //cmd.Parameters.AddWithValue("@Domicilio", per.Direccion);
                //cmd.Parameters.AddWithValue("@Correo", per.Correo);
                cmd.Parameters.AddWithValue("@Celular", per.Celular);
                cmd.Parameters.AddWithValue("@Id_rol", per.IdRol);
                cmd.Parameters.AddWithValue("@Foto", per.xImagen);
                cmd.Parameters.AddWithValue("@Id_Distrito", per.IdDistrito);
                cmd.Parameters.AddWithValue("@rol", per.Rol);
                cmd.Parameters.AddWithValue("@turno", per.Turno);
                cmd.Parameters.AddWithValue("@fechacambio", per.CambioTurno);
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
        //Metodo para Editar Personal
        public void BD_Editar_Personal(EN_Persona per)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Update_Personal", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //agregamos los parametros del precedimiento de almacenado
                cmd.Parameters.AddWithValue("@Id_Person", per.Idpersonal);
                //cmd.Parameters.AddWithValue("@dni", per.Dni);
                cmd.Parameters.AddWithValue("@nombreComplto", per.Nombres);
                cmd.Parameters.AddWithValue("@FechaNacmnto", per.anoNacimiento);
                cmd.Parameters.AddWithValue("@Sexo", per.Sexo);
                //cmd.Parameters.AddWithValue("@Domicilio", per.Direccion);
                //cmd.Parameters.AddWithValue("@Correo", per.Correo);
                cmd.Parameters.AddWithValue("@Celular", per.Celular);
                cmd.Parameters.AddWithValue("@Id_rol", per.IdRol);
                cmd.Parameters.AddWithValue("@Foto", per.xImagen);
                cmd.Parameters.AddWithValue("@Id_Distrito", per.IdDistrito);
                cmd.Parameters.AddWithValue("@rol", per.Rol);
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
        public void BD_Editar_Turno(EN_Persona per)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("update PERSONAL set Rol = @rol, Turno = @turno, FechaCambio = @fechacambio where Id_Pernl=@Id_Person", cn);
            SqlCommand cmd2 = new SqlCommand("insert into CambiosTurnos(Id_personal,Rol,Turno,FechaCambio) values(@Id_Person,@rol, @turno, @fechacambio)", cn);
            try
            {
                cmd2.CommandTimeout = 20;
                cmd2.CommandType = CommandType.Text;
                //agregamos los parametros del precedimiento de almacenado
                cmd2.Parameters.AddWithValue("@Id_Person", per.Idpersonal);
                cmd2.Parameters.AddWithValue("@rol", per.Rol);
                cmd2.Parameters.AddWithValue("@turno", per.Turno);
                cmd2.Parameters.AddWithValue("@fechacambio", per.CambioTurno);
                cn.Open();
                cmd2.ExecuteNonQuery();
                cn.Close();
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.Text;
                //agregamos los parametros del precedimiento de almacenado
                cmd.Parameters.AddWithValue("@Id_Person", per.Idpersonal);
                cmd.Parameters.AddWithValue("@rol", per.Rol);
                cmd.Parameters.AddWithValue("@turno", per.Turno);
                cmd.Parameters.AddWithValue("@fechacambio", per.CambioTurno);
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
        public static bool eliminar = false;
        public void BD_EliminarPersonal(string persona)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_TRABAJADOR", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //agregamos los parametros del precedimiento de almacenado
                cmd.Parameters.AddWithValue("@Rut", persona);

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
        public static bool huella = false;
        //metodo Para registrar la huella dactilar
        public void BD_Registrar_Huella_Personal(string idper, object finguer)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Actualizar_FinguerPrint", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                //ingresamos los parametros del procedimiento de almacenado
                cmd.Parameters.AddWithValue("@IdPersona", idper);
                cmd.Parameters.AddWithValue("@finguerPrint", finguer);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                huella = true;
            }
            catch (Exception ex)
            {
                huella = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //metodo para leer todas las personas registradas
        public DataTable BD_Leer_todaPersona()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_Listar_Personal", cn);
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
        public DataTable BD_Informe_todaPersona()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_Informe_Personal", cn);
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
        public DataTable BD_Buscar_personal_xValor(string valor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_PersonalxDni", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Dni", valor);
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
        public bool BD_Verificar_RutPersonal(string rut)
        {
            bool funcionReturValue = false;
            Int32 xfil = 0;

            SqlConnection CN = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();
            CN.ConnectionString = Conectar();

            var resp = Cmd;

            resp.CommandText = "Sp_Validar_Dni";
            resp.Connection = CN;
            resp.CommandTimeout = 20;
            resp.CommandType = CommandType.StoredProcedure;
            //parametros de entrada
            resp.Parameters.AddWithValue("@Dni", rut);

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
        public static bool desactivar = false;
        public void BD_Desactivar_Personal(string persona)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Eliminar_Personal", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //agregamos los parametros del precedimiento de almacenado
                cmd.Parameters.AddWithValue("@dni", persona);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                desactivar = true;

            }
            catch (Exception ex)
            {
                desactivar = false;

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
