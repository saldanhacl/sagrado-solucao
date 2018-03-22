using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sagrado
{
    public partial class pnGerenUser : UserControl
    {
        public pnGerenUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GerenciamentoDeUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnPratos_Click(object sender, EventArgs e)
        {
            new CadastroFunc().Show();
        }
    }
}
