using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //Usando A Biblioteca Do MySQL No C#
using System.Windows.Forms; //Usando a Biclioteca Do Windows Forms

namespace Projeto_Mp3
{
    public class Banco //A Classe Banco É Pública
    {
        //Criando a string de conexão com localização do banco de dados

        string bd = "SERVER=localhost;USER=root;DATABASE=bd_cadastro";

        //Criando conexeção com o MySQL (Banco De Dados)

        public MySqlConnection conexao;

        //Criando o Metodo conectar

        public void Conectar()
        {
            //Usando a Estrutura de Tratamento De Erros

            try //Se o banco de dados FOR localizado
            {
                conexao = new MySqlConnection(bd); //Instanciando o objeto com o meu banco de dados
                conexao.Open(); // Abrindo o Banco de dados

            }
            catch //se o banco d4e dados NÃO for localizado
            {
                MessageBox.Show("Erro ao Tentar Fazer a conexão com o Banco De Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mensagem de Erro
            }
        }

        //Criando o Metodo desconectar

        public void Desconectar()
        {

        }
    }
}