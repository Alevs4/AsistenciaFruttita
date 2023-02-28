using AsistenciaFruttita.Datos;
using AsistenciaFruttita.Entidad;
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
    public partial class AgregarJustificacion : Form
    {
        public AgregarJustificacion()
        {
            InitializeComponent();
        }

        private void AgregarJustificacion_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }
        private bool ValidarDatos()
        {
          


            if (txt_IdPersona.Text.Trim().Length < 10) { MessageBox.Show("El ID personal no fue Generado") ; return false; }
            if (txt_nompersona.Text.Trim().Length < 8) { MessageBox.Show("El ID justificacion no fue Generado");  return false; }
            if (cbo_motivJusti.SelectedIndex == -1) { MessageBox.Show("Seleccione el motivo de la Justificacion"); cbo_motivJusti.Focus(); return false; }
            if (txt_DetalleJusti.Text.Trim().Length < 10) { MessageBox.Show("Ingrese una lave descripcion de la justificacion"); txt_DetalleJusti.Focus(); return false; }

            return true;
        }
        private void Limpiar()
        {
            txt_DetalleJusti.Text = "";
            txt_idjusti.Text = "";
            txt_IdPersona.Text = "";
            txt_nompersona.Text = "";
            cbo_motivJusti.Text = "";
        }
        private void Registrar_Justificacion()
        {
            RN_Justificacion obj = new RN_Justificacion();
            EN_Justificacion jus = new EN_Justificacion();

           

            try
            {
                jus.IdJusti = txt_idjusti.Text.Trim();
                jus.Id_Personal = txt_IdPersona.Text;
                jus.PrincipalMotivo = cbo_motivJusti.Text;
                jus.Detalle = txt_DetalleJusti.Text;
                jus.Fecha = Dtp_FechaJusti.Value;

                obj.RN_Registrar_Justificacion(jus);

                if (BD_Justificacion.saved == true)
                {
                    RN_Utilitario.RN_Actualiza_Tipo_Doc(4);
                    MessageBox.Show("La solicitud de Justificacion fue Registrada, Espere Aprovacion", "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Limpiar();
                    this.Tag = "A";
                    this.Close();
                    Frm_Principal prin = new Frm_Principal();
                    prin.panelPersonal.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Editar_Justificacion()
        {
            RN_Justificacion obj = new RN_Justificacion();
            EN_Justificacion jus = new EN_Justificacion();


            try
            {
                jus.IdJusti = txt_idjusti.Text.Trim();
                jus.Id_Personal = txt_IdPersona.Text;
                jus.PrincipalMotivo = cbo_motivJusti.Text;
                jus.Detalle = txt_DetalleJusti.Text;
                jus.Fecha = Dtp_FechaJusti.Value;

                obj.RN_Editar_Justificacion(jus);

                if (BD_Justificacion.editar == true)
                {
                    RN_Utilitario.RN_Actualiza_Tipo_Doc(4);

                    MessageBox.Show("La solicitud de Justificacion fue Modificada, Espere Aprovacion", "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Limpiar();
                    this.Tag = "A";
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public bool xeditar = false;
        public void BuscarJustificacion(string idJusti)
        {
            try
            {
                RN_Justificacion obj = new RN_Justificacion();
                DataTable dt = new DataTable();

                dt = obj.RN_BuscarJustificacion_xValor(idJusti.Trim());
                if (dt.Rows.Count == 0) return;
                {
                    Dtp_FechaJusti.Value = Convert.ToDateTime(dt.Rows[0]["FechaJusti"]);
                    cbo_motivJusti.Text = Convert.ToString(dt.Rows[0]["PrincipalMotivo"]);
                    txt_DetalleJusti.Text = Convert.ToString(dt.Rows[0]["Detalle_Justi"]);
                }
                xeditar = true;
                btn_aceptar.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (xeditar == true)
                {
                    Editar_Justificacion();
                }
                else
                {
                    Registrar_Justificacion();
                }
            }
        }

        private void botonesRedondos1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
