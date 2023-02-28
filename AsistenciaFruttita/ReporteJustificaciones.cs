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
    public partial class ReporteJustificaciones : Form
    {
        public ReporteJustificaciones()
        {
            InitializeComponent();
        }



        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            if(GrillaAsistencia.DataSource == null)
            {
                MessageBox.Show("No hay datos que exportar");
            }
            else
            {
                exportaraexcel(GrillaAsistencia);
                MessageBox.Show("Datos Correctamente Exportados a excel");

            }
           
        }
        public void exportaraexcel(DataGridView tabla)
        {



            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns)
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;
                excel.Cells.Font.Italic = true;
                excel.Cells.Font.Bold = true;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 3, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;


        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_Buscar.Text = "";
            Cargar_todas_justificaciones();
        }
        private void Cargar_todas_justificaciones()
        {
            RN_Justificacion obj = new RN_Justificacion();
            DataTable dt = new DataTable();

            dt = obj.RN_Cargar_todos_Justificacion();
            if (dt.Rows.Count > 0)
            {
                //llamamoa al metodo llenar listview
                GrillaAsistencia.DataSource=dt;
            }
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {

            if (txt_Buscar.Text.Trim().Length > 2)
            {
                Buscar_Justificacion_porValor(txt_Buscar.Text);
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
                GrillaAsistencia.DataSource = dt;
            }
     
        }

        private void ReporteJustificaciones_Load(object sender, EventArgs e)
        {
            Cargar_todas_justificaciones();
        }
    }
}
