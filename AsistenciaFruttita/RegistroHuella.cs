using AsistenciaFruttita.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistenciaFruttita
{
    public partial class RegistroHuella : Form
    {
        public RegistroHuella()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonesRedondos1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Buscar_Personal_ParaEditar(string rut)
        {
            string xfotoruta;
            try
            {
                RN_Personal obj = new RN_Personal();
                DataTable dt = new DataTable();

                dt = obj.RN_Buscar_personal_xValor(rut);
                if (dt.Rows.Count == 0) return;
                {
                    lbl_nroDni.Text = Convert.ToString(dt.Rows[0]["DNIPR"]);
                    lbl_nomPersona.Text = Convert.ToString(dt.Rows[0]["Nombre_Completo"]);
                    MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["Foto"]);
                    Bitmap bm = new Bitmap(ms);
                    picFoto.Image = bm;
                    lbl_idperso.Text = rut;
                }

                //if (picFoto.Image != null)
                //{
                //    picFoto.Image = bm;
                //}
                //else
                //{
                //    picFoto.Load(Application.StartupPath + @"\user.png");
                //}
            }
            catch (Exception ex)
            {
                picFoto.Load(Application.StartupPath + @"\user.png");
                MessageBox.Show("No hay Foto Guardada" + " " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void EnrollmentControl_OnStartEnroll_1(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Items.Insert(0, string.Format("OnStartEnroll: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void EnrollmentControl_OnSampleQuality_1(object Control, string ReaderSerialNumber, int Finger, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            ListEvents.Items.Insert(0, string.Format("OnSampleQuality: {0}, finger {1}, {2}", ReaderSerialNumber, Finger, CaptureFeedback));
        }

        private void EnrollmentControl_OnReaderDisconnect_1(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Items.Insert(0, string.Format("OnReaderDisconnect: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void EnrollmentControl_OnReaderConnect_1(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Items.Insert(0, string.Format("OnReaderConnect: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void EnrollmentControl_OnFingerTouch_1(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Items.Insert(0, string.Format("OnFingerTouch: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void EnrollmentControl_OnFingerRemove_1(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Items.Insert(0, string.Format("OnFingerRemove: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void EnrollmentControl_OnEnroll(object Control, int FingerMask, DPFP.Template Template, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            byte[] Data = null;
            RN_Personal obj = new RN_Personal();

            if (Template is null)
            {
                Template.Serialize(ref Data);
                MessageBox.Show("Algo Malo Pasó", "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lbl_idperso.Text = "";
                lbl_nomPersona.Text = "";
                lbl_nroDni.Text = "";
                picFoto.Image = null;
                this.Tag = "";
                this.Close();

            }
            else
            {
                Template.Serialize(ref Data);
                obj.RN_Registrar_Huella_Personal(lbl_idperso.Text, Data);
                EnrollmentControl.Enabled = false;
                lbl_idperso.Text = "";
                lbl_nomPersona.Text = "";
                lbl_nroDni.Text = "";
                picFoto.Image = null;
                MessageBox.Show("Huella Dactilar Ingresada Correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Tag = "A";
                this.Close();
            }
        }
    }
}
