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
    public partial class Frm_Login : Form
    {
        public void Login() //criando metodo login
        {
            Banco banco = new Banco(); //instanciando o objeto banco da classe Banco
            banco.Conectar(); //usando o objeto banco para chamar o metodo conectar da clsse Banco
            string sql = "SELECT * FROM tb_usuarios WHERE nome_usuario=@nome_usuario AND senha=@senha"; //consutando o nome e a senha no Banco de Dados

            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao); //Instanciando o objeto cmd que permite q execyção sql e conectar do Banco de Dados
            cmd.Parameters.AddWithValue("@nome_usuario", Variaveis.nome); //A Variavel está Recebendo o Nome Digitado
            cmd.Parameters.AddWithValue("@senha", Variaveis.senha); //A variavel recebe a senha digitada

            MySqlDataReader reader = cmd.ExecuteReader(); //executa a leitura fazendo a busca dos dados

            if (reader.Read()) //Faz a leitura de cada registro trazendo o resultado da consulta
            {
                MessageBox.Show("Login efetuado Com Sucesso!!!", "Bem Vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm_Musicas musicas = new Frm_Musicas();
                musicas.Show();
                Hide();
            }
            else //caso Contrario o usoario não for encontrado
            {
            
                MessageBox.Show("Usuário Não encontrado!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Nome Ou Senha Incorreta!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Senha.Clear();
                Txt_Nome.Clear();
                Txt_Nome.Enabled = true;
                Txt_Senha.Enabled = false;
                Btn_entrar.Visible = false;
                Chk_Senha.Enabled = false;
                Txt_Nome.Focus();

            }
            banco.Desconectar();
            
        }
        
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_X_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar para o inicio", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Frm_Acesso acesso = new Frm_Acesso();
                acesso.Show();
                Hide();
            }
        }

        private void Frm_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                if (MessageBox.Show("Deseja voltar para o inicio", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Frm_Acesso acesso = new Frm_Acesso();
                    acesso.Show();
                    Hide();
                }

            }
            
        }

        private void Link_Cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Cadastro cadastro = new Frm_Cadastro();
            cadastro.Show();
            Hide();
        }

        private void Link_Esqueçeu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Senha senha = new Frm_Senha();
            senha.Show();
            Hide();
        }

        private void Frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
                    Txt_Senha.Enabled = true;
                    Txt_Senha.Focus();
                    Chk_Senha.Enabled = true;
                    Txt_Nome.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Digite o Nome De No Mínimo 3 Caracteres!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Chk_Senha_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Senha.Checked == true)
            {
                Txt_Senha.PasswordChar = '\0';
            }
            else
            {
                Txt_Senha.PasswordChar = '•';
            }
            Txt_Senha.Focus();

        }

        private void Btn_entrar_Click(object sender, EventArgs e)
        {
            Variaveis.nome = Txt_Nome.Text; //a variavel da classe está recebendo o nome digitado
            Variaveis.senha = Txt_Senha.Text; // a variavel da classe recebe a senha digitada

            Login(); //usando o metodo para buscar quem foi cadastrado

        }

        private void Txt_Senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                Txt_Senha.Clear();
                Txt_Senha.Focus();
            }
            if (e.KeyChar == 13)
            {

                if (Txt_Senha.TextLength >= 8) //Verificando se foi digitado algo limitando caracteres
                {
                    Variaveis.senha = Txt_Senha.Text;
                    Btn_entrar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Digite Sua Senha Com 8 Caracteres", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
