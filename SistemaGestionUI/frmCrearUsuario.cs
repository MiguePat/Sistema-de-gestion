using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionBusiness;
using SistemaGestionData;

namespace SistemaGestionEntities
{
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {

        }



        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();


            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Contraseña = int.Parse(txtContraseña.Text);
            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.Mail = txtMail.Text;
            UsuarioBusiness.CrearUsuario(usuario);
            MessageBox.Show("Se grabo Correctamente");

        }
    }
}
