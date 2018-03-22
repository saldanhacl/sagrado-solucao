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
    public partial class FundoCaixa : Form
    {
        public FundoCaixa()
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
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
        }

        private void btnAdm_Click_1(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                float valor = float.Parse(textBox1.Text);
                if (valor <= 0)
                {
                    MessageBox.Show("Valor Inválido! Digite novamente.");
                }
                else
                {
                    MessageBox.Show("Caixa aberto com " + "R$: " + valor);
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Caixa de texto vazia. Por favor digite um valor!");
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer cancelar?", "Sair", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
