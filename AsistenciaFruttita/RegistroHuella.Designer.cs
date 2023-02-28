namespace AsistenciaFruttita
{
    partial class RegistroHuella
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroHuella));
            this.EnrollmentControl = new DPFP.Gui.Enrollment.EnrollmentControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nomPersona = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_nroDni = new System.Windows.Forms.Label();
            this.lbl_idperso = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListEvents = new System.Windows.Forms.ListBox();
            this.botonesRedondos1 = new AsistenciaFruttita.BotonesRedondos();
            this.elipseComponent1 = new AsistenciaFruttita.Components.ElipseComponent();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnrollmentControl
            // 
            this.EnrollmentControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EnrollmentControl.EnrolledFingerMask = 0;
            this.EnrollmentControl.Location = new System.Drawing.Point(33, 98);
            this.EnrollmentControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.EnrollmentControl.MaxEnrollFingerCount = 10;
            this.EnrollmentControl.Name = "EnrollmentControl";
            this.EnrollmentControl.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.EnrollmentControl.Size = new System.Drawing.Size(743, 483);
            this.EnrollmentControl.TabIndex = 11;
            this.EnrollmentControl.OnEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnEnroll(this.EnrollmentControl_OnEnroll);
            this.EnrollmentControl.OnFingerTouch += new DPFP.Gui.Enrollment.EnrollmentControl._OnFingerTouch(this.EnrollmentControl_OnFingerTouch_1);
            this.EnrollmentControl.OnFingerRemove += new DPFP.Gui.Enrollment.EnrollmentControl._OnFingerRemove(this.EnrollmentControl_OnFingerRemove_1);
            this.EnrollmentControl.OnReaderConnect += new DPFP.Gui.Enrollment.EnrollmentControl._OnReaderConnect(this.EnrollmentControl_OnReaderConnect_1);
            this.EnrollmentControl.OnReaderDisconnect += new DPFP.Gui.Enrollment.EnrollmentControl._OnReaderDisconnect(this.EnrollmentControl_OnReaderDisconnect_1);
            this.EnrollmentControl.OnSampleQuality += new DPFP.Gui.Enrollment.EnrollmentControl._OnSampleQuality(this.EnrollmentControl_OnSampleQuality_1);
            this.EnrollmentControl.OnStartEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnStartEnroll(this.EnrollmentControl_OnStartEnroll_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 63);
            this.panel1.TabIndex = 12;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.Location = new System.Drawing.Point(1282, 9);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(48, 49);
            this.btn_Salir.TabIndex = 27;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(31, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(530, 27);
            this.label7.TabIndex = 26;
            this.label7.Text = "REGISTRO DACTILAR DE HUELLA DEL PERSONAL";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(3, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1343, 19);
            this.panel2.TabIndex = 13;
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(1006, 82);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(227, 223);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 13;
            this.picFoto.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(897, 335);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre del Personal:";
            // 
            // lbl_nomPersona
            // 
            this.lbl_nomPersona.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomPersona.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomPersona.ForeColor = System.Drawing.Color.Black;
            this.lbl_nomPersona.Location = new System.Drawing.Point(896, 368);
            this.lbl_nomPersona.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nomPersona.Name = "lbl_nomPersona";
            this.lbl_nomPersona.Size = new System.Drawing.Size(388, 75);
            this.lbl_nomPersona.TabIndex = 29;
            this.lbl_nomPersona.Text = "REGISTRO DACTILAR DE HUELLA DEL PERSONAL";
            this.lbl_nomPersona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(910, 486);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nro Rut:";
            // 
            // lbl_nroDni
            // 
            this.lbl_nroDni.AutoSize = true;
            this.lbl_nroDni.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nroDni.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nroDni.ForeColor = System.Drawing.Color.Black;
            this.lbl_nroDni.Location = new System.Drawing.Point(940, 524);
            this.lbl_nroDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nroDni.Name = "lbl_nroDni";
            this.lbl_nroDni.Size = new System.Drawing.Size(38, 27);
            this.lbl_nroDni.TabIndex = 31;
            this.lbl_nroDni.Text = "00";
            this.lbl_nroDni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_idperso
            // 
            this.lbl_idperso.AutoSize = true;
            this.lbl_idperso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idperso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idperso.ForeColor = System.Drawing.Color.Black;
            this.lbl_idperso.Location = new System.Drawing.Point(1122, 524);
            this.lbl_idperso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idperso.Name = "lbl_idperso";
            this.lbl_idperso.Size = new System.Drawing.Size(38, 27);
            this.lbl_idperso.TabIndex = 52;
            this.lbl_idperso.Text = "00";
            this.lbl_idperso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ListEvents);
            this.panel3.Location = new System.Drawing.Point(38, 594);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 205);
            this.panel3.TabIndex = 54;
            // 
            // ListEvents
            // 
            this.ListEvents.BackColor = System.Drawing.Color.White;
            this.ListEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListEvents.ForeColor = System.Drawing.Color.DimGray;
            this.ListEvents.FormattingEnabled = true;
            this.ListEvents.ItemHeight = 20;
            this.ListEvents.Location = new System.Drawing.Point(22, 27);
            this.ListEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListEvents.Name = "ListEvents";
            this.ListEvents.Size = new System.Drawing.Size(686, 160);
            this.ListEvents.TabIndex = 0;
            // 
            // botonesRedondos1
            // 
            this.botonesRedondos1.BackColor = System.Drawing.Color.DarkGray;
            this.botonesRedondos1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.botonesRedondos1.BorderColor = System.Drawing.Color.DarkGray;
            this.botonesRedondos1.BorderRadius = 30;
            this.botonesRedondos1.BorderSize = 0;
            this.botonesRedondos1.FlatAppearance.BorderSize = 0;
            this.botonesRedondos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonesRedondos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonesRedondos1.ForeColor = System.Drawing.Color.White;
            this.botonesRedondos1.Location = new System.Drawing.Point(983, 613);
            this.botonesRedondos1.Name = "botonesRedondos1";
            this.botonesRedondos1.Size = new System.Drawing.Size(211, 76);
            this.botonesRedondos1.TabIndex = 53;
            this.botonesRedondos1.Text = "Cancelar";
            this.botonesRedondos1.TextColor = System.Drawing.Color.White;
            this.botonesRedondos1.UseVisualStyleBackColor = false;
            this.botonesRedondos1.Click += new System.EventHandler(this.botonesRedondos1_Click);
            // 
            // elipseComponent1
            // 
            this.elipseComponent1.CornerRadius = 30;
            this.elipseComponent1.TargetControl = this;
            // 
            // RegistroHuella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 821);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.botonesRedondos1);
            this.Controls.Add(this.lbl_idperso);
            this.Controls.Add(this.lbl_nroDni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_nomPersona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EnrollmentControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroHuella";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroHuella";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.ElipseComponent elipseComponent1;
        private DPFP.Gui.Enrollment.EnrollmentControl EnrollmentControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox ListEvents;
        private BotonesRedondos botonesRedondos1;
        private System.Windows.Forms.Label lbl_idperso;
        private System.Windows.Forms.Label lbl_nroDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nomPersona;
        private System.Windows.Forms.Button btn_Salir;
    }
}