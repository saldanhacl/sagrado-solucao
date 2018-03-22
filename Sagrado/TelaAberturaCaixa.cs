using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaAberturaCaixa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float valor;

        private void botaoOK(object sender, EventArgs e)
        {
            if(textBox1.TextLength > 0){
            valor = float.Parse(textBox1.Text);
            if (valor == 0 || valor < 0 )
            {
                MessageBox.Show("Valor Inválido! Digite novamente.");
                return;
            }
            MessageBox.Show("Caixa aberto com "+ "R$: "+ valor);
            Application.Exit();
            }
            MessageBox.Show("Caixa de texto vazia. Por favor digite um valor!");
            return;
     }
   
        private void botaoCancelar(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que quer cancelar?", "Sair", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
