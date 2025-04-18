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

namespace CapaPresentacion
{
    public partial class vtnLogin : Form
    {
        private int intentos = 0;
        public vtnLogin()
        {
            InitializeComponent();

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Por favor llene todos los campos para iniciar sesión.", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                List<Usuario> listaUsuarios = new Negocio().ListarUsuarios();
                Usuario usuario = listaUsuarios.FirstOrDefault(u => u.Codigo == txtCodigo.Text && u.Clave == txtClave.Text);
                if (usuario != null)
                {
                    if (usuario.Estado)
                    {
                        MessageBox.Show("Bienvenido al sistema " + usuario.Nombres_Completo + ".", "Inicio de sesión exitoso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vtnMenu menu = new vtnMenu(usuario);
                        menu.Show();
                        this.Hide();
                        menu.FormClosing += cerrar;
                    }
                    else
                    {
                        MessageBox.Show("El usuario no está habilitado. Por favor, contacte al administrador.", "Usuario no habilitado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    intentos++;
                    if (intentos >= 4)
                    {
                        MessageBox.Show("Se ha alcanzado el límite de intentos de inicio de sesión. Por favor, intente de nuevo más tarde.", "Maximo intentos fallidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Las credenciales ingresadas son incorrectas.", "Inicio de sesión fallido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cerrar(object sender, FormClosingEventArgs e)
        {
            txtCodigo.Clear();
            txtClave.Clear();
            this.Show();
        }

        private void btnVerContrasenia_Click(object sender, EventArgs e)
        {
            if (txtClave.PasswordChar != '\0')
            {
                txtClave.UseSystemPasswordChar = false;
                txtClave.PasswordChar = '\0';
            }
            else
            {
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void vtnLogin_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            txtCodigo.Select();
        }

        private void lblHagaClicAqui_Click(object sender, EventArgs e)
        {
            vtnRecuperarClave recuperacion = new vtnRecuperarClave();
            this.Hide();
            recuperacion.ShowDialog();
            this.Show();
        }
    }
}

