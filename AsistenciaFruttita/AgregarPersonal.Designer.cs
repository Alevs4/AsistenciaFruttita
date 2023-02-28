namespace AsistenciaFruttita
{
    partial class AgregarPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPersonal));
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.txt_IdPersona = new System.Windows.Forms.TextBox();
            this.TxtRut = new System.Windows.Forms.TextBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_NroCelular = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_sexo = new System.Windows.Forms.ComboBox();
            this.cbo_rol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_fechaNaci = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.Pic_persona = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txtestado = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.CboRol = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_Distrito = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CboTurno = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DTP_Cambio = new System.Windows.Forms.DateTimePicker();
            this.botonesRedondos1 = new AsistenciaFruttita.BotonesRedondos();
            this.BtnGuardar = new AsistenciaFruttita.BotonesRedondos();
            this.BtnDesactivar = new AsistenciaFruttita.BotonesRedondos();
            this.BtnEditar = new AsistenciaFruttita.BotonesRedondos();
            this.botonesRedondos2 = new AsistenciaFruttita.BotonesRedondos();
            this.elipseComponent1 = new AsistenciaFruttita.Components.ElipseComponent();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_persona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(247, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "REGISTRO DE PERSONAL";
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.Location = new System.Drawing.Point(1121, 9);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(43, 39);
            this.btn_Salir.TabIndex = 27;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // txt_IdPersona
            // 
            this.txt_IdPersona.Enabled = false;
            this.txt_IdPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdPersona.Location = new System.Drawing.Point(285, 84);
            this.txt_IdPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_IdPersona.Name = "txt_IdPersona";
            this.txt_IdPersona.Size = new System.Drawing.Size(234, 30);
            this.txt_IdPersona.TabIndex = 28;
            // 
            // TxtRut
            // 
            this.TxtRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRut.Location = new System.Drawing.Point(285, 155);
            this.TxtRut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.Size = new System.Drawing.Size(234, 30);
            this.TxtRut.TabIndex = 29;
            this.TxtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRut_KeyPress);
            // 
            // txt_nombres
            // 
            this.txt_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombres.Location = new System.Drawing.Point(285, 214);
            this.txt_nombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(504, 30);
            this.txt_nombres.TabIndex = 30;
            // 
            // txt_NroCelular
            // 
            this.txt_NroCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NroCelular.Location = new System.Drawing.Point(285, 278);
            this.txt_NroCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NroCelular.Name = "txt_NroCelular";
            this.txt_NroCelular.Size = new System.Drawing.Size(234, 30);
            this.txt_NroCelular.TabIndex = 31;
            this.txt_NroCelular.TextChanged += new System.EventHandler(this.txt_NroCelular_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 679);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 8);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "ID Personal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Rut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nombre Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Celular";
            // 
            // cbo_sexo
            // 
            this.cbo_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_sexo.FormattingEnabled = true;
            this.cbo_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Indefinido"});
            this.cbo_sexo.Location = new System.Drawing.Point(285, 357);
            this.cbo_sexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_sexo.Name = "cbo_sexo";
            this.cbo_sexo.Size = new System.Drawing.Size(234, 33);
            this.cbo_sexo.TabIndex = 37;
            // 
            // cbo_rol
            // 
            this.cbo_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_rol.FormattingEnabled = true;
            this.cbo_rol.Items.AddRange(new object[] {
            "Adminstracion ",
            "Packing",
            "Mantencion",
            "Sadema",
            "Bodega",
            "Recepcion"});
            this.cbo_rol.Location = new System.Drawing.Point(285, 406);
            this.cbo_rol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_rol.Name = "cbo_rol";
            this.cbo_rol.Size = new System.Drawing.Size(234, 33);
            this.cbo_rol.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Seccion";
            // 
            // dtp_fechaNaci
            // 
            this.dtp_fechaNaci.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaNaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaNaci.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaNaci.Location = new System.Drawing.Point(684, 358);
            this.dtp_fechaNaci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_fechaNaci.Name = "dtp_fechaNaci";
            this.dtp_fechaNaci.Size = new System.Drawing.Size(185, 30);
            this.dtp_fechaNaci.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(547, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 23);
            this.label9.TabIndex = 44;
            this.label9.Text = "Fecha Ingreso";
            // 
            // Pic_persona
            // 
            this.Pic_persona.Image = ((System.Drawing.Image)(resources.GetObject("Pic_persona.Image")));
            this.Pic_persona.Location = new System.Drawing.Point(866, 84);
            this.Pic_persona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pic_persona.Name = "Pic_persona";
            this.Pic_persona.Size = new System.Drawing.Size(252, 215);
            this.Pic_persona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_persona.TabIndex = 45;
            this.Pic_persona.TabStop = false;
            this.Pic_persona.Click += new System.EventHandler(this.Pic_persona_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(557, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 23);
            this.label10.TabIndex = 46;
            this.label10.Text = "Estado";
            // 
            // Txtestado
            // 
            this.Txtestado.Enabled = false;
            this.Txtestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtestado.Location = new System.Drawing.Point(684, 406);
            this.Txtestado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtestado.Name = "Txtestado";
            this.Txtestado.Size = new System.Drawing.Size(185, 30);
            this.Txtestado.TabIndex = 47;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(612, 84);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.Controls.Add(this.btn_Salir);
            this.pnl_titulo.Controls.Add(this.label7);
            this.pnl_titulo.Location = new System.Drawing.Point(-1, 0);
            this.pnl_titulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1167, 52);
            this.pnl_titulo.TabIndex = 54;
            this.pnl_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseMove);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(557, 465);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 23);
            this.label11.TabIndex = 56;
            this.label11.Text = "Cargo";
            // 
            // CboRol
            // 
            this.CboRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboRol.FormattingEnabled = true;
            this.CboRol.Items.AddRange(new object[] {
            "Op. De Grúa",
            "Op. De Patio",
            "Enc. De Patio",
            "Digitador(a)",
            "Movilizadores",
            "Control De Calidad",
            "Enc. Control De Calidad",
            "Op. Prefrío",
            "Camarero",
            "Jefe Turno Packing",
            "Op. Línea",
            "Embaladoras",
            "Movilizador Fruta Com.",
            "Enc. Sellado",
            "Selladoras",
            "Enc. Altillo",
            "Op. Altillo",
            "Encargado De Paletizaje",
            "Paletizadores",
            "Traspaleteros",
            "Enzunchadores",
            "Enc. Tarjado",
            "Tarjador(a)",
            "Asistente Administativo",
            "Op. Segregador",
            "Op. AC 350",
            "Enc. De Frío",
            "Op. De Frío",
            "Enc. De Repa",
            "Operario de Bodega",
            "Profecional Sag",
            "Técnico Sag",
            "Administrativo",
            "Enc. Sistema y Cuadratura",
            "Enc. Bodega",
            "Enc. Informatica",
            "Enc. Sadema",
            "Enc. Envases",
            "Enc. Labores de aseo",
            "Jardinero",
            "Mecanico",
            "Ope. Sadema",
            "Ope. Packing",
            "Ope. Mantencion",
            "Administrativo(a) Despacho"});
            this.CboRol.Location = new System.Drawing.Point(684, 456);
            this.CboRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboRol.Name = "CboRol";
            this.CboRol.Size = new System.Drawing.Size(315, 33);
            this.CboRol.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 23);
            this.label8.TabIndex = 42;
            this.label8.Text = "Localidad";
            // 
            // cbo_Distrito
            // 
            this.cbo_Distrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Distrito.FormattingEnabled = true;
            this.cbo_Distrito.Items.AddRange(new object[] {
            "Chimbarongo",
            "Teno",
            "Curico",
            "Molina",
            "Lontue",
            "San Fernando ",
            "Placilla",
            "Nancagua",
            "Santa cruz"});
            this.cbo_Distrito.Location = new System.Drawing.Point(285, 460);
            this.cbo_Distrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Distrito.Name = "cbo_Distrito";
            this.cbo_Distrito.Size = new System.Drawing.Size(234, 33);
            this.cbo_Distrito.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(117, 526);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 23);
            this.label12.TabIndex = 57;
            this.label12.Text = "Turno";
            // 
            // CboTurno
            // 
            this.CboTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTurno.FormattingEnabled = true;
            this.CboTurno.Items.AddRange(new object[] {
            "Turno 1",
            "Turno 2"});
            this.CboTurno.Location = new System.Drawing.Point(285, 520);
            this.CboTurno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboTurno.Name = "CboTurno";
            this.CboTurno.Size = new System.Drawing.Size(234, 33);
            this.CboTurno.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(547, 526);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(225, 23);
            this.label13.TabIndex = 59;
            this.label13.Text = "Fecha Cambio Turno o Cargo";
            // 
            // DTP_Cambio
            // 
            this.DTP_Cambio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Cambio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Cambio.Location = new System.Drawing.Point(814, 518);
            this.DTP_Cambio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTP_Cambio.Name = "DTP_Cambio";
            this.DTP_Cambio.Size = new System.Drawing.Size(185, 30);
            this.DTP_Cambio.TabIndex = 60;
            // 
            // botonesRedondos1
            // 
            this.botonesRedondos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botonesRedondos1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botonesRedondos1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botonesRedondos1.BorderRadius = 30;
            this.botonesRedondos1.BorderSize = 1;
            this.botonesRedondos1.FlatAppearance.BorderSize = 0;
            this.botonesRedondos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonesRedondos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonesRedondos1.ForeColor = System.Drawing.Color.White;
            this.botonesRedondos1.Location = new System.Drawing.Point(955, 587);
            this.botonesRedondos1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonesRedondos1.Name = "botonesRedondos1";
            this.botonesRedondos1.Size = new System.Drawing.Size(179, 72);
            this.botonesRedondos1.TabIndex = 61;
            this.botonesRedondos1.Text = "Cambio Turno O cargo";
            this.botonesRedondos1.TextColor = System.Drawing.Color.White;
            this.botonesRedondos1.UseVisualStyleBackColor = false;
            this.botonesRedondos1.Click += new System.EventHandler(this.botonesRedondos1_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGuardar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGuardar.BorderRadius = 30;
            this.BtnGuardar.BorderSize = 1;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(27, 587);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(172, 72);
            this.BtnGuardar.TabIndex = 52;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextColor = System.Drawing.Color.White;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnDesactivar
            // 
            this.BtnDesactivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDesactivar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDesactivar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDesactivar.BorderRadius = 30;
            this.BtnDesactivar.BorderSize = 1;
            this.BtnDesactivar.FlatAppearance.BorderSize = 0;
            this.BtnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesactivar.ForeColor = System.Drawing.Color.White;
            this.BtnDesactivar.Location = new System.Drawing.Point(727, 587);
            this.BtnDesactivar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDesactivar.Name = "BtnDesactivar";
            this.BtnDesactivar.Size = new System.Drawing.Size(179, 72);
            this.BtnDesactivar.TabIndex = 51;
            this.BtnDesactivar.Text = "Desactivar Persona";
            this.BtnDesactivar.TextColor = System.Drawing.Color.White;
            this.BtnDesactivar.UseVisualStyleBackColor = false;
            this.BtnDesactivar.Click += new System.EventHandler(this.BtnDesactivar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEditar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEditar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEditar.BorderRadius = 30;
            this.BtnEditar.BorderSize = 1;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(495, 587);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(178, 72);
            this.BtnEditar.TabIndex = 50;
            this.BtnEditar.Text = "Editar o activar Persona";
            this.BtnEditar.TextColor = System.Drawing.Color.White;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // botonesRedondos2
            // 
            this.botonesRedondos2.BackColor = System.Drawing.Color.Blue;
            this.botonesRedondos2.BackgroundColor = System.Drawing.Color.Blue;
            this.botonesRedondos2.BorderColor = System.Drawing.Color.Blue;
            this.botonesRedondos2.BorderRadius = 30;
            this.botonesRedondos2.BorderSize = 1;
            this.botonesRedondos2.FlatAppearance.BorderSize = 0;
            this.botonesRedondos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonesRedondos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonesRedondos2.ForeColor = System.Drawing.Color.White;
            this.botonesRedondos2.Location = new System.Drawing.Point(250, 587);
            this.botonesRedondos2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonesRedondos2.Name = "botonesRedondos2";
            this.botonesRedondos2.Size = new System.Drawing.Size(178, 72);
            this.botonesRedondos2.TabIndex = 49;
            this.botonesRedondos2.Text = "Cancelar";
            this.botonesRedondos2.TextColor = System.Drawing.Color.White;
            this.botonesRedondos2.UseVisualStyleBackColor = false;
            this.botonesRedondos2.Click += new System.EventHandler(this.botonesRedondos2_Click);
            // 
            // elipseComponent1
            // 
            this.elipseComponent1.CornerRadius = 50;
            this.elipseComponent1.TargetControl = this;
            // 
            // AgregarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 726);
            this.Controls.Add(this.botonesRedondos1);
            this.Controls.Add(this.DTP_Cambio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CboTurno);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CboRol);
            this.Controls.Add(this.pnl_titulo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnDesactivar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.botonesRedondos2);
            this.Controls.Add(this.Txtestado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Pic_persona);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtp_fechaNaci);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_Distrito);
            this.Controls.Add(this.cbo_rol);
            this.Controls.Add(this.cbo_sexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_NroCelular);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.TxtRut);
            this.Controls.Add(this.txt_IdPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgregarPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarPersonal";
            this.Load += new System.EventHandler(this.AgregarPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_persona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.ElipseComponent elipseComponent1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_NroCelular;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox TxtRut;
        private System.Windows.Forms.TextBox txt_IdPersona;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_sexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BotonesRedondos BtnDesactivar;
        private BotonesRedondos BtnEditar;
        private BotonesRedondos botonesRedondos2;
        private System.Windows.Forms.TextBox Txtestado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox Pic_persona;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_fechaNaci;
        private BotonesRedondos BtnGuardar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CboRol;
        private System.Windows.Forms.ComboBox cbo_rol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_Distrito;
        private System.Windows.Forms.DateTimePicker DTP_Cambio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CboTurno;
        private System.Windows.Forms.Label label12;
        private BotonesRedondos botonesRedondos1;
    }
}