using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sagrado
{
    public partial class CadastroFunc : Form
    {
        public CadastroFunc()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void CadastroFunc_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();
            try
            {
                bd.openConnection();

                String nome = textBox1.Text;
                //formatar dtnascimento para DateTime;
                String dtnascimento = "now()";
                String rg = textBox3.Text;
                String cpf = textBox2.Text;
                String tel = textBox6.Text;
                String cel = textBox5.Text;
                String email = textBox4.Text + comboBox1.Text;
                String senha = textBox7.Text;
                String confirmasenha = textBox8.Text;

                if (senha == confirmasenha)
                {
                    String query = "INSERT INTO USUARIO " +
                    "(CPF_USER, NOME_USER, TEL_USER, CEL_USER, EMAIL_USER, DTNASCIMENTO_USER, SEXO_USER, RG_USER, SENHA_USER)" +
                    "VALUES ('" + cpf + "','" + nome + "','" + tel + "','" + cel + "','" +
                    email + "'," + dtnascimento + ",'" + "m" + "','" + rg + "','" + senha + "')";

                    MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Funcionario cadastrado com sucesso!!");

                    new MenuAdm().Show();
                    this.Hide();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("A senha e confirma senha, não estão iguais. Digite novamente");
                    textBox7.Text = "";
                    textBox8.Text = "";
                }

            }
            catch(MySqlException error)
            {
                System.Windows.Forms.MessageBox.Show("Error de conexão com o banco de dados.");
            }
           

            
            bd.closeConnection();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
