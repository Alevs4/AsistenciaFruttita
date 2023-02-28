using AsistenciaFruttita.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistenciaFruttita
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Txt_Usu.Focus();
        }
        private bool ValidarTexbox()
        {
            if (Txt_Usu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresa tu Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txt_Usu.Focus();
                return false;

            }
            if (Txt_Pass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresa tu Contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txt_Pass.Focus();
                return false;

            }
            return true;
        }
        private void AccederAlSistema()
        {
            RN_Usuarios obj = new RN_Usuarios();
            DataTable dt = new DataTable();
            int veces = 0;

            if (ValidarTexbox() == false)
                return;

            string usu, pass;
            usu = Txt_Usu.Text.Trim();
            pass = Txt_Pass.Text.Trim();

            if (obj.RN_Verificar_Acceso(usu, pass) == true)
            {
                //los datos son correctos
                //MessageBox.Show("Bienvenido al Sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cls_Libreria.Usuario = usu;

                dt = obj.RN_Lerr_Datos_Usuario(usu);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    Cls_Libreria.IdRol = Convert.ToString(dr["Id_Usu"]);
                    Cls_Libreria.Apellidos = Convert.ToString(dr["Nombre_Completo"]);
                    Cls_Libreria.IdRol = Convert.ToString(dr["Id_Rol"]);
                    Cls_Libreria.Rol = dr["NomRol"].ToString();
                    Cls_Libreria.Foto = dr["Avatar"].ToString();
                }

              
                Frm_Principal principal = new Frm_Principal();
                this.Hide();
                principal.Show();
                principal.Cargar_Datos_Usuario();
                if(principal.Lbl_NomUsu.Text == "Packing")
                {
                    principal.pictureBox4.Enabled = false;
                    principal.pictureBox6.Enabled = false;
                    principal.pictureBox7.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Txt_Usu.Text = "";
                Txt_Pass.Text = "";
                Txt_Usu.Focus();
                veces += 1;

                if (veces == 3)
                {
                    MessageBox.Show("Numero de intentos Superado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios U = new Utilitarios();
                U.Mover_formulario(this);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccederAlSistema();
        }
    }
}
