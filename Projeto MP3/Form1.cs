using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Mp3
{
    public partial class Frm_Acesso : Form
    {
        public Frm_Acesso()
        {
            InitializeComponent();
        }

        private void Btn_X_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do aplicativo", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Frm_Acesso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                if (MessageBox.Show("Deseja sair do aplicativo", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
           
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.Show();
            Hide();
        }

        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            Frm_Cadastro cadastro = new Frm_Cadastro();
            cadastro.Show();
            Hide();
        }
    }
}
