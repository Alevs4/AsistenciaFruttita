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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        public void Cargar_Datos_Usuario()
        {
            try
            {
             
                MessageBox.Show("Bienvenido/a" + Cls_Libreria.Apellidos, "Bienvenido al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
             

                Lbl_NomUsu.Text = Cls_Libreria.Apellidos;
                lbl_rolNom.Text = Cls_Libreria.Rol;

 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {

         DialogResult Mensaje = MessageBox.Show("Estas seguro que quiere cerrar la APP", "Requerimiento del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
          if(Mensaje == DialogResult.OK)
            Application.Exit();

        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            Lbl_Fecha.Text = DateTime.Now.ToLongDateString();
            CargarHorarios();
            ConfigurarListview();
            ConfiguraListview_Asis();
            Verificar_Robot_de_Faltas();
            Cargar_todas_justificaciones();
            ConfigurarListview_Justi();


        }
        private void CargarHorarios()
        {
            RN_Horario obj = new RN_Horario();
            DataTable dt = new DataTable();

            dt = obj.RN_Leer_Horarios();
            if (dt.Rows.Count == 0) return;

            lbl_idHorario.Text = Convert.ToString(dt.Rows[0]["Id_Hor"]);
            dtp_horaIngre.Value = Convert.ToDateTime(dt.Rows[0]["HoEntrada"]);
            dtp_horaSalida.Value = Convert.ToDateTime(dt.Rows[0]["HoSalida"]);
            dtp_hora_tolercia.Value = Convert.ToDateTime(dt.Rows[0]["MiTolrncia"]);
            Dtp_Hora_Limite.Value = Convert.ToDateTime(dt.Rows[0]["HoLimite"]);
        }
        private void Verificar_Robot_de_Faltas()
        {
            string tipo;
            tipo = RN_Utilitario.RN_Listar_TipoFaltas(5);
            if (tipo.Trim() == "Si")
            {
                timerFalta.Start();
                rdb_ActivarRobot.Checked = true;
            }
            else if (tipo.Trim() == "No")
            {
                timerFalta.Stop();
                rdb_Desact_Robot.Checked = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        
            elTab1.SelectedIndex = 1;
            panelPersonal.Visible = false;
            Cargar_Personal();
        }
        private void Cargar_Personal()
        {
            RN_Personal obj = new RN_Personal();
            DataTable dt = new DataTable();

            dt = obj.RN_Leer_todaPersona();
            if (dt.Rows.Count > 0)
            {
                //llamamoa al metodo llenar listview
                LlenarListview(dt);
            }
        }
        private void LlenarListview(DataTable data)
        {
            lsv_person.Items.Clear();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Pernl"].ToString());
                list.SubItems.Add(dr["DNIPR"].ToString());
                list.SubItems.Add(dr["Nombre_Completo"].ToString());
                list.SubItems.Add(dr["Domicilio"].ToString());
                list.SubItems.Add(dr["Correo"].ToString());
                list.SubItems.Add(dr["Sexo"].ToString());
                list.SubItems.Add(dr["Fec_Naci"].ToString());
                list.SubItems.Add(dr["Celular"].ToString());
                list.SubItems.Add(dr["Id_rol"].ToString());
                list.SubItems.Add(dr["Rol"].ToString());
                list.SubItems.Add(dr["Id_Distrito"].ToString());
                list.SubItems.Add(dr["Estado_Per"].ToString());
                //Llenamos el listview
                lsv_person.Items.Add(list);
            }
            Lbl_total.Text = Convert.ToString(lsv_person.Items.Count);
        }
        private void ConfigurarListview()
        {
            var lis = lsv_person;
            lis.Columns.Clear();
            lis.Items.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            // configuramos el ancho y nombres de las columnas
            lis.Columns.Add("Id Persona", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Rut", 110, HorizontalAlignment.Left);
            lis.Columns.Add("Nombres", 316, HorizontalAlignment.Left);
            lis.Columns.Add("Direccion", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Correo", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Sexo", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Fecha Ingreso", 120, HorizontalAlignment.Center);
            lis.Columns.Add("Nro Celular", 120, HorizontalAlignment.Left);
            lis.Columns.Add("Seccion", 120, HorizontalAlignment.Left);
            lis.Columns.Add("Cargo", 120, HorizontalAlignment.Left);
            lis.Columns.Add("Distrito", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Estado", 100, HorizontalAlignment.Left);
        }
        private void Cargar_Todas_asistencias_delDia(DateTime fechas)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();

            dt = obj.RN_Ver_Todas_Asistencia_DlDia(fechas);
            if (dt.Rows.Count > 0)
            {
                //llamamos al metodo llenar listview
                LlenarListview_Asis(dt);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
     
            elTab1.SelectedIndex = 2;
            panelAsistencia.Visible = false;
            Cargar_Todas_asistencias_delDia(dtp_fechadeldia.Value);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
         
            elTab1.SelectedIndex = 3;
            panelJustificacion.Visible = false;
            Cargar_todas_justificaciones();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
       
            elTab1.SelectedIndex = 4;
            panelConfiguracion.Visible=false;
        }

        private void BtnAgregarPer_Click(object sender, EventArgs e)
        {
            AgregarPersonal agregarPersonal = new AgregarPersonal();
            agregarPersonal.Show();
        }

        private void agregarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPersonal agregarPersonal = new AgregarPersonal();
            agregarPersonal.Show();
        }

        private void editarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            AgregarPersonal per = new AgregarPersonal();

            if (lsv_person.SelectedIndices.Count == 0)
            {

            }
            else
            {
                var lsv = lsv_person.SelectedItems[0];
                string Idpersona = lsv.SubItems[0].Text;
          
                per.editPerso = true;
                per.Buscar_personal_ParaEditar(Idpersona);
                per.ShowDialog();


                if (Convert.ToString(per.Tag) == "A")
                {
                    Cargar_Personal();
                }
            }
        }

        private void registrarHuellaDigitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            RegistroHuella per = new RegistroHuella();

            //Primero Obtenemos el ID del personal
            if (lsv_person.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleccione Persona Rgistrar Huella", "Advertencia de Seguridad ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                var lsv = lsv_person.SelectedItems[0];
                string xidsocio = lsv.SubItems[0].Text;

                per.Buscar_Personal_ParaEditar(xidsocio);
                per.ShowDialog();
               

                if (Convert.ToString(per.Tag) == "") return;
                {
                    Cargar_Personal();
                }
            }
        }

   

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar_Personal_PorValor(txt_Buscar.Text.Trim());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscar.Text.Trim().Length > 2)
            {
                Buscar_Personal_PorValor(txt_Buscar.Text.Trim());
            }

        }
        private void Buscar_Personal_PorValor(string xvalor)
        {
            RN_Personal obj = new RN_Personal();
            DataTable dt = new DataTable();

            dt = obj.RN_Buscar_personal_xValor(xvalor);
            if (dt.Rows.Count > 0)
            {
                //llamamoa al metodo llenar listview
                LlenarListview(dt);
            }
            else
            {
                lsv_person.Items.Clear();
            }
        }
        private void ConfiguraListview_Asis()
        {
            var lis = lsv_asis;
            lis.Columns.Clear();
            lis.Items.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;

            lis.Columns.Add("Id Asis", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Rut", 80, HorizontalAlignment.Left);
            lis.Columns.Add("Nombres Del Personal", 316, HorizontalAlignment.Left);
            lis.Columns.Add("Fecha", 90, HorizontalAlignment.Left);
            lis.Columns.Add("Dia", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Ho Ingreso", 130, HorizontalAlignment.Left);
            lis.Columns.Add("Tardnza", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Ho Salida", 130, HorizontalAlignment.Left);
            lis.Columns.Add("Adelanto", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Justificacion", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Estado", 100, HorizontalAlignment.Left);
        }
        private void LlenarListview_Asis(DataTable data)
        {
            lsv_asis.Items.Clear();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_asis"].ToString());
                list.SubItems.Add(dr["DNIPR"].ToString());
                list.SubItems.Add(dr["Nombre_Completo"].ToString());
                list.SubItems.Add(dr["FechaAsis"].ToString());
                list.SubItems.Add(dr["Nombre_dia"].ToString());
                list.SubItems.Add(dr["HoIngreso"].ToString());
                list.SubItems.Add(dr["Tardanzas"].ToString());
                list.SubItems.Add(dr["HoSalida"].ToString());
                list.SubItems.Add(dr["Adelanto"].ToString());
                list.SubItems.Add(dr["Justifacion"].ToString());
                list.SubItems.Add(dr["EstadoAsis"].ToString());
                //Llenamos el listview
                lsv_asis.Items.Add(list);
            }
            Lbl_total.Text = Convert.ToString(lsv_asis.Items.Count);
        }

        private void Cargar_Todas_asistencias()
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();

            dt = obj.RN_Ver_Todas_Asistencias();
            if (dt.Rows.Count > 0)
            {
                //llamamos al metodo llenar listview
                LlenarListview_Asis(dt);
            }
        }

        private void PicHuella_Click(object sender, EventArgs e)
        {    
            AsistenciaHuella huella = new AsistenciaHuella();
            huella.LblTurno2.Text = CboTurno.Text;
           if(CboTurno.Text != "")
            {
              huella.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe ingresar Turno");
            }
            
        }

        private void PicEscaner_Click(object sender, EventArgs e)
        {
            AsistenciaManual asistencia = new AsistenciaManual();
            asistencia.LblTurno.Text = CboTurno.Text;
           if(CboTurno.Text != "")
            {
              asistencia.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe ingresar Turno");
            }
            

      
        }

        private void BtnCerrarAsis_Click(object sender, EventArgs e)
        {
            elTab1.SelectedIndex = 0;
            panelAsistencia.Visible = true;
        }

        private void TxtBuscarAsistencia_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarAsistencia.Text.Trim().Length > 2)
            {
                Cargar_Todas_asistencias_porValor(TxtBuscarAsistencia.Text);

            }
        }

        private void TxtBuscarAsistencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cargar_Todas_asistencias_porValor(TxtBuscarAsistencia.Text);
            }
        }
        private void Cargar_Todas_asistencias_porValor(string xvalor)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();

            dt = obj.RN_Ver_Todas_Asistencia_ParaExplorador(xvalor);
            if (dt.Rows.Count > 0)
            {
                //llamamos al metodo llenar listview
                LlenarListview_Asis(dt);
            }
        }

        private void Cerrar_Click_1(object sender, EventArgs e)
        {
            elTab1.SelectedIndex = 0;
            panelPersonal.Visible = true;
        }

        private void copiarRutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsv_person.SelectedIndices.Count == 0)
            {
             
               MessageBox.Show("Seleccione el Item que Desea Copiar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
            }
            else
            {
                var lsv = lsv_person.SelectedItems[0];
                string xdni = lsv.SubItems[1].Text;

                Clipboard.Clear();
                Clipboard.SetText(xdni.Trim());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            elTab1.SelectedIndex = 0;
            panelConfiguracion.Visible = true;
        }

        private void btn_SaveHorario_Click(object sender, EventArgs e)
        {
            try
            {
                RN_Horario hor = new RN_Horario();
                EN_Horario por = new EN_Horario();
    

                por.Idhora = lbl_idHorario.Text;
                por.HoEntrada = dtp_horaIngre.Value;
                por.HoTole = dtp_hora_tolercia.Value;
                por.HoLimite = Dtp_Hora_Limite.Value;
                por.HoSalida = dtp_horaSalida.Value;

                hor.RN_ACtualizar_horario(por);

                if (BD_Horario.sabed == true)
                {
                   
                    MessageBox.Show("Horario Actualizado","informacion De Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                

                    elTab1.SelectedIndex = 0;
                    panelConfiguracion.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Savedrobot_Click(object sender, EventArgs e)
        {
            RN_Utilitario uti = new RN_Utilitario();

            if (rdb_ActivarRobot.Checked == true)
            {
                uti.RN_Actualizar_RobotFalta(5, "Si");
                if (BD_Utilitario.falta == true)
                {
                    
                    MessageBox.Show("El Robot fue Actualizado");
                  
                    elTab1.SelectedIndex = 0;
                    panelConfiguracion.Visible = true;
                }
            }
            else if (rdb_Desact_Robot.Checked == true)
            {
                uti.RN_Actualizar_RobotFalta(5, "No");
                if (BD_Utilitario.falta == true)
                {
                   
                  MessageBox.Show("El Robot fue Actualizado");
                  
                    elTab1.SelectedIndex = 0;
                    panelConfiguracion.Visible = true;
                }
            }
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            toolMensajes.SetToolTip(groupBox1, "Seccion para cambios de Horarios");
            toolMensajes.ToolTipTitle = "Horarios";
            toolMensajes.ToolTipIcon = ToolTipIcon.Info;
        }

        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            toolMensajes.SetToolTip(groupBox2, "Seccion para Configurar faltas automaticamente");
            toolMensajes.ToolTipTitle = "Robot Faltas";
            toolMensajes.ToolTipIcon = ToolTipIcon.Info;

        }

        private void PicEscaner_MouseHover(object sender, EventArgs e)
        {
            toolMensajes.SetToolTip(PicEscaner, "Boton que abre Formulario para asistencia manual");
            toolMensajes.ToolTipTitle = "Asistencia Manual";
            toolMensajes.ToolTipIcon = ToolTipIcon.Info;
        }

        private void PicHuella_MouseHover(object sender, EventArgs e)
        {
            toolMensajes.SetToolTip(PicHuella, "Boton que abre Formulario para asistencia Con Huella Digital");
            toolMensajes.ToolTipTitle = "Asistencia Con Huella";
            toolMensajes.ToolTipIcon = ToolTipIcon.Info;
        }

        private void timerFalta_Tick(object sender, EventArgs e)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dataper = new DataTable();
            RN_Personal objper = new RN_Personal();

            int HoLimite = Dtp_Hora_Limite.Value.Hour;
            int MiLimite = Dtp_Hora_Limite.Value.Minute;

            int horaCaptu = DateTime.Now.Hour;
            int minutoCaptu = DateTime.Now.Minute;
            string Dniper = "";
            int Cant = 0;
            int TotalItem = 0;
            string xidpersona = "";
            string IdAsistencia = "";
            string xjustificacion = "";

            if (horaCaptu >= HoLimite)
            {
                if (minutoCaptu > MiLimite)
                {
                    dataper = objper.RN_Leer_todaPersona();
                    if (dataper.Rows.Count <= 0) return;
                    TotalItem = dataper.Rows.Count; //Obtenemos el Total de las personas Registradas

                    foreach (DataRow Registro in dataper.Rows)
                    {
                        Dniper = Convert.ToString(Registro["DNIPR"]);
                        xidpersona = Convert.ToString(Registro["Id_Pernl"]);
                        if (obj.RN_Checar_SiPersonal_TieneAsistencia_Registrada(xidpersona.Trim()) == false)
                        {
                            if (obj.RN_Checar_SiPersonal_YaMarco_suFalta(xidpersona.Trim()) == false)
                            {
                                RN_Asistencia objA = new RN_Asistencia();
                                EN_Asistencia asi = new EN_Asistencia();
                                IdAsistencia = RN_Utilitario.RN_NroDoc(3);

                                //verificamos si tiene alguna justificacion
                                if (objA.RN_Verificar_Justificacion_Aprovado(xidpersona) == true)
                                {
                                    xjustificacion = "Falta Tiene Justificacion";
                                }
                                else
                                {
                                    xjustificacion = "No Tiene Justificacion";
                                }
                                obj.RN_Registrar_Falta_Personal(IdAsistencia, xidpersona, xjustificacion);
                                if (BD_Asistencia.FaltasCheck == true)
                                {
                                    RN_Utilitario.RN_Actualiza_Tipo_Doc(3);//Actualizamos Correlativo de asistencia
                                    Cant += 1;// Almacena la cantidad de faltas registradas
                                }
                            }
                        }
                    }
                    if (Cant > 1)
                    {
                        timerFalta.Stop();
                  
                      MessageBox.Show("Un Total de: " + Cant.ToString() + "/" + TotalItem + "Faltas se Han Registrado Exitosamente") ;
                    }
                    else
                    {
                        timerFalta.Stop();
                      MessageBox.Show("El dia de Hoy no falto Nadie al Trabajo, las " + TotalItem + "Personas Marcaron su Asistencia");
       
                    }
                }
            }
        }

        private void txt_buscarjusti_TextChanged(object sender, EventArgs e)
        {

            if (txt_buscarjusti.Text.Trim().Length > 2)
            {
                Buscar_Justificacion_porValor(txt_buscarjusti.Text);

            }
        }
        private void Buscar_Justificacion_porValor(string xvalor)
        {
            RN_Justificacion obj = new RN_Justificacion();
            DataTable dt = new DataTable();

            dt = obj.RN_BuscarJustificacion_xValor(xvalor.Trim());
            if (dt.Rows.Count > 0)
            {
                //llamamoa al metodo llenar listview
                LlenarListview_Justi(dt);
            }
            else
            {
                lsv_justifi.Items.Clear();
            }
        }

        private void bt_cerrarjusti_Click(object sender, EventArgs e)
        {
            elTab1.SelectedIndex = 0;
            panelJustificacion.Visible = true;
        }

        private void lsv_justifi_MouseClick(object sender, MouseEventArgs e)
        {
            var lsv = lsv_justifi.SelectedItems[0];
            string xnombre = lsv.SubItems[6].Text;

            lbl_Detalle.Text = xnombre.Trim();
        }
        private void ConfigurarListview_Justi()
        {
            var lis = lsv_justifi;
            lis.Columns.Clear();
            lis.Items.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            // configuramos el ancho y nombres de las columnas
            lis.Columns.Add("IdJusti", 0, HorizontalAlignment.Left);
            lis.Columns.Add("IdPerso", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Nombres del Personal", 316, HorizontalAlignment.Left);
            lis.Columns.Add("Motivo", 110, HorizontalAlignment.Left);
            lis.Columns.Add("Fecha", 120, HorizontalAlignment.Left);
            lis.Columns.Add("Estado", 120, HorizontalAlignment.Center);
            lis.Columns.Add("Detalle Justificacion", 0, HorizontalAlignment.Left);

        }
        private void LlenarListview_Justi(DataTable data)
        {
            lsv_justifi.Items.Clear();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Justi"].ToString());
                list.SubItems.Add(dr["Id_pernl"].ToString());
                list.SubItems.Add(dr["Nombre_Completo"].ToString());
                list.SubItems.Add(dr["PrincipalMotivo"].ToString());
                list.SubItems.Add(dr["FechaEmi"].ToString());
                list.SubItems.Add(dr["EstadoJus"].ToString());
                list.SubItems.Add(dr["Detalle_Justi"].ToString());

                //Llenamos el listview
                lsv_justifi.Items.Add(list);
            }
            lbl_totaljusti.Text = Convert.ToString(lsv_justifi.Items.Count);
        }
        private void Cargar_todas_justificaciones()
        {
            RN_Justificacion obj = new RN_Justificacion();
            DataTable dt = new DataTable();

            dt = obj.RN_Cargar_todos_Justificacion();
            if (dt.Rows.Count > 0)
            {
                //llamamoa al metodo llenar listview
                LlenarListview_Justi(dt);
            }
        }

        private void eliminarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
            RN_Personal obj = new RN_Personal();
            if (lsv_person.SelectedIndices.Count == 0)
            {
               
                MessageBox.Show("Selecione Item que Desea Eliminar", "Informacion De Sistema",MessageBoxButtons.OK, MessageBoxIcon.Question);
            
                return;
            }
            else
            {
                var lsv = lsv_person.SelectedItems[0];
                string Valor = lsv.SubItems[0].Text;

                DialogResult Res = MessageBox.Show("Estas Seguro de Eliminar personal","Informacion Critica", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) ;
          

                if (Res == DialogResult.OK)
                {
                    obj.RN_EliminarPersonal(Valor);
                  MessageBox.Show("Personal Eliminado", "Informacion de Sistema", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                 
                    Cargar_Personal();

                }
            }
        }

        private void solicitarJustificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarJustificacion per = new AgregarJustificacion();
 

            if (lsv_person.SelectedIndices.Count == 0)
            {
               
                MessageBox.Show("Selecciona un Item Por Favor", "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            else
            {
                var lsv = lsv_person.SelectedItems[0];
                string xidsocio = lsv.SubItems[0].Text;
                string xnombre = lsv.SubItems[2].Text;

                
                per.xeditar = false;
                per.txt_IdPersona.Text = xidsocio;
                per.txt_nompersona.Text = xnombre;
                per.txt_idjusti.Text = RN_Utilitario.RN_NroDoc(4);
                per.ShowDialog();
                

                if (Convert.ToString(per.Tag) == "") return;
                {
                    Cargar_todas_justificaciones();
                    elTab1.SelectedIndex = 3;
                    panelJustificacion.Visible = false;
                }

            }
        }

        private void mostrarTodasLasAsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargar_Todas_asistencias();
        }

        private void copiarRutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lsv_asis.SelectedIndices.Count == 0)
            {

                MessageBox.Show("Seleccione el Item que Desea Copiar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                var lsv = lsv_asis.SelectedItems[0];
                string xdni = lsv.SubItems[1].Text;

                Clipboard.Clear();
                Clipboard.SetText(xdni.Trim());
            }
        }

        private void asistenciaDelMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsistenciaDelMes mes = new AsistenciaDelMes();
            mes.ShowDialog();
        }

        private void reporteDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteAsis asis = new ReporteAsis();
            asis.ShowDialog();
        }

        private void aprovarJustificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
            RN_Justificacion obj = new RN_Justificacion();

            if (lsv_justifi.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Selecione Item que Desea Aprovar");
           
                return;
            }
            else
            {
                var lsv = lsv_justifi.SelectedItems[0];
                string xidjus = lsv.SubItems[0].Text;
                string xidper = lsv.SubItems[1].Text;
                string xstadojus = lsv.SubItems[6].Text;

                if (xstadojus.Trim() == "Aprovado") {MessageBox.Show("La Justificacion Seleccionada , ya fue Aprobada") ; return; }
                DialogResult aprobar;
                aprobar = MessageBox.Show("Estas Seguro de aprobar la Justificacion","Informacion De Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
          

                if (aprobar == DialogResult.OK)
                {
                    obj.RN_Aprovar_Justificacion(xidjus, xidper);
                    if (BD_Justificacion.aprobar == true)
                    {
                   MessageBox.Show("Justificacion Aprovada");
                    
                        Buscar_Justificacion_porValor(xidjus);
                    }
                }
            }
        }

        private void editarJustificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
              AgregarJustificacion per = new AgregarJustificacion();

            if (lsv_justifi.SelectedIndices.Count == 0)
            {
                
                MessageBox.Show("Selecciona un Item Por Favor", "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             
            }
            else
            {
                var lsv = lsv_justifi.SelectedItems[0];
                string xidsocio = lsv.SubItems[1].Text;
                string xidjusti = lsv.SubItems[0].Text;
                string xnombre = lsv.SubItems[2].Text;

           
                per.xeditar = false;
                per.txt_IdPersona.Text = xidsocio;
                per.txt_nompersona.Text = xnombre;
                per.txt_idjusti.Text = xidjusti;
                per.BuscarJustificacion(xidjusti);
                per.ShowDialog();
             

                if (Convert.ToString(per.Tag) == "") return;
                {
                    Cargar_todas_justificaciones();
                    elTab1.SelectedIndex = 3;
                    panelJustificacion.Visible = false;
                }

            }
        }

        private void eliminarJustificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            RN_Justificacion obj = new RN_Justificacion();
            if (lsv_justifi.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Selecione Item que Desea Eliminar");

                return;
            }
            else
            {
                var lsv = lsv_justifi.SelectedItems[0];
                string xidjus = lsv.SubItems[0].Text;
                DialogResult Justy;
            
                Justy = MessageBox.Show("Estas Seguro de Eliminar la Justificacion","Informacion De Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            

                if (Justy == DialogResult.OK)
                {
                    obj.RN_Eliminar_Justificacion(xidjus);
                    MessageBox.Show("Justificacion Eliminada");
                
                    Buscar_Justificacion_porValor(xidjus);
                    Cargar_todas_justificaciones();
                    lbl_Detalle.Text = "";
                 
                }
            }
        }

        private void mostrarTodasLasJustificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargar_todas_justificaciones();
        }

        private void desaprobarJustificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RN_Justificacion obj = new RN_Justificacion();

            if (lsv_justifi.SelectedIndices.Count == 0)
            {

                MessageBox.Show("Selecione Item que Desea Desaprobar");
       
                return;
            }
            else
            {
                var lsv = lsv_justifi.SelectedItems[0];
                string xidjus = lsv.SubItems[0].Text;
                string xidper = lsv.SubItems[1].Text;
                string xstadojus = lsv.SubItems[6].Text;

                if (xstadojus.Trim() == "Falta Aprobar") {MessageBox.Show("La Justificacion Seleccionada , Aun no fue Aprobada") ; return; }
                DialogResult desaprobar;
                desaprobar = MessageBox.Show("Estas Seguro de desaprobar la Justificacion","informacion de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
   

                if (desaprobar == DialogResult.OK)
                {
                    obj.RN_Aprovar_Justificacion(xidjus, xidper);
                    if (BD_Justificacion.aprobar == true)
                    {
                     
                     MessageBox.Show("Justificacion Pendiente de Aprobacion");
               
                        Buscar_Justificacion_porValor(xidjus);
                    }
                }
            }
        }

        private void reporteJustificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteJustificaciones repo = new ReporteJustificaciones();
            repo.Show();
        }

        private void informePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformePersonal informePersonal=new InformePersonal();
            informePersonal.Show();
        }
    }
    
}
