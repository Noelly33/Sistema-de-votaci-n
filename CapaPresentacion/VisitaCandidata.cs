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
    public partial class VisitaCandidata : Form
    {
        private Negocio negocio;
        private Usuario oUsuario;

        public VisitaCandidata(Usuario usuarioLogueado)
        {
            negocio = new Negocio();
            InitializeComponent();
            oUsuario = usuarioLogueado;
        }

        private void VisitaCandidata_Load(object sender, EventArgs e)
        {
            LoadCandidates();
        }
        private void LoadCandidates()
        {
            List<Candidata> candidates = negocio.mostrarCandidataSQL();
            flwVisitaCandidata.Controls.Clear();

            foreach (var candidate in candidates)
            {
                Panel candidatePanel = new Panel
                {
                    Width = 200,
                    Height = 200,
                    BorderStyle = BorderStyle.Fixed3D
                };

                PictureBox pictureBox = new PictureBox
                {
                    Width = 120,
                    Height = 120,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = ByteArrayToImage(candidate.Foto_Principal),
                    Tag = candidate.Id_Candidata
                };
                pictureBox.Location = new Point(
                (candidatePanel.Width - pictureBox.Width) / 2, 3);
                pictureBox.Click += pictureBox1_Click;

                Label nameLabel = new Label
                {
                    Text = candidate.Nombres,
                    Name = "lblCandidata",
                    AutoSize = true,
                    Location = new Point(0, 130) // Ajustar la posición según sea necesario
                };


                Button portafolioButton = new Button
                {
                    Text = "Portafolio",
                    Name = "btnPortafolio",
                    Tag = candidate.Id_Candidata,
                    Location = new Point(0, 160) // Ajustar la posición según sea necesario
                };
                portafolioButton.Click += btnPortafolio_Click;


                Button albumButton = new Button
                {
                    Text = "Album",
                    Name = "btnAlbum",
                    Tag = candidate.Id_Candidata,
                    Location = new Point(120, 160) // Ajustar la posición según sea necesario
                };
                albumButton.Click += btnAlbum_Click;
                candidatePanel.Controls.Add(pictureBox);
                candidatePanel.Controls.Add(nameLabel);
                candidatePanel.Controls.Add(portafolioButton);
                candidatePanel.Controls.Add(albumButton);

                flwVisitaCandidata.Controls.Add(candidatePanel);
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new System.IO.MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int candidateId = (int)pictureBox.Tag;
            MessageBox.Show($"Candidata seleccionada: {candidateId}");
        }

        private void btnPortafolio_Click(object sender, EventArgs e)
        {
            Button portafolioButton = (Button)sender;
            int candidateId = (int)portafolioButton.Tag;

            // Obtener la información completa de la candidata usando el ID
            Candidata candidata = negocio.mostrarCandidataSQL()
                                         .FirstOrDefault(c => c.Id_Candidata == candidateId);

            if (candidata != null)
            {
                using (var modal = new modalCandidata(candidata))
                {
                    modal.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No se encontró la candidata.");
            }
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            Button albumButton = (Button)sender;
            int candidateId = (int)albumButton.Tag;

            // Obtener los álbumes y fotos de la candidata
            List<Album> albumes = negocio.ObtenerAlbumesYFotosPorCandidata(candidateId);

            if (albumes.Count > 0)
            {
                // Por simplicidad, asumimos que hay solo un álbum por candidata
                Album album = albumes.First();
                List<Foto> fotos = album.Fotos;
                 
                using (var modal = new Modales.modalVerAlbum(fotos, oUsuario)) // Pasa el usuario logueado
        {
            modal.ShowDialog();
        }
            }
            else
            {
                MessageBox.Show("No se encontraron álbumes para la candidata.");
            }

        }
    }
}