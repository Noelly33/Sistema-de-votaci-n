using Clases;
using CapaNegocios;
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
using static System.Net.Mime.MediaTypeNames;

namespace CapaPresentacion
{
    public partial class vtnCandidata : Form
    {
        byte[] foto = null;
        public vtnCandidata()
        {
            InitializeComponent();
        }
        private void vtnCandidata_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in tablaCandidata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cmbBuscar.Items.Add(new { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cmbBuscar.DisplayMember = "Texto";
            cmbBuscar.ValueMember = "Valor";
            cmbBuscar.SelectedIndex = 0;

            List<Candidata> mostrarCandidata = new Negocio().mostrarCandidataSQL();
            foreach (Candidata candidata in mostrarCandidata)
            {
                tablaCandidata.Rows.Add(new object[] { "", candidata.Id_Candidata, candidata.Cedula, candidata.Nombres, candidata.Foto_Principal, candidata.Carrera, candidata.Semestre, candidata.Pasatiempos, candidata.Habilidades, candidata.Intereses, candidata.Aspiraciones });
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtCarrera.Text) || string.IsNullOrWhiteSpace(txtSemestre.Text) || string.IsNullOrWhiteSpace(txtPasatiempos.Text) || string.IsNullOrWhiteSpace(txtHabilidades.Text) || string.IsNullOrWhiteSpace(txtInteres.Text) || string.IsNullOrWhiteSpace(txtAspiraciones.Text) || pictureFoto.Image == null)
            {
                string mensajeError = "Por favor, complete los siguientes campos:\n";
                if (string.IsNullOrWhiteSpace(txtCedula.Text)) mensajeError += "- Número del documento del candidata.\n";
                if (string.IsNullOrWhiteSpace(txtNombres.Text)) mensajeError += "- Nombres_Completo del candidata.\n";
                if (string.IsNullOrWhiteSpace(txtCarrera.Text)) mensajeError += "- Apellidos del candidata.\n";
                if (string.IsNullOrWhiteSpace(txtSemestre.Text)) mensajeError += "- Cedula del candidata.\n";
                if (string.IsNullOrWhiteSpace(txtPasatiempos.Text)) mensajeError += "- Telefono del candidata.\n";
                if (string.IsNullOrWhiteSpace(txtInteres.Text)) mensajeError += "- Correo electrónico del candidata.\n";
                if (string.IsNullOrWhiteSpace(txtAspiraciones.Text)) mensajeError += "- Correo electrónico del candidata.\n";
                if (pictureFoto.Image == null) mensajeError += "- Foto del candidata.\n";

                MessageBox.Show(mensajeError, "Faltan campos por completar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Candidata agregarCandidata = new Candidata()
                {
                    Id_Candidata = Convert.ToInt32(txtID.Text),
                    Cedula = txtCedula.Text,
                    Nombres = txtNombres.Text,
                    Carrera = txtCarrera.Text,
                    Semestre = Convert.ToInt32(txtSemestre.Text),
                    Pasatiempos = txtPasatiempos.Text,
                    Habilidades = txtHabilidades.Text,
                    Intereses = txtInteres.Text,
                    Aspiraciones = txtAspiraciones.Text
                };
                int idCandidataIngresada = new Negocio().resgistrarCandidataSQL(agregarCandidata, foto, out mensaje);
                if (idCandidataIngresada != 0)
                {
                    tablaCandidata.Rows.Add(new object[] { "", idCandidataIngresada, txtCedula.Text, txtNombres.Text, ImageToByteArray(pictureFoto.Image), txtCarrera.Text, txtSemestre.Text, txtPasatiempos.Text, txtHabilidades.Text, txtInteres.Text, txtAspiraciones.Text });
                    MessageBox.Show("El candidata fue agregado correctamente.", "Agregar candidata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("ggfgfg.", "Agregar candidata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string mensaje;
            Candidata candidataModificado = new Candidata()
            {
                Id_Candidata = Convert.ToInt32(txtID.Text),
                Cedula = txtCedula.Text,
                Nombres = txtNombres.Text,
                Carrera = txtCarrera.Text,
                Semestre = Convert.ToInt32(txtSemestre.Text),
                Pasatiempos = txtPasatiempos.Text,
                Habilidades = txtHabilidades.Text,
                Intereses = txtInteres.Text,
                Aspiraciones = txtAspiraciones.Text

            };
            if (pictureFoto.Image != null)
            {
                foto = ImageToByteArray(pictureFoto.Image);
            }
            bool modificar = new Negocio().editarCandidataSQL(candidataModificado, foto, out mensaje);
            if (modificar)
            {
                MessageBox.Show("La candidata fue modificada correctamente.", "Modificar candidata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int indice = Convert.ToInt32(txtIndice.Text);
                tablaCandidata.Rows[indice].Cells["Cedula"].Value = candidataModificado.Cedula;
                tablaCandidata.Rows[indice].Cells["Nombres_Completo"].Value = candidataModificado.Nombres;
                tablaCandidata.Rows[indice].Cells["Imagen"].Value = foto;
                tablaCandidata.Rows[indice].Cells["Carrera"].Value = candidataModificado.Carrera;
                tablaCandidata.Rows[indice].Cells["Semestre"].Value = candidataModificado.Semestre;
                tablaCandidata.Rows[indice].Cells["Pasatiempos"].Value = candidataModificado.Pasatiempos;
                tablaCandidata.Rows[indice].Cells["Habilidades"].Value = candidataModificado.Habilidades;
                tablaCandidata.Rows[indice].Cells["Intereses"].Value = candidataModificado.Habilidades;
                tablaCandidata.Rows[indice].Cells["Aspiraciones"].Value = candidataModificado.Aspiraciones;

            }
            else
            {
                MessageBox.Show("Error al modificar la candidata: " + mensaje, "Modificar tranportista", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtCarrera.Text) || string.IsNullOrWhiteSpace(txtSemestre.Text) || string.IsNullOrWhiteSpace(txtPasatiempos.Text) || string.IsNullOrWhiteSpace(txtInteres.Text) || string.IsNullOrWhiteSpace(txtHabilidades.Text) || string.IsNullOrWhiteSpace(txtAspiraciones.Text) || pictureFoto.Image == null)
            {
                MessageBox.Show("Primero debe selecionar un candidata en la tabla para poder eliminarlo.", "Faltan campos por completar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Convert.ToInt32(txtID.Text) != 0)
                {
                    if (MessageBox.Show("Desea eliminar este candidata?", "Eliminar candidata", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;

                        Candidata transportistaEliminado = new Candidata()
                        {
                            Id_Candidata = Convert.ToInt32(txtID.Text),
                        };
                        bool respuesta = new Negocio().eliminarCandidataSQL(transportistaEliminado, out mensaje);
                        if (respuesta)
                        {
                            tablaCandidata.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                            MessageBox.Show("La candidata fue eliminada correctamente.", "Eliminar candidata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Eliminar candidata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnCarganImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.Jpg; *.png; *.Gif) |*.Jpg; *.png; *.Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureFoto.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                using (MemoryStream stream = new MemoryStream())
                {
                    pictureFoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    foto = stream.ToArray();
                }
            }
        }
        private byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public void Limpiar()
        {
            txtIndice.Text = "-1";
            txtID.Text = "0";
            txtCedula.Clear();
            txtNombres.Clear();
            pictureFoto.Image = null;
            txtCarrera.Clear();
            txtSemestre.Clear();
            txtHabilidades.Clear();
            txtPasatiempos.Clear();
            txtInteres.Clear();
            txtAspiraciones.Clear();
        }

        private void tablaCandidata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaCandidata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtID.Text = tablaCandidata.Rows[indice].Cells["ID"].Value.ToString();
                    txtCedula.Text = tablaCandidata.Rows[indice].Cells["Cedula"].Value.ToString();
                    txtNombres.Text = tablaCandidata.Rows[indice].Cells["Nombres_Completo"].Value.ToString();
                    MemoryStream stream = new MemoryStream((byte[])tablaCandidata.Rows[indice].Cells["Imagen"].Value);
                    txtCarrera.Text = tablaCandidata.Rows[indice].Cells["Carrera"].Value.ToString();
                    txtSemestre.Text = tablaCandidata.Rows[indice].Cells["Semestre"].Value.ToString();
                    txtHabilidades.Text = tablaCandidata.Rows[indice].Cells["Habilidades"].Value.ToString();
                    txtPasatiempos.Text = tablaCandidata.Rows[indice].Cells["Pasatiempos"].Value.ToString();
                    txtInteres.Text = tablaCandidata.Rows[indice].Cells["Intereses"].Value.ToString();
                    txtAspiraciones.Text = tablaCandidata.Rows[indice].Cells["Aspiraciones"].Value.ToString();
                    pictureFoto.Image = System.Drawing.Image.FromStream(stream);

                }
            }
        }

        private void tablaCandidata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
                e.Graphics.DrawImage(Properties.Resources.visto, new System.Drawing.Rectangle(r, s, p, q));
                e.Handled = true;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Debe ingresar números y no letras.", "Campo Cédula", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Debe ingresar letras y no números.", "Campo Nombres_Completo completo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Debe ingresar letras y no números.", "Campo Carrera", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtSemestre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Debe ingresar números y no letras.", "Campo Semestre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            dynamic selectedItemCmbBuscar = cmbBuscar.SelectedItem;
            string valorCmbBuscar = selectedItemCmbBuscar.Valor;
            string columnaFiltro = valorCmbBuscar.ToString();
            int filasVisibles = 0;

            foreach (DataGridViewRow row in tablaCandidata.Rows)
            {
                if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                {
                    row.Visible = true;
                    filasVisibles++;
                }
                else
                {
                    row.Visible = false;
                }
            }
            // Verificar si hay filas visibles y mostrar un mensaje si no hay
            if (filasVisibles == 0)
            {
                MessageBox.Show("No se encontró información de acuerdo a la opción seleccionada.", "Buscar candidata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBuscar.Text = "";
                foreach (DataGridViewRow row in tablaCandidata.Rows)
                {
                    row.Visible = true;
                }
            }
        }
    }
}
