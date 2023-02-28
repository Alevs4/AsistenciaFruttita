namespace AsistenciaFruttita
{
    partial class ReporteAsis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteAsis));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.GrillaAsistencia = new System.Windows.Forms.DataGridView();
            this.Label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.elipseComponent1 = new AsistenciaFruttita.Components.ElipseComponent();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_titulo.Controls.Add(this.btn_exportar);
            this.pnl_titulo.Controls.Add(this.btn_Cerrar);
            this.pnl_titulo.Controls.Add(this.lbl_Titulo);
            this.pnl_titulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1853, 62);
            this.pnl_titulo.TabIndex = 431;
            this.pnl_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseMove);
            // 
            // btn_exportar
            // 
            this.btn_exportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exportar.FlatAppearance.BorderSize = 0;
            this.btn_exportar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_exportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportar.Image = ((System.Drawing.Image)(resources.GetObject("btn_exportar.Image")));
            this.btn_exportar.Location = new System.Drawing.Point(1644, 10);
            this.btn_exportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(36, 37);
            this.btn_exportar.TabIndex = 428;
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(1813, 7);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(27, 28);
            this.btn_Cerrar.TabIndex = 426;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Titulo.Location = new System.Drawing.Point(8, 6);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(218, 27);
            this.lbl_Titulo.TabIndex = 40;
            this.lbl_Titulo.Text = "Informe asistencia";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GrillaAsistencia
            // 
            this.GrillaAsistencia.AllowUserToAddRows = false;
            this.GrillaAsistencia.AllowUserToDeleteRows = false;
            this.GrillaAsistencia.AllowUserToOrderColumns = true;
            this.GrillaAsistencia.AllowUserToResizeColumns = false;
            this.GrillaAsistencia.AllowUserToResizeRows = false;
            this.GrillaAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GrillaAsistencia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrillaAsistencia.BackgroundColor = System.Drawing.Color.White;
            this.GrillaAsistencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GrillaAsistencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaAsistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrillaAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaAsistencia.EnableHeadersVisualStyles = false;
            this.GrillaAsistencia.GridColor = System.Drawing.Color.DarkGray;
            this.GrillaAsistencia.Location = new System.Drawing.Point(12, 278);
            this.GrillaAsistencia.Name = "GrillaAsistencia";
            this.GrillaAsistencia.ReadOnly = true;
            this.GrillaAsistencia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaAsistencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GrillaAsistencia.RowHeadersWidth = 80;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.GrillaAsistencia.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GrillaAsistencia.RowTemplate.Height = 28;
            this.GrillaAsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaAsistencia.Size = new System.Drawing.Size(1829, 529);
            this.GrillaAsistencia.TabIndex = 436;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Black;
            this.Label9.Location = new System.Drawing.Point(582, 86);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(486, 37);
            this.Label9.TabIndex = 437;
            this.Label9.Text = "Informes de asistencia de personal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 438;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(582, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 37);
            this.label1.TabIndex = 439;
            this.label1.Text = "Buscar";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(724, 206);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(399, 30);
            this.txt_Buscar.TabIndex = 440;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // elipseComponent1
            // 
            this.elipseComponent1.CornerRadius = 30;
            this.elipseComponent1.TargetControl = this;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.Black;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(1164, 183);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(70, 55);
            this.btn_refresh.TabIndex = 441;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // ReporteAsis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1853, 908);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.GrillaAsistencia);
            this.Controls.Add(this.pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteAsis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteAsis";
            this.Load += new System.EventHandler(this.ReporteAsis_Load);
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.ElipseComponent elipseComponent1;
        internal System.Windows.Forms.Panel pnl_titulo;
        internal System.Windows.Forms.Button btn_exportar;
        internal System.Windows.Forms.Button btn_Cerrar;
        internal System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.DataGridView GrillaAsistencia;
        private System.Windows.Forms.TextBox txt_Buscar;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button btn_refresh;
    }
}