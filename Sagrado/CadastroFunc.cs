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
            bd.openConnection();

            //String nome = textBox1.V

            String query = "INSERT INTO USUARIO " +
                "(CPF_USER, NOME_USER, TEL_USER, CEL_USER, EMAIL_USER, DTINCLUSAO_USER, DTNASCIMENTO_USER, SEXO_USER, RG_USER, SENHA_USER)" +
                "VALUES ()";

            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
            cmd.ExecuteNonQuery();
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
