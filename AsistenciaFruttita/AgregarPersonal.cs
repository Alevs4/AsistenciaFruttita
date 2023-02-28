using AsistenciaFruttita.Datos;
using AsistenciaFruttita.Entidad;
using AsistenciaFruttita.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistenciaFruttita
{
    public partial class AgregarPersonal : Form
    {
        public AgregarPersonal()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool editPerso = false;
        private void AgregarPersonal_Load(object sender, EventArgs e)
        {
            //Cargar_rol();
            //Cargar_Distrito();
        }
        //private void Cargar_rol()
        //{
        //    RN_Rol obj = new RN_Rol();
        //    DataTable dt = new DataTable();

        //    try
        //    {
        //        dt = obj.RN_Buscar_Todos_Roles();
        //        if (dt.Rows.Count > 0)
        //        {
        //            var cbo = cbo_rol;
        //            cbo.DataSource = dt;
        //            cbo.DisplayMember = "NomRol";
        //            cbo.ValueMember = "Id_Rol";
        //        }
        //        cbo_rol.SelectedIndex = -1;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        //private void Cargar_Distrito()
        //{
        //    RN_Distrito obj = new RN_Distrito();
        //    DataTable dt = new DataTable();

        //    try
        //    {
        //        dt = obj.RN_Buscar_Todos_Distrito();
        //        if (dt.Rows.Count > 0)
        //        {
        //            var cbo = cbo_Distrito;
        //            cbo.DataSource = dt;
        //            cbo.DisplayMember = "Distrito";
        //            cbo.ValueMember = "Id_Distrito";
        //        }
        //        cbo_Distrito.SelectedIndex = -1;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        private bool ValidarCajasTexto()
        {
       
            if (TxtRut.Text.Trim()== "") {MessageBox.Show("Debe ingresar el rut","Verificar",MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ; return false; }
            if (txt_nombres.Text.Trim().Length < 10) { MessageBox.Show("Ingrese el Nombre","Informacion" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            //if (txt_direccion.Text.Trim().Length < 10) { fil.Show(); adv.Lbl_Msm1.Text = "Ingresar La Direccion"; adv.ShowDialog(); fil.Hide(); txt_Dni.Focus(); return false; }
            //if (txt_correo.Text.Trim().Length < 10) { fil.Show(); adv.Lbl_Msm1.Text = "Ingresar Correo"; adv.ShowDialog(); fil.Hide(); txt_Dni.Focus(); return false; }
            if (txt_NroCelular.Text.Trim().Length < 9) { MessageBox.Show("Ingrese Numero de Celular", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            if (txt_IdPersona.Text.Trim().Length < 10) { MessageBox.Show("El ID no fue Generado", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            //if (cbo_sexo.SelectedIndex == -1) { MessageBox.Show("Seleccione Sexo", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            //if (cbo_rol.SelectedIndex == -1) { MessageBox.Show("Seleccione Cargo de la Persona", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            //if (cbo_Distrito.SelectedIndex == -1) { MessageBox.Show("Seleccione Localidad", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
           

            return true;
        }
        private string formatoRut(string rut)
        {
            int cont = 0;
            string format;
            rut = rut.Replace(".", "");
            rut = rut.Replace("-", "");
            format = "-" + rut.Substring(rut.Length - 1);
            for (int i = rut.Length - 2; i >= 0; i--)
            {
                format = rut.Substring(i, 1) + format;
                cont++;
                if (cont == 3 && i != 0)
                {
                    format = "." + format;
                    cont = 0;
                }
            }
            return format;
        }


        private bool validarRut(string rut)
        {
            bool validacion = false;
            rut = rut.ToUpper();
            rut = rut.Replace(".", "");
            rut = rut.Replace("-", "");
            int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
            char dv = char.Parse(rut.Substring(rut.Length - 1, 1));
            int m = 0, s = 1;
            for (; rutAux != 0; rutAux /= 10)
            {
                s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
            }
            if (dv == (char)(s != 0 ? s + 47 : 75))
            {
                validacion = true;
            }
            return validacion;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            RN_Personal Personal = new RN_Personal();
            bool respuesta = false;
            string rut = TxtRut.Text;
            TxtRut.Text = formatoRut(rut);
            rut = TxtRut.Text;
            respuesta = validarRut(rut);

            if (respuesta == false)
            {

                TxtRut.BackColor = Color.Red;
                MessageBox.Show("Rut Incorrecto");
                TxtRut.Text = "";
                TxtRut.BackColor = Color.White;
                TxtRut.Focus();
            }
            else
            {
                TxtRut.ForeColor = Color.Black;
                TxtRut.BackColor = Color.GreenYellow;
                // MessageBox.Show("Rut OK");
           

            if (ValidarCajasTexto() == false) return;
            //if (xedit == false)

            if (Personal.RN_Verificar_RutPersonal(txt_IdPersona.Text) == true)
            {
                MessageBox.Show("El Rut ya se encuentra Registrado", "Verifica los Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }
            else
            {

                Guardar_Personal();

            }
        } 
        }

            private void Guardar_Personal()
            {
                
                RN_Personal obj = new RN_Personal();
                EN_Persona per = new EN_Persona();

                MemoryStream ms = new MemoryStream();
                Pic_persona.Image.Save(ms, ImageFormat.Jpeg);
                byte[] foto = ms.ToArray();
                try
                {
                    per.Idpersonal = txt_IdPersona.Text;
                    per.Dni = TxtRut.Text;
                    per.Nombres = txt_nombres.Text;
                    per.anoNacimiento = dtp_fechaNaci.Value;
                    per.Sexo = cbo_sexo.Text;
                    //per.Direccion = txt_direccion.Text;
                    //per.Correo = txt_correo.Text;
                    per.Celular = Convert.ToInt32(txt_NroCelular.Text);
                    per.IdRol = Convert.ToString(cbo_rol.SelectedItem);
                    per.xImagen = foto;
                    per.IdDistrito = Convert.ToString(cbo_Distrito.SelectedItem);
                    per.Rol = Convert.ToString(CboRol.SelectedItem);
                    per.Turno = Convert.ToString(CboTurno.SelectedItem);
                    per.CambioTurno = DTP_Cambio.Value;
                    obj.RN_Registrar_Personal(per);

                    if (BD_Personal.saved == true)
                    {
            
                        MessageBox.Show("Persona Agregada Correctamente","Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Tag = "A";
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        private void Editar_Personal()
        {
          
            RN_Personal obj = new RN_Personal();
            EN_Persona per = new EN_Persona();

            MemoryStream ms = new MemoryStream();
            Pic_persona.Image.Save(ms, ImageFormat.Jpeg);
            byte[] foto = ms.ToArray();
            try
            {
                per.Idpersonal = txt_IdPersona.Text;
                //per.Dni = TxtRut.Text;
                per.Nombres = txt_nombres.Text;
                per.anoNacimiento = dtp_fechaNaci.Value;
                per.Sexo = cbo_sexo.Text;
                //per.Direccion = txt_direccion.Text;
                //per.Correo = txt_correo.Text;
                per.Celular = Convert.ToInt32(txt_NroCelular.Text);
                per.IdRol = Convert.ToString(cbo_rol.SelectedItem);
                per.xImagen = foto;
                per.IdDistrito = Convert.ToString(cbo_Distrito.SelectedItem);
                per.Rol = Convert.ToString(CboRol.SelectedItem);
                obj.RN_Editar_Personal(per);

                if (BD_Personal.editar == true)
                {
                  MessageBox.Show("Personal Modificado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Tag = "A";
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Editar_Turno()
        {

            RN_Personal obj = new RN_Personal();
            EN_Persona per = new EN_Persona();
            try
            {
                per.Idpersonal = txt_IdPersona.Text;
                per.Rol = Convert.ToString(CboRol.SelectedItem);
                per.CambioTurno = DTP_Cambio.Value;         
                per.Turno = Convert.ToString(CboTurno.SelectedItem);
                obj.RN_Editar_Turno(per);

                if (BD_Personal.editar == true)
                {
                    MessageBox.Show("Personal Modificado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Tag = "A";
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarCajasTexto() == false) return;
            bool respuesta = false;
            string rut = TxtRut.Text;
            TxtRut.Text = formatoRut(rut);
            rut = TxtRut.Text;
            respuesta = validarRut(rut);

            if (respuesta == false)
            {

                TxtRut.BackColor = Color.Red;
                MessageBox.Show("Rut Incorrecto");
                TxtRut.Text = "";
                TxtRut.BackColor = Color.White;
                TxtRut.Focus();
            }
            else
            {
                TxtRut.ForeColor = Color.Black;
                TxtRut.BackColor = Color.GreenYellow;
                 Editar_Personal();
            }
          
        }

        private void Pic_persona_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes|*.jpg; *.png; *.jpeg";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar imagen";
            try
            {
                if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
                {
                    Pic_persona.Image = Image.FromFile(ofdSeleccionar.FileName);
                }
            }
            catch (Exception ex)
            {

                Pic_persona.Load(Application.StartupPath + @"\user.png");
            }
        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios U = new Utilitarios();
                U.Mover_formulario(this);
            }
        }

        private void botonesRedondos2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool xedit = false;
        private void txt_NroCelular_TextChanged(object sender, EventArgs e)
        {
            string xcar1, xcar2;

            if (xedit == false)
            {
                if (TxtRut.Text.Length == 0) return;
                if (txt_nombres.Text.Length == 0) return;
                xcar1 = Convert.ToString(TxtRut.Text).Substring(3, 5);
                xcar2 = Convert.ToString(txt_nombres.Text).Substring(0, 4);
                txt_IdPersona.Text = xcar1 + "-" + xcar2;
            }

        }
        public void Buscar_personal_ParaEditar(string id)
        {
            try
            {
                RN_Personal obj = new RN_Personal();
                DataTable dt = new DataTable();

 
                dt = obj.RN_Buscar_personal_xValor(id);
                if (dt.Rows.Count == 0) return;
                {
                    TxtRut.Text = Convert.ToString(dt.Rows[0]["DNIPR"]);
                    txt_nombres.Text = Convert.ToString(dt.Rows[0]["Nombre_completo"]);
                    //txt_direccion.Text = Convert.ToString(dt.Rows[0]["Domicilio"]);
                    //txt_correo.Text = Convert.ToString(dt.Rows[0]["Correo"]);
                    txt_NroCelular.Text = Convert.ToString(dt.Rows[0]["Celular"]);                   
                    cbo_sexo.Text = Convert.ToString(dt.Rows[0]["Sexo"]);
                    cbo_Distrito.Text = Convert.ToString(dt.Rows[0]["Id_Distrito"]);
                    cbo_rol.Text = Convert.ToString(dt.Rows[0]["Id_rol"]);
                    txt_IdPersona.Text = Convert.ToString(dt.Rows[0]["Id_Pernl"]);
                    CboRol.Text =Convert.ToString( dt.Rows[0]["Rol"]); 
                    txt_IdPersona.Text = Convert.ToString(dt.Rows[0]["Id_Pernl"]);
                    Txtestado.Text = Convert.ToString(dt.Rows[0]["Estado_Per"]);
                    dtp_fechaNaci.Value = Convert.ToDateTime(dt.Rows[0]["Fec_Naci"]);
                    DTP_Cambio.Value = Convert.ToDateTime(dt.Rows[0]["FechaCambio"]);
                    CboTurno.Text = Convert.ToString(dt.Rows[0]["Turno"]);
                    MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["Foto"]);
                    Bitmap bm = new Bitmap(ms);
                    Pic_persona.Image = bm;
                }

                xedit = true;
                BtnGuardar.Enabled = true;
                //Pic_persona.Load(xFotoruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los Datos: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void DesactivarPersonal()
        {
             string personal = TxtRut.Text;
            RN_Personal obj = new RN_Personal();
            DialogResult opcion;
            opcion = MessageBox.Show("Esta seguro de desactivar al trabajador","Informacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
          


            if (opcion == DialogResult.Yes)
            {
                obj.RN_Desactivar_Personal(personal);
                MessageBox.Show("Personal Desactivado", "Informacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
       
                this.Tag = "A";
                this.Close();
            }
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            DesactivarPersonal();
        }

        private void botonesRedondos1_Click(object sender, EventArgs e)
        {
            Editar_Turno();
        }

        private void TxtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
               e.Handled = true;
            }
       
        }
    }
}
