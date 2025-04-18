using Clases;
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

namespace CapaPresentacion
{
    public partial class vtnRecuperarClave : Form
    {
        public vtnRecuperarClave()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string correoElectronico = txtCorreoElectronico.Text;
            Usuario usuario = new Negocio().recuperarClaveSQL(correoElectronico);
            if (string.IsNullOrWhiteSpace(txtCorreoElectronico.Text))
            {
                MessageBox.Show("Por favor llene el campo. ", "Recuperación de clave.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (usuario != null)
            {
                MessageBox.Show("La contraseña del usuario es: " + usuario.Clave, "Recupearación de clave", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se encontró un usuario con el correo electrónico proporcionado.", "Recuperación de clave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vtnRecuperarClave_Load(object sender, EventArgs e)
        {
            txtCorreoElectronico.Select();
        }
    }
}
