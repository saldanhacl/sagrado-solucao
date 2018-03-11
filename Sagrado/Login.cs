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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            
            new MenuAdm().Show();
            this.Hide();

        }
    }
}
