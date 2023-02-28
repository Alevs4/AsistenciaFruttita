namespace AsistenciaFruttita
{
    partial class AsistenciaHuella
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsistenciaHuella));
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.btn_mini = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Msm = new System.Windows.Forms.Panel();
            this.lbl_Cont = new System.Windows.Forms.Label();
            this.lbl_totaltarde = new System.Windows.Forms.TextBox();
            this.lbl_justifi = new System.Windows.Forms.TextBox();
            this.lbl_Dni = new System.Windows.Forms.TextBox();
            this.lbl_IdAsis = new System.Windows.Forms.Label();
            this.lblExtra = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lbl_TotalHotrabajda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picSocio = new System.Windows.Forms.PictureBox();
            this.Lbl_Idperso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nombresocio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.dtp_hora_tolercia = new System.Windows.Forms.DateTimePicker();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Dtp_Hora_Limite = new System.Windows.Forms.DateTimePicker();
            this.Label27 = new System.Windows.Forms.Label();
            this.dtp_horaIngre = new System.Windows.Forms.DateTimePicker();
            this.dtp_horaSalida = new System.Windows.Forms.DateTimePicker();
            this.xVerificationControl = new DPFP.Gui.Verification.VerificationControl();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.Lbl_HoraEntrada = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_hora1 = new System.Windows.Forms.Label();
            this.lbl_msm = new System.Windows.Forms.Label();
            this.tmr_Conta = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtp_HoraActual = new System.Windows.Forms.DateTimePicker();
            this.elipseComponent1 = new AsistenciaFruttita.Components.ElipseComponent();
            this.LblSeccion = new System.Windows.Forms.Label();
            this.LblTurno2 = new System.Windows.Forms.Label();
            this.pnl_titulo.SuspendLayout();
            this.pnl_Msm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSocio)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.Gray;
            this.pnl_titulo.Controls.Add(this.btn_mini);
            this.pnl_titulo.Controls.Add(this.label7);
            this.pnl_titulo.Controls.Add(this.btn_Salir);
            this.pnl_titulo.Controls.Add(this.label1);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1468, 63);
            this.pnl_titulo.TabIndex = 8;
            this.pnl_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseMove);
            // 
            // btn_mini
            // 
            this.btn_mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mini.BackColor = System.Drawing.Color.White;
            this.btn_mini.FlatAppearance.BorderSize = 0;
            this.btn_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mini.ForeColor = System.Drawing.Color.White;
            this.btn_mini.Image = ((System.Drawing.Image)(resources.GetObject("btn_mini.Image")));
            this.btn_mini.Location = new System.Drawing.Point(1410, 10);
            this.btn_mini.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(43, 39);
            this.btn_mini.TabIndex = 460;
            this.btn_mini.UseVisualStyleBackColor = false;
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "Marcar Asistencia";
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.Location = new System.Drawing.Point(4, 12);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(40, 37);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1468, 5);
            this.label1.TabIndex = 0;
            // 
            // pnl_Msm
            // 
            this.pnl_Msm.Controls.Add(this.lbl_Cont);
            this.pnl_Msm.Location = new System.Drawing.Point(628, 250);
            this.pnl_Msm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Msm.Name = "pnl_Msm";
            this.pnl_Msm.Size = new System.Drawing.Size(162, 56);
            this.pnl_Msm.TabIndex = 179;
            // 
            // lbl_Cont
            // 
            this.lbl_Cont.AutoSize = true;
            this.lbl_Cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_Cont.Location = new System.Drawing.Point(57, 6);
            this.lbl_Cont.Name = "lbl_Cont";
            this.lbl_Cont.Size = new System.Drawing.Size(37, 39);
            this.lbl_Cont.TabIndex = 156;
            this.lbl_Cont.Text = "1";
            // 
            // lbl_totaltarde
            // 
            this.lbl_totaltarde.Enabled = false;
            this.lbl_totaltarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totaltarde.Location = new System.Drawing.Point(1236, 428);
            this.lbl_totaltarde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_totaltarde.Name = "lbl_totaltarde";
            this.lbl_totaltarde.Size = new System.Drawing.Size(82, 26);
            this.lbl_totaltarde.TabIndex = 178;
            // 
            // lbl_justifi
            // 
            this.lbl_justifi.Enabled = false;
            this.lbl_justifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_justifi.Location = new System.Drawing.Point(1108, 428);
            this.lbl_justifi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_justifi.Name = "lbl_justifi";
            this.lbl_justifi.Size = new System.Drawing.Size(104, 26);
            this.lbl_justifi.TabIndex = 177;
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.Enabled = false;
            this.lbl_Dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dni.Location = new System.Drawing.Point(914, 428);
            this.lbl_Dni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(160, 26);
            this.lbl_Dni.TabIndex = 176;
            // 
            // lbl_IdAsis
            // 
            this.lbl_IdAsis.AutoSize = true;
            this.lbl_IdAsis.Location = new System.Drawing.Point(1104, 534);
            this.lbl_IdAsis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdAsis.Name = "lbl_IdAsis";
            this.lbl_IdAsis.Size = new System.Drawing.Size(133, 16);
            this.lbl_IdAsis.TabIndex = 175;
            this.lbl_IdAsis.Text = "000000000000000000";
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(951, 610);
            this.lblExtra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(14, 16);
            this.lblExtra.TabIndex = 174;
            this.lblExtra.Text = "0";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(1172, 610);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(14, 16);
            this.lblMinutos.TabIndex = 173;
            this.lblMinutos.Text = "0";
            // 
            // lbl_TotalHotrabajda
            // 
            this.lbl_TotalHotrabajda.AutoSize = true;
            this.lbl_TotalHotrabajda.Location = new System.Drawing.Point(1063, 610);
            this.lbl_TotalHotrabajda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TotalHotrabajda.Name = "lbl_TotalHotrabajda";
            this.lbl_TotalHotrabajda.Size = new System.Drawing.Size(14, 16);
            this.lbl_TotalHotrabajda.TabIndex = 172;
            this.lbl_TotalHotrabajda.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(965, 395);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 22);
            this.label5.TabIndex = 171;
            this.label5.Text = "Rut";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picSocio
            // 
            this.picSocio.Image = ((System.Drawing.Image)(resources.GetObject("picSocio.Image")));
            this.picSocio.Location = new System.Drawing.Point(598, 462);
            this.picSocio.Margin = new System.Windows.Forms.Padding(4);
            this.picSocio.Name = "picSocio";
            this.picSocio.Size = new System.Drawing.Size(235, 204);
            this.picSocio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSocio.TabIndex = 170;
            this.picSocio.TabStop = false;
            // 
            // Lbl_Idperso
            // 
            this.Lbl_Idperso.Enabled = false;
            this.Lbl_Idperso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Idperso.Location = new System.Drawing.Point(346, 419);
            this.Lbl_Idperso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lbl_Idperso.Name = "Lbl_Idperso";
            this.Lbl_Idperso.Size = new System.Drawing.Size(160, 26);
            this.Lbl_Idperso.TabIndex = 169;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(369, 395);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 168;
            this.label3.Text = "ID Personal:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_nombresocio
            // 
            this.lbl_nombresocio.Enabled = false;
            this.lbl_nombresocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombresocio.Location = new System.Drawing.Point(434, 332);
            this.lbl_nombresocio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_nombresocio.Name = "lbl_nombresocio";
            this.lbl_nombresocio.Size = new System.Drawing.Size(615, 30);
            this.lbl_nombresocio.TabIndex = 167;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(279, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 23);
            this.label6.TabIndex = 166;
            this.label6.Text = "Nombre Socio:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label21);
            this.GroupBox2.Controls.Add(this.dtp_hora_tolercia);
            this.GroupBox2.Controls.Add(this.Label24);
            this.GroupBox2.Controls.Add(this.Label25);
            this.GroupBox2.Controls.Add(this.Label26);
            this.GroupBox2.Controls.Add(this.Dtp_Hora_Limite);
            this.GroupBox2.Controls.Add(this.Label27);
            this.GroupBox2.Controls.Add(this.dtp_horaIngre);
            this.GroupBox2.Controls.Add(this.dtp_horaSalida);
            this.GroupBox2.Location = new System.Drawing.Point(88, 495);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(258, 190);
            this.GroupBox2.TabIndex = 165;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "HORARIOS DEFINIDOS";
            this.GroupBox2.Visible = false;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(48, 170);
            this.Label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(47, 16);
            this.Label21.TabIndex = 18;
            this.Label21.Text = "idAsis:";
            // 
            // dtp_hora_tolercia
            // 
            this.dtp_hora_tolercia.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_hora_tolercia.Location = new System.Drawing.Point(105, 58);
            this.dtp_hora_tolercia.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_hora_tolercia.Name = "dtp_hora_tolercia";
            this.dtp_hora_tolercia.Size = new System.Drawing.Size(137, 22);
            this.dtp_hora_tolercia.TabIndex = 13;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(24, 98);
            this.Label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(68, 16);
            this.Label24.TabIndex = 12;
            this.Label24.Text = "hora limite";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(35, 58);
            this.Label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(58, 16);
            this.Label25.TabIndex = 9;
            this.Label25.Text = "tolrancia";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(20, 137);
            this.Label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(74, 16);
            this.Label26.TabIndex = 8;
            this.Label26.Text = "hora salida";
            // 
            // Dtp_Hora_Limite
            // 
            this.Dtp_Hora_Limite.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_Hora_Limite.Location = new System.Drawing.Point(105, 90);
            this.Dtp_Hora_Limite.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Hora_Limite.Name = "Dtp_Hora_Limite";
            this.Dtp_Hora_Limite.Size = new System.Drawing.Size(137, 22);
            this.Dtp_Hora_Limite.TabIndex = 11;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(11, 23);
            this.Label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(82, 16);
            this.Label27.TabIndex = 7;
            this.Label27.Text = "hora ingreso";
            // 
            // dtp_horaIngre
            // 
            this.dtp_horaIngre.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horaIngre.Location = new System.Drawing.Point(105, 23);
            this.dtp_horaIngre.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_horaIngre.Name = "dtp_horaIngre";
            this.dtp_horaIngre.Size = new System.Drawing.Size(137, 22);
            this.dtp_horaIngre.TabIndex = 5;
            // 
            // dtp_horaSalida
            // 
            this.dtp_horaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horaSalida.Location = new System.Drawing.Point(105, 130);
            this.dtp_horaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_horaSalida.Name = "dtp_horaSalida";
            this.dtp_horaSalida.Size = new System.Drawing.Size(137, 22);
            this.dtp_horaSalida.TabIndex = 6;
            // 
            // xVerificationControl
            // 
            this.xVerificationControl.Active = true;
            this.xVerificationControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xVerificationControl.Location = new System.Drawing.Point(647, 86);
            this.xVerificationControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.xVerificationControl.Name = "xVerificationControl";
            this.xVerificationControl.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.xVerificationControl.Size = new System.Drawing.Size(76, 50);
            this.xVerificationControl.TabIndex = 180;
            this.xVerificationControl.OnComplete += new DPFP.Gui.Verification.VerificationControl._OnComplete(this.xVerificationControl_OnComplete);
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(1803, 109);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(157, 39);
            this.lbl_hora.TabIndex = 182;
            this.lbl_hora.Text = "00:00:00";
            // 
            // Lbl_HoraEntrada
            // 
            this.Lbl_HoraEntrada.AutoSize = true;
            this.Lbl_HoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HoraEntrada.Location = new System.Drawing.Point(29, 89);
            this.Lbl_HoraEntrada.Name = "Lbl_HoraEntrada";
            this.Lbl_HoraEntrada.Size = new System.Drawing.Size(107, 39);
            this.Lbl_HoraEntrada.TabIndex = 181;
            this.Lbl_HoraEntrada.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3044, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 39);
            this.label2.TabIndex = 184;
            this.label2.Text = "00:00:00";
            // 
            // lbl_hora1
            // 
            this.lbl_hora1.AutoSize = true;
            this.lbl_hora1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora1.Location = new System.Drawing.Point(1241, 89);
            this.lbl_hora1.Name = "lbl_hora1";
            this.lbl_hora1.Size = new System.Drawing.Size(157, 39);
            this.lbl_hora1.TabIndex = 185;
            this.lbl_hora1.Text = "00:00:00";
            // 
            // lbl_msm
            // 
            this.lbl_msm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_msm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msm.ForeColor = System.Drawing.Color.White;
            this.lbl_msm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_msm.Location = new System.Drawing.Point(0, 142);
            this.lbl_msm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_msm.Name = "lbl_msm";
            this.lbl_msm.Size = new System.Drawing.Size(1468, 92);
            this.lbl_msm.TabIndex = 186;
            this.lbl_msm.Text = "Dni:";
            this.lbl_msm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmr_Conta
            // 
            this.tmr_Conta.Enabled = true;
            this.tmr_Conta.Interval = 1000;
            this.tmr_Conta.Tick += new System.EventHandler(this.tmr_Conta_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtp_HoraActual
            // 
            this.dtp_HoraActual.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_HoraActual.Location = new System.Drawing.Point(1289, 273);
            this.dtp_HoraActual.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_HoraActual.Name = "dtp_HoraActual";
            this.dtp_HoraActual.Size = new System.Drawing.Size(137, 22);
            this.dtp_HoraActual.TabIndex = 187;
            this.dtp_HoraActual.Visible = false;
            // 
            // elipseComponent1
            // 
            this.elipseComponent1.CornerRadius = 30;
            this.elipseComponent1.TargetControl = this;
            // 
            // LblSeccion
            // 
            this.LblSeccion.AutoSize = true;
            this.LblSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeccion.Location = new System.Drawing.Point(1150, 344);
            this.LblSeccion.Name = "LblSeccion";
            this.LblSeccion.Size = new System.Drawing.Size(229, 36);
            this.LblSeccion.TabIndex = 188;
            this.LblSeccion.Text = "administracion";
            // 
            // LblTurno2
            // 
            this.LblTurno2.AutoSize = true;
            this.LblTurno2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTurno2.Location = new System.Drawing.Point(188, 344);
            this.LblTurno2.Name = "LblTurno2";
            this.LblTurno2.Size = new System.Drawing.Size(0, 29);
            this.LblTurno2.TabIndex = 189;
            // 
            // AsistenciaHuella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1468, 718);
            this.Controls.Add(this.LblTurno2);
            this.Controls.Add(this.LblSeccion);
            this.Controls.Add(this.dtp_HoraActual);
            this.Controls.Add(this.lbl_msm);
            this.Controls.Add(this.lbl_hora1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.Lbl_HoraEntrada);
            this.Controls.Add(this.xVerificationControl);
            this.Controls.Add(this.pnl_Msm);
            this.Controls.Add(this.lbl_totaltarde);
            this.Controls.Add(this.lbl_justifi);
            this.Controls.Add(this.lbl_Dni);
            this.Controls.Add(this.lbl_IdAsis);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lbl_TotalHotrabajda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picSocio);
            this.Controls.Add(this.Lbl_Idperso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_nombresocio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AsistenciaHuella";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsistenciaHuella";
            this.Load += new System.EventHandler(this.AsistenciaHuella_Load);
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            this.pnl_Msm.ResumeLayout(false);
            this.pnl_Msm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSocio)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.ElipseComponent elipseComponent1;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Msm;
        private System.Windows.Forms.Label lbl_Cont;
        private System.Windows.Forms.TextBox lbl_totaltarde;
        private System.Windows.Forms.TextBox lbl_justifi;
        private System.Windows.Forms.TextBox lbl_Dni;
        internal System.Windows.Forms.Label lbl_IdAsis;
        internal System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.Label lblMinutos;
        internal System.Windows.Forms.Label lbl_TotalHotrabajda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picSocio;
        private System.Windows.Forms.TextBox Lbl_Idperso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lbl_nombresocio;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.DateTimePicker dtp_hora_tolercia;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.DateTimePicker Dtp_Hora_Limite;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.DateTimePicker dtp_horaIngre;
        internal System.Windows.Forms.DateTimePicker dtp_horaSalida;
        private DPFP.Gui.Verification.VerificationControl xVerificationControl;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label Lbl_HoraEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_hora1;
        private System.Windows.Forms.Label lbl_msm;
        private System.Windows.Forms.Timer tmr_Conta;
        internal System.Windows.Forms.DateTimePicker dtp_HoraActual;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label LblSeccion;
        public System.Windows.Forms.Label LblTurno2;
    }
}