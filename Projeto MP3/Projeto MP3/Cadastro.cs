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
    public partial class Frm_Cadastro : Form
    {
        
        public void Cadastrar() //Criando O Metodo cadastrar
        {
            try
            {
                Banco banco = new Banco(); //Instanciando o objeto banco da classe Banco
                banco.Conectar(); //usando o objeto banco para chamar o metodo conectar da classe banco

                string sql = "INSERT INTO tb_usuarios(id_usuario,nome_usuario,senha) VALUES (DEFAULT,@nome_usuario,@senha)"; //salvando os dados na tabela 

                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao); //Instanciando o objeto cmd que permite a execução sql e conexão do Banco De Dados

                cmd.Parameters.AddWithValue("@nome_usuario", Variaveis.nome); //a variavel recebe o nome digitado para a coluna nome da tabela usuarios
                cmd.Parameters.AddWithValue("@senha", Variaveis.senha); //a variavel recebe a senha digitada para a coluna senha da tabela usuarios

                cmd.ExecuteNonQuery(); //Executando os comandos do MySql

                banco.Desconectar(); //Fechando o Banco de Dados

                MessageBox.Show("Cadastro Feito Com Secesso!!!", "Parabens", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Frm_Login login = new Frm_Login();
                login.Show();
                Hide();
            }
            catch
            {
                MessageBox.Show("Erro ao Cadastrar!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Nome.Clear();
                Txt_Nome.Enabled = true;
                Txt_Nome.Focus();
                Txt_Senha.Clear();
                Txt_Senha.Enabled = false;
                Chk_Senha.Enabled = false;
            }
        }

        public Frm_Cadastro()
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

        private void Frm_Cadastro_KeyPress(object sender, KeyPressEventArgs e)
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
            Frm_Login login = new Frm_Login();
            login.Show();
            Hide();
        }

        private void Frm_Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação das teclas 
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
                    Variaveis.nome = Txt_Nome.Text; //a variavel da classe está recebendo o nome digitado

                    Txt_Senha.Enabled = true;
                    Chk_Senha.Enabled = true;
                    Txt_Nome.Enabled = false;
                    Txt_Senha.Focus();
                }
                else
                {
                    MessageBox.Show("Digite o Nome De No Mínimo 3 Caracteres!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
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
                    Variaveis.senha = Txt_Senha.Text; // a variavel da calsse recebe a senha digitada
                    Btn_enviar.Visible = true;
                    
                }
                else
                {
                    MessageBox.Show("Digite Sua Senha Com 8 Caracteres", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
        }

        private void Btn_enviar_Click(object sender, EventArgs e)
        {
            if ((Txt_Nome.TextLength >= 3) && (Txt_Senha.TextLength >= 8))
            {
                Variaveis.nome = Txt_Nome.Text; //a variavel da classe está recebendo o nome digitado
                Variaveis.senha = Txt_Senha.Text; // a variavel da classe recebe a senha digitada

                Cadastrar(); //Usando O Metodo Cadastrar

             
            }
            else
            {
                MessageBox.Show("Verifique Todas As Informações!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
