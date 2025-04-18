using CapaNegocios;
using CapaPresentacion.Modales;
using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class vtnCrearAlbum : Form
    {
        private Candidata idCandidata;
        public vtnCrearAlbum()
        {
            InitializeComponent();
            tablaCandidata.CellContentClick += tablaCandidata_CellContentClick;
        }
        private void vtnAlbum_Load(object sender, EventArgs e)
        {          
            List<Candidata> mostrarCandidata = new Negocio().mostrarCandidataSQL();
            foreach (Candidata candidata in mostrarCandidata)
            {
                tablaCandidata.Rows.Add(new object[] { "Crear Album", candidata.Id_Candidata, candidata.Cedula, candidata.Nombres, candidata.Carrera, candidata.Semestre, candidata.Pasatiempos, candidata.Habilidades, candidata.Intereses, candidata.Aspiraciones });

            }

        }

        private void tablaCandidata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             // Verificar si se hizo clic en el botón "Crear Album"
            if (tablaCandidata.Columns[e.ColumnIndex].Name == "btnSeleccionar" && e.RowIndex >= 0)
            {
                // Obtener el ID de la candidata seleccionada
                int candidateId = Convert.ToInt32(tablaCandidata.Rows[e.RowIndex].Cells["ID"].Value);

                // Crear y mostrar la ventana modal
                Modales.modalAlbum modal = new Modales.modalAlbum(candidateId);
                modal.ShowDialog();
            }
        }
    }
}