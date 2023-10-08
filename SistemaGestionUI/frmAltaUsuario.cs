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



namespace SistemaGestionEntities
{
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();
        }

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {
            {
                DevolverUsuarios();
            }

            void DevolverUsuarios()
            {
                List<Usuario> lista = UsuarioBusiness.DevolverUsuarios();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = lista;
            }

           
        }

        private void btnCrearU_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frmCrearUsuario = new frmCrearUsuario();
            frmCrearUsuario.FormClosed += FrmCrearUsuario_FormClosed;
            frmCrearUsuario.ShowDialog();
        }

        private void FrmCrearUsuario_FormClosed(object? sender, FormClosedEventArgs e)
        {
            UsuarioBusiness.DevolverUsuarios();
        }
    }
}