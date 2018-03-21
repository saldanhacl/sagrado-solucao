using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sagrado
{
    class DataBaseConnection
    {
        //Para pega a string de conexao e so ir em Gerenciador de Servidores, selecionar no banco
        // >> ai tem uma aba do lado direito mostrando as propriedades, apenas copiem a cadeia de conexao.
        // essa e a minha string de conexao: server=localhost;user id=root;database=bdsagrado;persistsecurityinfo=True;allowuservariables=True
        MySqlConnection stringdeconexao = new MySqlConnection("server=localhost;user id=root;database=bdsagrado;password=sa2gr0ad1o8;persistsecurityinfo=True;allowuservariables=True;SslMode=none");
        
        public void openConnection()
        {
            stringdeconexao.Open();
            
        }

        public void closeConnection()
        {
            stringdeconexao.Clone();
        }

        public MySqlConnection retornaConexao()
        {
            return stringdeconexao;
        }

    }

}
