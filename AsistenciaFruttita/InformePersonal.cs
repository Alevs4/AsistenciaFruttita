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
    public partial class InformePersonal : Form
    {
        public InformePersonal()
        {
            InitializeComponent();
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

            private void BtnAceptar_Click(object sender, EventArgs e)
        {
            exportaraexcel(GrillaPersonal);
            MessageBox.Show("Datos Correctamente Exportados a excel");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Cargar_Personal()
        {
            RN_Personal obj = new RN_Personal();
            DataTable dt = new DataTable();

            dt = obj.RN_Informe_todaPersona();
            if (dt.Rows.Count > 0)
            {
                //llamamoa al metodo llenar listview
                GrillaPersonal.DataSource=dt;
            }
        }

        private void InformePersonal_Load(object sender, EventArgs e)
        {
            Cargar_Personal();
        }
    }
}
