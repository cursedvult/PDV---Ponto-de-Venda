using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace BD
{

    class ConexaoBD
    {

        //string para informar os dados do banco //banco de dados local
        public string conexao = "SERVER=localhost; DATABASE=pdv; UID=root; PWD=; PORT=;";
        //variável para abertura e fechamento do banco
        public MySqlConnection conn;

        //Método para abrir o servidor 
        public void dbOpen()
        {
         conn = new MySqlConnection(conexao);
         conn.Open();
        }

        //Método para fechar o servidor
        public void dbClose()
        {
            conn = new MySqlConnection(conexao);
            conn.Close();
            conn.Dispose();
            conn.ClearAllPoolsAsync();
        }

    }
}


