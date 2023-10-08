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
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmProducto();
            formulario.Show();
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAltaUsuario();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new frmVentas();
            formulario.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
