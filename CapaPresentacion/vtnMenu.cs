using CapaNegocios;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class vtnMenu : Form

    {
        private Usuario nombreUsuarioActual;
        private static Form formularioActivo = null;
        public vtnMenu(Usuario objusuario)
        {
            nombreUsuarioActual = objusuario;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void vtnMenu_Load(object sender, EventArgs e)
        {
            List<Permiso> listaVerificar = new Negocio().permisosSQL(nombreUsuarioActual.ID);

            foreach (ToolStripMenuItem iconMenu in menuPrincipal.Items)
            {
                bool encontrado = listaVerificar.Any(m => m.NombreMenu == iconMenu.Name);
                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }
            lblNombres.Text = nombreUsuarioActual.Nombres_Completo;
            timer1.Enabled = true;
        }
        private void verPanel(Form formulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                MostrarPictureBoxVoto(true);
            }
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formulario);
            formulario.Show();
            MostrarPictureBoxVoto(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();

        }
       /* private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Menú principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }*/

        private void menuVisitaCandidata_Click(object sender, EventArgs e)
        {

        }
        private void MostrarPictureBoxVoto(bool mostrar)
        {
            pictureBoxVoto.Visible = mostrar;
        }
        private void verCandidatasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            verPanel(new vtnCandidata());
        }

        private void visitaDeCandidatasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            verPanel(new VisitaCandidata(nombreUsuarioActual));
        }

        private void crearAlbúmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            verPanel(new vtnCrearAlbum());
        }

        private void missFotogeniaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            verPanel(new votacionFotogenia(nombreUsuarioActual));
        }

        private void reinaDeLaFacultadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            verPanel(new votacionReina(nombreUsuarioActual));
        }

        private void resultadoFinalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            verPanel(new vtnResultados());
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Menú principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verPanel(new Modales.modalAutores());
        }
    }
}