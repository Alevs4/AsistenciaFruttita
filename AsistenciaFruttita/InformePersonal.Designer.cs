namespace AsistenciaFruttita
{
    partial class InformePersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformePersonal));
            this.label1 = new System.Windows.Forms.Label();
            this.GrillaPersonal = new System.Windows.Forms.DataGridView();
            this.BtnAceptar = new AsistenciaFruttita.BotonesRedondos();
            this.BtnCancelar = new AsistenciaFruttita.BotonesRedondos();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(624, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Planta";
            // 
            // GrillaPersonal
            // 
            this.GrillaPersonal.AllowUserToAddRows = false;
            this.GrillaPersonal.AllowUserToDeleteRows = false;
            this.GrillaPersonal.AllowUserToOrderColumns = true;
            this.GrillaPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaPersonal.Location = new System.Drawing.Point(103, 127);
            this.GrillaPersonal.Name = "GrillaPersonal";
            this.GrillaPersonal.ReadOnly = true;
            this.GrillaPersonal.RowHeadersWidth = 51;
            this.GrillaPersonal.RowTemplate.Height = 24;
            this.GrillaPersonal.Size = new System.Drawing.Size(1297, 396);
            this.GrillaPersonal.TabIndex = 5;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAceptar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAceptar.BorderRadius = 10;
            this.BtnAceptar.BorderSize = 0;
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.Black;
            this.BtnAceptar.Location = new System.Drawing.Point(879, 604);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(130, 32);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Excel";
            this.BtnAceptar.TextColor = System.Drawing.Color.Black;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Blue;
            this.BtnCancelar.BackgroundColor = System.Drawing.Color.Blue;
            this.BtnCancelar.BorderColor = System.Drawing.Color.Blue;
            this.BtnCancelar.BorderRadius = 10;
            this.BtnCancelar.BorderSize = 1;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(1115, 604);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(133, 32);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextColor = System.Drawing.Color.White;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // InformePersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 704);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GrillaPersonal);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformePersonal";
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.InformePersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public BotonesRedondos BtnCancelar;
        public BotonesRedondos BtnAceptar;
        private System.Windows.Forms.DataGridView GrillaPersonal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}