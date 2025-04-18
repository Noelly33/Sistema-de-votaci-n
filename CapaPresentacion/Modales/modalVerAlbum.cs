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

namespace CapaPresentacion.Modales
{
    public partial class modalVerAlbum : Form
    {
        private List<Foto> fotos;
        private int currentIndex;
        private Usuario oUsuario;

        public modalVerAlbum(List<Foto> albumFotos, Usuario usuarioLogueado)
        {
            InitializeComponent();
            fotos = albumFotos;
            currentIndex = 0;
            oUsuario = usuarioLogueado;
            MostrarFoto();
        }
        private void MostrarFoto()
        {
            if (fotos.Count > 0)
            {
                pictureBox1.Image = ByteArrayToImage(fotos[currentIndex].Imagen);
                // lblFotoDescripcion.Text = fotos[currentIndex].Descripcion;
            }
            else
            {
                MessageBox.Show("No hay fotos en el álbum.");
                this.Close();
            }
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new System.IO.MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
        private void VtnVerAlbum_Load(object sender, EventArgs e)
        {
            MostrarFoto();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextComentario.Text))
            {
                MessageBox.Show("Debe ingresar un comentario.");
                return;
            }

            int idFoto = fotos[currentIndex].Id_Foto;
            string contenidoComentario = richTextComentario.Text;

            Negocio negocio = new Negocio();
            string mensaje;
            bool exito = negocio.AgregarComentarioAFoto(idFoto, oUsuario.ID, contenidoComentario, out mensaje);

            MessageBox.Show(mensaje);

            if (exito)
            {
                richTextComentario.Clear();
            }
        }
            private void btnSiguiente_Click(object sender, EventArgs e)
            {
                if (fotos.Count > 0)
                {
                    currentIndex = (currentIndex + 1) % fotos.Count;
                    MostrarFoto();
                }
            }
        }
    }

