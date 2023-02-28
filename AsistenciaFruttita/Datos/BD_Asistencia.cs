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
    public class BD_Asistencia: Conexion
    {
        public DataTable BD_Ver_Todas_Asistencias()
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Todas_Asistencias", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //da.SelectCommand.Parameters.AddWithValue("@fecha", xdia);
                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error" + ex.Message);
                }
            }
            return null;
        }
        public DataTable BD_Asistencias_Entrada(string valor)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_ASISTENCIA_ENTRADA", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Id_Asis", valor);
                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error" + ex.Message);
                }
            }
            return null;
        }
        public DataTable BD_Ver_Asistencias()
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Asistencias", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //da.SelectCommand.Parameters.AddWithValue("@fecha", xdia);
                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error" + ex.Message);
                }
            }
            return null;
        }
        public DataTable BD_Ver_Faltas(string Idrut, DateTime xfecha1, DateTime xfecha2)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_Faltas", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@DNI", Idrut);
                da.SelectCommand.Parameters.AddWithValue("@Fecha1", xfecha1);
                da.SelectCommand.Parameters.AddWithValue("@Fecha2", xfecha2);
                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error" + ex.Message);
                }
            }
            return null;
        }
        public DataTable BD_Ver_Todas_Asistencia_DlDia(DateTime xfecha)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Asistencia_deldia", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fecha", xfecha);
                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error" + ex.Message);
                }
            }
            return null;
        }
        public DataTable BD_asistencia_Mensual(string Idrut, DateTime xfecha1, DateTime xfecha2)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_ASISTENCIA_MENSUAL", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@DNI", Idrut);
                da.SelectCommand.Parameters.AddWithValue("@Fecha1", xfecha1);
                da.SelectCommand.Parameters.AddWithValue("@Fecha2", xfecha2);
                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error" + ex.Message);
                }
            }
            return null;
        }
        public DataTable BD_Contar_asistencia(string Idrut, DateTime xfecha1, DateTime xfecha2)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_CONTAR_ASISTENCIA", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@DNI", Idrut);
                da.SelectCommand.Parameters.AddWithValue("@Fecha1", xfecha1);
                da.SelectCommand.Parameters.AddWithValue("@Fecha2", xfecha2);
                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error" + ex.Message);
                }
            }
            return null;
        }
        public DataTable BD_Ver_Todas_Asistencia_DelMes(DateTime xfecha)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Asistencia_xFecha", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fecha", xfecha);
                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error" + ex.Message);
                }
            }
            return null;
        }
        public DataTable BD_Ver_Todas_Asistencia_ParaExplorador(string xvalor)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Buscar_Asistencia_paraExplorador", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Id_Asis", xvalor);
                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error" + ex.Message);
                }
            }
            return null;
        }
        public DataTable BD_Ver_Todas_Asistencia_Informe(string xvalor)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_Informe_asistencia", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Id_Asis", xvalor);
                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error" + ex.Message);
                }
            }
            return null;
        }
        public DataTable BD_Ver_Todas_Asistencia_xRut(string xvalor)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_Informe_asistencia_Rut", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Dni", xvalor);
                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error" + ex.Message);
                }
            }
            return null;
        }
        //Registrar asistencia
        public static bool entrada = false;
        public static bool salida = false;
        public void BD_Registrar_Entrada_Personal(string idAsis, string idPerso, DateTime HoIngreso, double tarde, int totalHora, string justificado,string seccion, string turno)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Registrar_Entrada", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //Parametros
                cmd.Parameters.AddWithValue("@IdAsis", idAsis);
                cmd.Parameters.AddWithValue("@Id_Persol", idPerso);
                cmd.Parameters.AddWithValue("@HoIngre", HoIngreso);
                cmd.Parameters.AddWithValue("@tardanza", tarde);
                cmd.Parameters.AddWithValue("@TotalHora", totalHora);
                cmd.Parameters.AddWithValue("@justificado", justificado);
                cmd.Parameters.AddWithValue("@seccion", seccion);
                cmd.Parameters.AddWithValue("@turno", turno);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                entrada = true;
            }
            catch (Exception ex)
            {
                entrada = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                throw new Exception("Error" + ex.Message, ex);
            }
        }
        public void BD_Registrar_Salida_Personal(string idPerso, DateTime HoSalida, int totalHora, int extra, int totalMinutos)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Registrar_Salida", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //Parametros

                cmd.Parameters.AddWithValue("@Id_pernl", idPerso);
                cmd.Parameters.AddWithValue("@HoSalida", HoSalida);
                cmd.Parameters.AddWithValue("@TotalHora", totalHora);
                cmd.Parameters.AddWithValue("@Extra", extra);
                cmd.Parameters.AddWithValue("@TotalMinutos", totalMinutos);


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                salida = true;
            }
            catch (Exception ex)
            {
                salida = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                throw new Exception("Error" + ex.Message, ex);
            }
        }

        //Verificaciones

        public bool BD_Checar_SiPersonal_YaMarco_Asistencia(string xidPerso)
        {
            bool functionReturnValue = false;
            Int32 xfil = 0;

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Conectar();
            var with1 = cmd;
            with1.CommandText = "Sp_Validar_RegistroAsistencia";
            with1.Connection = cn;
            with1.CommandTimeout = 20;
            with1.CommandType = CommandType.StoredProcedure;
            with1.Parameters.AddWithValue("@Id_Personal", xidPerso);
            try
            {
                cn.Open();
                xfil = (Int32)cmd.ExecuteScalar();
                if (xfil > 0)
                {
                    functionReturnValue = true;
                }
                else
                {
                    functionReturnValue = false;
                }
                cmd.Parameters.Clear();
                cmd.Dispose();
                cmd = null;
                cn.Close();
                cn = null;


            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                cmd.Dispose();
                cmd = null;
                cn.Close();
                cn = null;
                MessageBox.Show("Error" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return functionReturnValue;
        }
        //public DataTable BD_Checar_SiPersonal_YaMarco_SuEntrada(string xidPerso)
        //{
        //    SqlConnection xcn = new SqlConnection();
        //    try
        //    {
        //        xcn.ConnectionString = Conectar();
        //        SqlDataAdapter da = new SqlDataAdapter("Sp_verificar_IngresoAsis", xcn);
        //        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //        da.SelectCommand.Parameters.AddWithValue("@Id_Personal", xidPerso);
        //        DataTable dato = new DataTable();
        //        da.Fill(dato);
        //        da = null;
        //        return dato;
        //    }
        //    catch (Exception ex)
        //    {
        //        if (xcn.State == ConnectionState.Open)
        //        {
        //            xcn.Close();
        //            throw new Exception("Error" + ex.Message);
        //        }
        //    }
        //    return null;
        //}

        public DataTable BD_RegistroLimitaciones(string xidPerso)
        { 
           
            SqlConnection cn = new SqlConnection();
            try
            {
          
            cn.ConnectionString = Conectar();           
            string query = "Select * from ASISTENCIAPER where Id_Pernl = @id_pernl and EstadoAsis='Entrada'";
            SqlDataAdapter cmd = new SqlDataAdapter(query, cn);
            cmd.SelectCommand.Parameters.AddWithValue("@id_pernl", xidPerso);

            DataTable dt = new DataTable();
            cmd.Fill(dt);

            return dt;
    
            }
            catch(Exception ex) {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                    throw new Exception("Error" + ex.Message);
                }
            }


            return null;
        }
        public bool BD_Checar_SiPersonal_YaMarco_SuEntrada(string xidPerso)
        {
            bool functionReturnValue = false;
            Int32 xfil = 0;

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Conectar();
            var with1 = cmd;
            with1.CommandText = "Sp_verificar_IngresoAsis";
            with1.Connection = cn;
            with1.CommandTimeout = 20;
            with1.CommandType = CommandType.StoredProcedure;
            with1.Parameters.AddWithValue("@Id_Personal", xidPerso);
            try
            {
                cn.Open();
                xfil = (Int32)cmd.ExecuteScalar();
                if (xfil > 0)
                {
                    functionReturnValue = true;
                }
                else
                {
                    functionReturnValue = false;
                }
                cmd.Parameters.Clear();
                cmd.Dispose();
                cmd = null;
                cn.Close();
                cn = null;


            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                cmd.Dispose();
                cmd = null;
                cn.Close();
                cn = null;
                MessageBox.Show("Error" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return functionReturnValue;
        }
        public bool BD_Verificar_Justificacion_Aprovado(string xidPerso)
        {
            bool functionReturnValue = false;
            Int32 xfil = 0;

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Conectar();
            var with1 = cmd;
            with1.CommandText = "SP_VerificarJustificacion_Aprobada";
            with1.Connection = cn;
            with1.CommandTimeout = 20;
            with1.CommandType = CommandType.StoredProcedure;
            with1.Parameters.AddWithValue("@Id_Personal", xidPerso);
            try
            {
                cn.Open();
                xfil = (Int32)cmd.ExecuteScalar();
                if (xfil > 0)
                {
                    functionReturnValue = true;
                }
                else
                {
                    functionReturnValue = false;
                }
                cmd.Parameters.Clear();
                cmd.Dispose();
                cmd = null;
                cn.Close();
                cn = null;


            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                cmd.Dispose();
                cmd = null;
                cn.Close();
                cn = null;
                MessageBox.Show("Error" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return functionReturnValue;
        }
        public DataTable BD_Buscar_asistencia_deEntrada(string idperso)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Leer_asistencia_reciente", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idper", idperso);
                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error" + ex.Message);
                }
            }
            return null;
        }
        public bool BD_Checar_SiPersonal_TieneAsistencia_Registrada(string xidPerso)
        {
            bool functionReturnValue = false;
            Int32 xfil = 0;

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Conectar();
            var with1 = cmd;
            with1.CommandText = "Sp_Ver_sihay_Registro";
            with1.Connection = cn;
            with1.CommandTimeout = 20;
            with1.CommandType = CommandType.StoredProcedure;
            with1.Parameters.AddWithValue("@Id_Personal", xidPerso);
            try
            {
                cn.Open();
                xfil = (Int32)cmd.ExecuteScalar();
                if (xfil > 0)
                {
                    functionReturnValue = true;
                }
                else
                {
                    functionReturnValue = false;
                }
                cmd.Parameters.Clear();
                cmd.Dispose();
                cmd = null;
                cn.Close();
                cn = null;


            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                cmd.Dispose();
                cmd = null;
                cn.Close();
                cn = null;
                MessageBox.Show("Error" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return functionReturnValue;
        }
        public bool BD_Checar_SiPersonal_YaMarco_suFalta(string xidPerso)
        {
            bool functionReturnValue = false;
            Int32 xfil = 0;

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Conectar();
            var with1 = cmd;
            with1.CommandText = "Sp_Verificar_siMarco_Falta";
            with1.Connection = cn;
            with1.CommandTimeout = 20;
            with1.CommandType = CommandType.StoredProcedure;
            with1.Parameters.AddWithValue("@Id_Personal", xidPerso);
            try
            {
                cn.Open();
                xfil = (Int32)cmd.ExecuteScalar();
                if (xfil > 0)
                {
                    functionReturnValue = true;
                }
                else
                {
                    functionReturnValue = false;
                }
                cmd.Parameters.Clear();
                cmd.Dispose();
                cmd = null;
                cn.Close();
                cn = null;


            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                cmd.Dispose();
                cmd = null;
                cn.Close();
                cn = null;
                MessageBox.Show("Error" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return functionReturnValue;
        }
        public static bool FaltasCheck = false;
        public void BD_Registrar_Falta_Personal(string idAsis, string idPerso, string justifi)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Registrar_Falta", cn);

            try
             {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //Parametros
                cmd.Parameters.AddWithValue("@IdAsis", idAsis);
                cmd.Parameters.AddWithValue("@Id_Personal", idPerso);
                cmd.Parameters.AddWithValue("@justificacion", justifi);



                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                FaltasCheck = true;
            }
            catch (Exception ex)
            {
                FaltasCheck = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                throw new Exception("Error" + ex.Message, ex);
            }
        }
    }
}
