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
    public partial class AsistenciaDelMes : Form
    {
        public AsistenciaDelMes()
        {
            InitializeComponent();
        }
        public DateTime FechaConsult;

        public string CualImprimir;

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarTexbox();
            CargarDias();
        }
        private void CargarTexbox()
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();


            dt = obj.RN_asistencia_Mensual(txt_Rut.Text.Trim(), fechaDesde.Value, fechaHasta.Value);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("No Hay Datos", "advertencia de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                GrillaDetalle.DataSource = dt;

            }
        }
        private void CargarDias()
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();


            dt = obj.RN_Contar_asistencia(txt_Rut.Text.Trim(), fechaDesde.Value, fechaHasta.Value);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("No Hay Datos", "advertencia de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                TxtDias.Text = Convert.ToString(dt.Rows[0]["DiasTrabajados"]);

            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            float totalMinExtra = 0;
            float totalhorasExtra = 0;
            foreach (DataGridViewRow row in GrillaDetalle.Rows)
            {

                totalMinExtra += Convert.ToInt32(row.Cells["Minutos"].Value);
                totalhorasExtra += Convert.ToInt32(row.Cells["HorasExtras"].Value);
            }

            TxtMinutos.Text = Convert.ToString(totalMinExtra);
            TxtHoraExtra.Text = Convert.ToString(totalhorasExtra + totalMinExtra/60);
        }

        private void elButton1_Click(object sender, EventArgs e)
        {
            GrillaDetalle.DataSource = null;
            txt_Rut.Text = "";
            TxtDias.Text = "";
            TxtMinutos.Text = "";
            TxtHoraExtra.Text = "";
        }
        public void exportaraexcel(DataGridView tabla)
        {
            if (GrillaDetalle.DataSource == null)
            {
                MessageBox.Show("Tabla de datos Vacia", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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

        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            exportaraexcel(GrillaDetalle);
        }
    }
}
