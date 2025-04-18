using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace CapaPresentacion
{
    public partial class vtnResultados : Form
    {
        public vtnResultados()
        {
            InitializeComponent();
        }

        private void vtnResultados_Load(object sender, EventArgs e)
        {
            DataTable resultados1 = new Negocio().GanadoraFotogenia();
            if (resultados1.Rows.Count > 0)
            {
                resultadoFotogenia.Titles.Add("Ganadora Miss Fotogenia");
                foreach (DataRow row in resultados1.Rows)
                {
                    Series miss = resultadoFotogenia.Series.Add(row["NOMBRES"].ToString());
                    miss.Points.Add(Convert.ToInt32(row["NUM_VOTOS"].ToString()));
                    miss.Label = row["NUM_VOTOS"].ToString();
                    miss.Label = row["NOMBRES"].ToString();
                }
            }
            else
            {
                MessageBox.Show("No se encontró datos para generar la gráfica");
            }
            DataTable resultados2 = new Negocio().GanadoraReina();
            if (resultados2.Rows.Count > 0)
            {
                resultadoReina.Titles.Add("Ganadora Reina de la Facultad");

                foreach (DataRow row in resultados2.Rows)
                {
                    Series miss = resultadoReina.Series.Add(row["NOMBRES"].ToString());
                    miss.Points.Add(Convert.ToInt32(row["NUM_VOTOS"].ToString()));
                    miss.Label = row["NUM_VOTOS"].ToString();
                    miss.Label = row["NOMBRES"].ToString();
                }
            }
            else
            {
                MessageBox.Show("No se encontró datos para generar la gráfica");
            }
        }

    }
}
