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

namespace CapaPresentacion.Modales
{
    public partial class modalCandidata : Form
    {
        private Candidata candidata;

        public modalCandidata(Candidata oCandidta)
        {
            InitializeComponent();
            candidata = oCandidta;
        }

        private void modalCandidata_Load(object sender, EventArgs e)
        {
            txtNombres.Text = candidata.Nombres;
            txtCarrera.Text = candidata.Carrera;
            txtSemestre.Text = candidata.Semestre.ToString();
            txtPasatiempos.Text = candidata.Pasatiempos;
            txtInteres.Text = candidata.Intereses;
            txtAspiraciones.Text = candidata.Aspiraciones;
            txtHabilidades.Text = candidata.Habilidades;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
