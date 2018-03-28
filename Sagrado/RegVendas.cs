using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sagrado
{
    public partial class RegVendas : Form
    {
        public RegVendas()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RegVendas_Load(object sender, EventArgs e)
        {

        }

     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void boxPrice_TextChanged(object sender, EventArgs e)
        {
             

        }

        private void boxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(ch == 46 && boxPrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

             
        private void BTN_CONFIRMAR_Click(object sender, EventArgs e)
        {

            DataBaseConnection bd = new DataBaseConnection();

            try
            {
                bd.openConnection();

                String preco = boxPrice.Text;
                String operacao = null;

                if (radioButton1.Checked) operacao = "v";
                else if (radioButton2.Checked) operacao = "f";
                else if (radioButton3.Checked) operacao = "e";

                float precoFloat = float.Parse(preco);

                if (boxPrice.Text.Length != 0)
                {
                    String query = "INSERT INTO CAIXA " +
                    "(TYPE_ENTRADA_CAIXA, DATE_MODIFY_CAIXA, VALOR_ENTRADA_CAIXA)" +
                    " VALUES ('" + operacao + "', now()," + precoFloat + ")";

                    MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Registro realizado com sucesso!!");

                    new RegVendas().Show();
                    this.Close();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Digite um preço válido");
                    boxPrice.Text = "";
                }

            }
            catch (MySqlException)
            {
                System.Windows.Forms.MessageBox.Show("Error de conexão com o banco de dados.");
            }

            bd.closeConnection();
            
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
