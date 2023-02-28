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
    public partial class ReporteAsis : Form
    {
        public ReporteAsis()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ReporteAsis_Load(object sender, EventArgs e)
        {
            Cargar_Todas_asistencias();
        }
        private void Cargar_Todas_asistencias()
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();

            dt = obj.RN_Ver_Asistencias();
            if (dt.Rows.Count > 0)
            {
                //llamamos al metodo llenar listview
                GrillaAsistencia.DataSource = dt;
            }
        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }
        private void Cargar_Todas_asistencias_Informe(string xvalor)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();

            dt = obj.RN_Ver_Todas_Asistencia_Informe(xvalor);
            if (dt.Rows.Count > 0)
            {
                //llamamos al metodo llenar listview
                //LlenarListview_Asis(dt);
                GrillaAsistencia.DataSource = dt;
            }
        }
        private void Cargar_Todas_asistencias_xRut(string xvalor)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();

            dt = obj.RN_Ver_Todas_Asistencia_xRut(xvalor);
            if (dt.Rows.Count > 0)
            {
                //llamamos al metodo llenar listview
                //LlenarListview_Asis(dt);
                GrillaAsistencia.DataSource = dt;
            }
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscar.Text.Trim().Length > 2)
            {
                Cargar_Todas_asistencias_Informe(txt_Buscar.Text.Trim());
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

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            exportaraexcel(GrillaAsistencia);
            MessageBox.Show("Datos Correctamente Exportados a excel");
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_Buscar.Text = "";
            Cargar_Todas_asistencias();

        }

    }
}
