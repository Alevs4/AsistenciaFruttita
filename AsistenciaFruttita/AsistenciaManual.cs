using AsistenciaFruttita.Datos;
using AsistenciaFruttita.Entidad;
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
    public partial class AsistenciaManual : Form
    {
        public AsistenciaManual()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }
        private void CargarHorarios()
        {
            RN_Horario obj = new RN_Horario();
            DataTable dt = new DataTable();

            dt = obj.RN_Leer_Horarios();
            if (dt.Rows.Count == 0) return;
            dtp_horaIngre.Value = Convert.ToDateTime(dt.Rows[0]["HoEntrada"]);
            Lbl_HoraEntrada.Text = dtp_horaIngre.Value.ToShortTimeString();
            dtp_horaSalida.Value = Convert.ToDateTime(dt.Rows[0]["HoSalida"]);
            dtp_hora_tolercia.Value = Convert.ToDateTime(dt.Rows[0]["MiTolrncia"]);
            Dtp_Hora_Limite.Value = Convert.ToDateTime(dt.Rows[0]["HoLimite"]);


        }

        private void AsistenciaManual_Load(object sender, EventArgs e)
        {   
            txt_dni_Buscar.Focus();
            CargarHorarios();
            
        }

        void calcular_Minutos_Tardanza()
        {
            RN_Asistencia obj = new RN_Asistencia();

            int horaCaptu = DateTime.Now.Hour;
            int minutoCaptu = DateTime.Now.Minute;

            int horaIn = dtp_horaIngre.Value.Hour;
            int MinuIn = dtp_horaIngre.Value.Minute;
            int Mntotole = dtp_hora_tolercia.Value.Minute;

            int totalMinutosfijo;
            int totaltardanza;
            int HoraTardanza;

            if (obj.RN_Verificar_Justificacion_Aprovado(Lbl_Idperso.Text) == true)
            {
                lbl_justifi.Text = "Tardanza Justificada";
            }

            else
            {
                lbl_justifi.Text = "Si LLego tarde no esta Justificada";
                totalMinutosfijo = MinuIn + Mntotole;

                if (horaCaptu == horaIn & minutoCaptu > totalMinutosfijo)
                {
                    totaltardanza = minutoCaptu - totalMinutosfijo;



                    lbl_totaltarde.Text = Convert.ToString(totaltardanza);
                }
                /* else*/
                if (horaCaptu > horaIn)
                {
                    int horaTarde;
                    horaTarde = horaCaptu - horaIn;
                    int HoraenMinuto;
                    HoraenMinuto = horaTarde * 60;
                    int totaltardexx = HoraenMinuto - totalMinutosfijo;
                    totaltardanza = minutoCaptu + totaltardexx;
                    if (totaltardanza < 59)
                    {
                        HoraTardanza = totaltardanza;
                        lbl_totaltarde.Text = Convert.ToString(HoraTardanza);
                    }
                    else
                    {
                        HoraTardanza = (totaltardanza * 1) / 60;
                        lbl_totaltarde.Text = Convert.ToString(HoraTardanza);
                    }


                }

            }
        }
        void calcular_HorasTrabajadas()
        {


            int horaCaptu = DateTime.Now.Hour;
            int minutoCaptu = DateTime.Now.Minute;

            int horaIn = dtp_horaSalida.Value.Hour;
            int MinuIn = dtp_horaIngre.Value.Minute;
            int MinOut = dtp_horaSalida.Value.Minute;

            int totalMinutos = 0;
            //int totalhoras;
            //  int hora;

            if (minutoCaptu > MinOut && horaCaptu >= horaIn || horaCaptu <= horaIn)
            {
                //hora = (horaCaptu - horaIn)-1;
                int minutos;
                minutos = minutoCaptu - MinOut;

                totalMinutos = minutos;
                //totalhoras = hora;
                //lbl_TotalHotrabajda.Text = Convert.ToString(totalhoras);
                lblMinutos.Text = Convert.ToString(totalMinutos);
            }

            else
            {
                lblMinutos.Text = Convert.ToString("0");
            }

        }
        int Extra;
        int hora;
        void calcular_Extra()
        {
            int horaCaptu = DateTime.Now.Hour;
            int horout = dtp_horaSalida.Value.Hour;


            if (horaCaptu >= horout)
            {
                hora = (horaCaptu - horout);
                Extra = hora;
                lblExtra.Text = Convert.ToString(Extra);

                //}if(horaCaptu.ToString().Length < 2)

                //    if (horaCaptu < horout)
                //    {


                //     hora = (horaCaptu - horout) + 1;
                //     Extra = hora;
                //     lblExtra.Text = Convert.ToString(Extra);
            }
            else
            {


                lblExtra.Text = Convert.ToString("0");
            }

        }
        private int sec = 1;
   


        private void LimpiarFormulario()
        {
            lbl_nombresocio.Text = "";
            lbl_totaltarde.Text = "0";
            lbl_TotalHotrabajda.Text = "0";
            lbl_Dni.Text = "";
            lbl_Cont.Text = "0";
            lbl_IdAsis.Text = "";
            Lbl_Idperso.Text = "";
            lbl_justifi.Text = "";
            lbl_msm.BackColor = Color.Transparent;
            lbl_msm.Text = "";
            lblMinutos.Text = "";
            picSocio.Image = null;
            txt_dni_Buscar.Text = "";
        }

        private void tmr_Conta_Tick(object sender, EventArgs e)
        {
            sec -= 1;
            lbl_Cont.Text = sec.ToString();
            lbl_Cont.Refresh();

            if (sec == 0)
            {
                LimpiarFormulario();
                sec = 1;
                tmr_Conta.Stop();
                pnl_Msm.Visible = false;
                lbl_Cont.Text = "1";
                txt_dni_Buscar.Focus();
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitarios move = new Utilitarios();
            if (e.Button == MouseButtons.Left)
            {
                move.Mover_formulario(this);
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            RN_Personal obj = new RN_Personal();
            RN_Asistencia objs = new RN_Asistencia();
            DataTable objas = new DataTable();
            DataTable dtpersonas = new DataTable();
            DataTable dts = new DataTable();
            DataTable Limite = new DataTable();


            string NumRut;


            int HoLimite = Dtp_Hora_Limite.Value.Hour;
            int MiLimite = Dtp_Hora_Limite.Value.Minute;
            int HoTolerancia = dtp_hora_tolercia.Value.Hour;
            int horaCaptu = DateTime.Now.Hour;
            int minutoCaptu = DateTime.Now.Minute;
            int horaSalida = dtp_horaSalida.Value.Hour;

            try
            {
                dtpersonas = obj.RN_Buscar_personal_xValor(txt_dni_Buscar.Text.Trim());
                if (dtpersonas.Rows.Count <= 0)
                {
                    lbl_msm.BackColor = Color.MistyRose;
                    lbl_msm.ForeColor = Color.Red;
                    lbl_msm.Text = "Persona No Existe en el Sistema";
                    lbl_Cont.Text = "1";
                    pnl_Msm.Visible = true;
                    tmr_Conta.Enabled = true;
                    return;
                }
                else
                {
                    var dt = dtpersonas.Rows[0];
                    MemoryStream ms = new MemoryStream((byte[])dt["Foto"]);
                    Bitmap bm = new Bitmap(ms);
                    picSocio.Image = bm;
                    lbl_nombresocio.Text = Convert.ToString(dt["Nombre_Completo"]);
                    Lbl_Idperso.Text = Convert.ToString(dt["Id_pernl"]);
                    lbl_Dni.Text = Convert.ToString(dt["DNIPR"]);
                    NumRut = Convert.ToString(dt["Id_pernl"]);

                    //if (picSocio.Image == null)
                    //{
                    //    picSocio.Image = bm;
                    //}
                    //else
                    //{
                    //    picSocio.Load(Application.StartupPath + @"\user.png");
                    //}
                    if (objs.RN_Checar_SiPersonal_YaMarco_Asistencia(Lbl_Idperso.Text.Trim()) == true)
                    {
                        lbl_msm.BackColor = Color.MistyRose;
                        lbl_msm.ForeColor = Color.Red;
                        lbl_msm.Text = "Persona Ya Marco su Asistencia";
                        lbl_Cont.Text = "1";

                        pnl_Msm.Visible = true;
                        tmr_Conta.Enabled = true;
                        return;
                    }
                    if (objs.RN_Checar_SiPersonal_YaMarco_SuEntrada(Lbl_Idperso.Text.Trim()) == true)
                    {
                      
                         
                        
                      var limite = objs.RN_RegistroLimitaciones(Lbl_Idperso.Text);


                        if (limite.Rows.Count > 0)
                        {
                            DateTime reg = Convert.ToDateTime(limite.Rows[0]["HoIngreso"]);
                            TimeSpan diferencia = DateTime.Now - reg;
                            if (diferencia.TotalSeconds <= (60 * 45))

                            {
                                MessageBoxTemporal.Show("Personal Ya marco su Entrada", "Informacion de Sistema",2,true);
                                LimpiarFormulario();

                            }else 
                            { 

                            }
                            
                            dts = objs.RN_Buscar_asistencia_deEntrada(Lbl_Idperso.Text);
                            if (dts.Rows.Count < 1) return;
                            Lbl_Idperso.Text = Convert.ToString(dts.Rows[0]["Id_Pernl"]);
                            EN_Asistencia parametros = new EN_Asistencia();
                            parametros.HoSalida = DateTime.Now;

                            calcular_HorasTrabajadas();
                            calcular_Extra();
                            objs.RN_Registrar_Salida_Personal(Lbl_Idperso.Text, parametros.HoSalida, 0, Convert.ToInt32(lblExtra.Text), Convert.ToInt32(lblMinutos.Text));

                            if (BD_Asistencia.salida == true)
                            {
                                lbl_msm.BackColor = Color.YellowGreen;
                                lbl_msm.ForeColor = Color.White;
                                lbl_msm.Text = "Registro de Salida Exitosa";


                                pnl_Msm.Visible = true;
                                lbl_Cont.Text = "1";
                                tmr_Conta.Enabled = true;

                            }
                        }
                    }
                   
                    else
                    {
                        //        //marcar Entrada debe
                        //if (horaCaptu > HoLimite)
                        //{
                        //    lbl_msm.BackColor = Color.MistyRose;
                        //    lbl_msm.ForeColor = Color.Red;
                        //    lbl_msm.Text = "Estimado Trabajador, Su hora de entrada Caducó, Vuelva Mañana";
                        //    pnl_Msm.Visible = true;
                        //    tmr_Conta.Enabled = true;
                        //    lbl_Cont.Text = "3";

                        //    return;
                        //}

                        EN_Asistencia parametros = new EN_Asistencia();
                        parametros.HoIngreso = DateTime.Now;

                        calcular_Minutos_Tardanza();
                        lbl_IdAsis.Text = RN_Utilitario.RN_NroDoc(3);
                        objs.RN_Registrar_Entrada_Personal(lbl_IdAsis.Text, Lbl_Idperso.Text, parametros.HoIngreso, Convert.ToDouble(lbl_totaltarde.Text), Convert.ToInt32(lbl_TotalHotrabajda.Text), lbl_justifi.Text,LblSeccion.Text,LblTurno.Text);

                        if (BD_Asistencia.entrada == true)
                        {
                            RN_Utilitario.RN_Actualiza_Tipo_Doc(3);
                            lbl_msm.BackColor = Color.YellowGreen;
                            lbl_msm.ForeColor = Color.White;
                            lbl_msm.Text = "La Entrada se Registro Exitosamente";
                            pnl_Msm.Visible = true;
                            tmr_Conta.Enabled = true;

                            lbl_Cont.Text = "1";


                        }
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("error de base de datos", ex.Message);
            }
        }

        private void txt_dni_Buscar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_buscar_Click(sender, e);
            }
        }
    }
}
