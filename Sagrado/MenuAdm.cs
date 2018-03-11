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
    public partial class MenuAdm : Form
    {
        public MenuAdm()
        {
            InitializeComponent();
            this.CenterToScreen();
            pnComanda.BringToFront();
            btnComanda.Select();
            pnControle.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            pnComanda.Visible = true;
            pnControle.Visible = false;
              }

        private void btnControle_Click(object sender, EventArgs e)
        {
            pnComanda.Visible = false;
            pnControle.Visible = true;
        }

        private void MenuAdm_Load(object sender, EventArgs e)
        {

        }
    }
}
