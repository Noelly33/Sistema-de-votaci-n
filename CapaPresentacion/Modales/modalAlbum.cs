using CapaNegocios;
using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class modalAlbum : Form
    {
        private int candidateId;
        private List<Foto> fotos;

        public modalAlbum(int idCandidata)
        {
            InitializeComponent();
            candidateId = idCandidata;
            fotos = new List<Foto>();
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nombreFoto = Path.GetFileName(openFileDialog.FileName);
                byte[] imagenBytes = File.ReadAllBytes(openFileDialog.FileName);
                string descripcionFoto = txtDescripcion.Text;
                if (!string.IsNullOrWhiteSpace(descripcionFoto))
                {
                    Foto foto = new Foto
                    {
                        Nombre = nombreFoto,
                        Descripcion = descripcionFoto,
                        Imagen = imagenBytes
                    };
                    fotos.Add(foto);

                    //lstFotos.Items.Add($"{nombreFoto} - {descripcionFoto}");
                    txtDescripcion.Clear();
                }
                else
                {
                    MessageBox.Show("Debe ingresar una descripción para la foto.");
                }
            }
        }

        private void btnGuardarAlbum_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTituloAlbum.Text))
            {
                MessageBox.Show("Debe ingresar un título para el álbum.");
                return;
            }

            if (fotos.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos una imagen.");
                return;
            }

            string nombreAlbum = txtTituloAlbum.Text;
            string descripcionAlbum = txtDescripcionAlbum.Text;
            int idCandidata = candidateId;

            Negocio negocio = new Negocio();

            foreach (var foto in fotos)
            {
                negocio.CrearAlbumYFotos(nombreAlbum, descripcionAlbum, idCandidata, foto.Nombre, foto.Descripcion, foto.Imagen);
            }

            MessageBox.Show("Álbum y fotos guardados exitosamente.");
            this.Close();
        }
    }
    }

