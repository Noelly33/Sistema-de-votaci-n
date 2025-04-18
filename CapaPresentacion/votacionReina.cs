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

namespace CapaPresentacion
{
    public partial class votacionReina : Form
    {
        private Usuario usuario;
        public votacionReina(Usuario oUsuario = null)
        {
            usuario = oUsuario;
            InitializeComponent();
        }

        private void votacionReina_Load(object sender, EventArgs e)
        {
            tablaCandidata.Columns.Add("btnSeleccionar", "Seleccionar");
            List<Candidata> mostrarCandidata = new Negocio().mostrarCandidataSQL();
            foreach (Candidata candidata in mostrarCandidata)
            {
                tablaCandidata.Rows.Add(new object[] { "", candidata.Id_Candidata, candidata.Cedula, candidata.Nombres, candidata.Foto_Principal, candidata.Carrera, candidata.Semestre, candidata.Pasatiempos, candidata.Habilidades, candidata.Intereses, candidata.Aspiraciones });
            }
        }
        private void tablaCandidata_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaCandidata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    lblID.Text = tablaCandidata.Rows[indice].Cells["ID"].Value.ToString();
                    lblCandidata.Text = tablaCandidata.Rows[indice].Cells["Nombres_Completo"].Value.ToString();
                    MemoryStream stream = new MemoryStream((byte[])tablaCandidata.Rows[indice].Cells["Imagen"].Value);
                    lblCarrera.Text = tablaCandidata.Rows[indice].Cells["Carrera"].Value.ToString();
                    pictureBoxCandidata.Image = System.Drawing.Image.FromStream(stream);

                }
            }
        }
        private void btnVotar_Click_1(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Votacion agregarVotacion = new Votacion()
            {
                Id_Votacion = Convert.ToInt32(lblID.Text),
                oCandidata = new Candidata()
                {
                    Id_Candidata = Convert.ToInt32(lblID.Text),
                },
                oUsuario = new Usuario()
                {
                    ID = usuario.ID,
                },
                Tipo_votacion = txtTipoVotacion.Text,
            };
            int ID_Votacion = new Negocio().VotacionCandidataSQL(agregarVotacion, out mensaje);
            MessageBox.Show(mensaje);
        }

        private void tablaCandidata_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var p = Properties.Resources.visto.Width;
                var q = Properties.Resources.visto.Height;
                var r = e.CellBounds.Left + (e.CellBounds.Width - p) / 2;
                var s = e.CellBounds.Top + (e.CellBounds.Height - q) / 2;
                e.Graphics.DrawImage(Properties.Resources.visto, new Rectangle(r, s, p, q));
                e.Handled = true;
            }
        }
    }
}