using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sagrado
{
    public partial class AlterarFunc : Form
    {

        private String cpfAnterior = "";
         public AlterarFunc()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        
    
        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            this.cpfAnterior = TXT_CPF.Text;

            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();


            String query = "SELECT * FROM USUARIO WHERE CPF_USER ='" + TXT_CPF.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                TXT_NOME.Text = reader["NOME_USER"].ToString();
                TXT_TEL.Text = reader["TEL_USER"].ToString();
                TXT_CEL.Text = reader["CEL_USER"].ToString();
                TXT_EMAIL.Text = reader["EMAIL_USER"].ToString();
                TXT_RG.Text = reader["RG_USER"].ToString();
                TXT_SENHA.Text = reader["SENHA_USER"].ToString();

                String nivel = reader["NIVEL_USER"].ToString();
                String sexo = reader["SEXO_USER"].ToString();

                if (nivel == "A") RD_ADMIN.Checked = true;
                else if (nivel == "B") RD_FUNC.Checked = true;

                if (sexo == "f") RD_FEM.Checked = true;
                else if (sexo == "m") RD_MASC.Checked = true;
            }

            bd.closeConnection();

        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CONFIRMAR_Click(object sender, EventArgs e)
        {

            DataBaseConnection bd = new DataBaseConnection();

            String nome = TXT_NOME.Text;
            String cpf = TXT_CPF.Text;
            String tel = TXT_TEL.Text;
            String cel = TXT_CEL.Text;
            String email = TXT_EMAIL.Text;
            String rg = TXT_RG.Text;

            String nivel = null;
            String sexo = null;

            if (RD_ADMIN.Checked == true) nivel = "A";
            else if (RD_FUNC.Checked == true) nivel = "B";

            if (RD_FEM.Checked == true) nivel = "f";
            else if (RD_MASC.Checked == true) nivel = "m";

            String query = "UPDATE USUARIO SET " +
                "NOME_USER = '" + nome +
                "', CPF_USER = '" + cpf +
                "', TEL_USER = '" + tel +
                "', CEL_USER = '" + cel +
                "', EMAIL_USER = '" + email +
                "', NIVEL_USER = '" + nivel +
                "', SEXO_USER = '" + sexo +
                "', RG_USER = '" + rg +
                "' WHERE CPF_USER = " + cpfAnterior;

            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
            cmd.ExecuteNonQuery();
            bd.openConnection();

        }
    }
}
