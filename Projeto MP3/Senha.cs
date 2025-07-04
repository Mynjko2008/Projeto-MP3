using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Usando a Biblioteca do MYSQL


namespace Projeto_Mp3
{
    public partial class Frm_Senha : Form
    {
        public void Consultar_Nome() //criando o metodo para buscar o nome no cadastro
        {
            Banco banco = new Banco(); //Instanciando o objeto banco da Classe Banco
            banco.Conectar(); //usando o objeto para chamar o metodo conectar da classe Banco
            string sql = "SELECT * FROM tb_usuarios WHERE nome_usuario=@nome_usuario"; //Consutando se o nome digitado está cadastrado na Tabela Usuarios

            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao); //Instanciando o objeto cmd que permite a execução do sql ao Banco De Dados
            cmd.Parameters.AddWithValue("@nome_usuario", Variaveis.nome); //A Variavel recebe o nome digitado para a coluna da tabela usuarios

            MySqlDataReader reader = cmd.ExecuteReader(); //executando a leitura e fazendo a busca dos dados

            if (reader.Read()) //fazendo a leitura de cada registro trazendo o resultado da consulta
            {

                Variaveis.id = reader.GetInt32(0); //armazenado o id que foi encontrado

                Txt_Nome.Enabled = false; //desativando o nome porque foi encontrado no Banco de Dados

                MessageBox.Show("Olá, " + Variaveis.nome + " Digite a sua nova senha!!!", "Nova Senha ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Txt_NovaSenha.Enabled = true;
                Txt_NovaSenha.Focus();
                Chk_Senha.Enabled = true;

            }
            else //se o Nome do Usuario Não For Encontrado no Banco De Dados
            {
                MessageBox.Show("Usúario Não Encontrado!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            banco.Desconectar();
        }

        public void Nova_Senha() //Criando o Metodo para Trocar a Senha
        {
            try
            {
                Banco banco = new Banco();
                banco.Conectar();

                string sql = "UPDATE tb_usuarios SET senha=@senha WHERE id_usuario=@id_usuario"; //Modificando a senha do usuario se o id for correspondente ao usuario cadastrado

                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao); //instanciando o objeto cmd permite que permite a execução sql e conexão ao banco de dados

                cmd.Parameters.AddWithValue("@senha", Variaveis.senha); //salvando a Nova Senha para o Banco de Dados
                cmd.Parameters.AddWithValue("@id_usuario", Variaveis.id); //Atualizando o id do usuario no Banco De dados

                cmd.ExecuteNonQuery(); //executando a atualçização da Senha

                banco.Desconectar();

                MessageBox.Show("Senha Altera Com Sucesso!!!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Frm_Login login = new Frm_Login();
                login.Show();
                Hide();

            }
            catch
            {
                MessageBox.Show("Erro Ao Alterar a Senha!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Frm_Senha()
        {
            InitializeComponent();
        }


        private void Btn_X_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.Show();
            Hide();
        }

        private void Txt_NovaSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                Txt_NovaSenha.Clear();
                Txt_NovaSenha.Focus();
            }
            if (e.KeyChar == 13)
            {
               

                if (Txt_NovaSenha.TextLength >= 8) //Verificando se foi digitado algo limitando caracteres
                {
                    Variaveis.senha = Txt_NovaSenha.Text;

                    Txt_ConfirmarSenha.Enabled = true;
                    Txt_ConfirmarSenha.Focus();
                    Txt_NovaSenha.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Digite Sua Senha Com 8 Caracteres", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void Txt_ConfirmarSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                Txt_ConfirmarSenha.Clear();
                Txt_ConfirmarSenha.Focus();
            }
            if (e.KeyChar == 13)
            {
               

                if (Txt_ConfirmarSenha.Text == Variaveis.senha)
                {
                    Txt_ConfirmarSenha.Enabled = false;
                    Txt_NovaSenha.Enabled = false;
                    Chk_Senha.Enabled = false;
                    Btn_Salvar.Visible = true;
                }
                else
                {
                    Txt_NovaSenha.Clear();
                    Txt_ConfirmarSenha.Clear();
                    Txt_NovaSenha.Enabled = true;
                    Txt_ConfirmarSenha.Enabled = false;
                    Txt_NovaSenha.Focus();
                    MessageBox.Show("As Senhas Não São Iguais!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void Chk_Senha_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Senha.Checked == true)
            {
                Txt_ConfirmarSenha.PasswordChar = '\0';
                Txt_NovaSenha.PasswordChar = '\0';
            }
            else
            {
                Txt_ConfirmarSenha.PasswordChar = '•';
                Txt_NovaSenha.PasswordChar = '•';
            }
            Txt_ConfirmarSenha.Focus();
            Txt_NovaSenha.Focus();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            Nova_Senha(); //usando o metodo para trocar a senha no banco de dados
        }


        private void Txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite Somente Letras", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 8)
            {
                Txt_Nome.Clear();
                Txt_Nome.Focus();
            }
            if (e.KeyChar == 13)
            {
                

                if (Txt_Nome.TextLength >= 3) //Verificando se foi digitado algo limitando caracteres
                {
                    Variaveis.nome = Txt_Nome.Text;
                    Consultar_Nome(); //Usando o metodo para colsultar se o usuario está cadastrado
                }
                else
                {
                    MessageBox.Show("Digite o Nome De No Mínimo 3 Caracteres!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Frm_Senha_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
