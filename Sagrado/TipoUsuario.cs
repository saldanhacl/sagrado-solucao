using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sagrado
{
    public partial class TipoUsuario : Form
    {
        public TipoUsuario()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdm_Click(object sender, EventArgs e)
        {

            int tipoUsuario = 1;
            new Login().Show();
            this.Hide();


        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            int tipoUsuario = 2;
            new Login().Show();
            this.Hide();

        }
    }
}
