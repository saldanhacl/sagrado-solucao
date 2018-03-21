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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }



        private string logar()
        {
            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();
            String query = "SELECT * FROM USUARIO WHERE CPF_USER =" + textBox1.Text;
            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
            MySqlDataReader reader = cmd.ExecuteReader();

            string senhaConsultada = null;
            string nivel = null ;

            if (reader.Read())
            {
                senhaConsultada = reader["SENHA_USER"].ToString();
                nivel = reader["NIVEL_USER"].ToString();
            }

            if(senhaConsultada == textBox2.Text)
            {
                //MessageBox.Show(senhaConsultada);
                bd.closeConnection();
                return nivel;        
            }
            else {
                bd.closeConnection();
                return "S";
            }
            



        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length < 1 || textBox2.Text.Length < 1 || (button1.BackColor == Color.White && button2.BackColor == Color.White))
            {
                MessageBox.Show("Preencha os campos.");
            }else if( textBox1.Text.Length > 11)
            {
                MessageBox.Show("Digite apenas os 11 dígitos do CPF.");
            }
            else if(textBox2.Text.Length > 8)
            {
                MessageBox.Show("Senha com máximo de 8 dígitos.");

            }
            else
            {

                string getLogar = logar();

                if (getLogar != "S")
                {
                    if(getLogar == "A")
                    {
                        new MenuAdm().Show();
                        this.Hide();
                    }
                    else
                    {
                        new Comanda().Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Senha ou usuário incorreto.");
                }

                
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.LightBlue;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button1.BackColor = Color.LightBlue;
            
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
