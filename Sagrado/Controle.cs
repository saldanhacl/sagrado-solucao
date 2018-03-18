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
    public partial class Controle : UserControl
    {
        public Controle()
        {
            InitializeComponent();
        }

        private void Controle_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new CadastroFunc().Show();
            
        }

        private void btnGerencia_Click(object sender, EventArgs e)
        {
            new GerenciaFunc().Show();
        }
    }
}
