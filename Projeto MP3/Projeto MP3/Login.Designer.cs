
namespace Projeto_Mp3
{
    partial class Frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Lbl_Login = new System.Windows.Forms.Label();
            this.Txt_Nome = new Guna.UI2.WinForms.Guna2TextBox();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Txt_Senha = new Guna.UI2.WinForms.Guna2TextBox();
            this.Link_Esqueceu = new System.Windows.Forms.LinkLabel();
            this.Link_Cadastro = new System.Windows.Forms.LinkLabel();
            this.Btn_X = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_entrar = new Guna.UI2.WinForms.Guna2Button();
            this.Chk_Senha = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // Lbl_Login
            // 
            this.Lbl_Login.AutoSize = true;
            this.Lbl_Login.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Login.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Login.ForeColor = System.Drawing.Color.White;
            this.Lbl_Login.Location = new System.Drawing.Point(562, 73);
            this.Lbl_Login.Name = "Lbl_Login";
            this.Lbl_Login.Size = new System.Drawing.Size(75, 25);
            this.Lbl_Login.TabIndex = 0;
            this.Lbl_Login.Text = "Login";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Animated = true;
            this.Txt_Nome.AutoRoundedCorners = true;
            this.Txt_Nome.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Nome.BorderColor = System.Drawing.Color.Black;
            this.Txt_Nome.BorderRadius = 17;
            this.Txt_Nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Nome.DefaultText = "";
            this.Txt_Nome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Nome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Nome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Nome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Nome.FillColor = System.Drawing.Color.DimGray;
            this.Txt_Nome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Nome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_Nome.ForeColor = System.Drawing.Color.Black;
            this.Txt_Nome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Nome.Location = new System.Drawing.Point(284, 195);
            this.Txt_Nome.MaxLength = 30;
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.PasswordChar = '\0';
            this.Txt_Nome.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Txt_Nome.PlaceholderText = "";
            this.Txt_Nome.SelectedText = "";
            this.Txt_Nome.Size = new System.Drawing.Size(403, 36);
            this.Txt_Nome.TabIndex = 1;
            this.Txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nome_KeyPress);
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Nome.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.ForeColor = System.Drawing.Color.White;
            this.Lbl_Nome.Location = new System.Drawing.Point(280, 162);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(148, 21);
            this.Lbl_Nome.TabIndex = 2;
            this.Lbl_Nome.Text = "Nome do Perfil ";
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Senha.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Senha.ForeColor = System.Drawing.Color.White;
            this.Lbl_Senha.Location = new System.Drawing.Point(281, 275);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(63, 21);
            this.Lbl_Senha.TabIndex = 3;
            this.Lbl_Senha.Text = "Senha";
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Animated = true;
            this.Txt_Senha.AutoRoundedCorners = true;
            this.Txt_Senha.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Senha.BorderColor = System.Drawing.Color.Black;
            this.Txt_Senha.BorderRadius = 17;
            this.Txt_Senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Senha.DefaultText = "";
            this.Txt_Senha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Senha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Senha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Senha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Senha.Enabled = false;
            this.Txt_Senha.FillColor = System.Drawing.Color.DimGray;
            this.Txt_Senha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Senha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_Senha.ForeColor = System.Drawing.Color.Black;
            this.Txt_Senha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Senha.Location = new System.Drawing.Point(284, 307);
            this.Txt_Senha.MaxLength = 8;
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '•';
            this.Txt_Senha.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Txt_Senha.PlaceholderText = "";
            this.Txt_Senha.SelectedText = "";
            this.Txt_Senha.Size = new System.Drawing.Size(200, 36);
            this.Txt_Senha.TabIndex = 4;
            this.Txt_Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Senha_KeyPress);
            // 
            // Link_Esqueceu
            // 
            this.Link_Esqueceu.AutoSize = true;
            this.Link_Esqueceu.BackColor = System.Drawing.Color.Transparent;
            this.Link_Esqueceu.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_Esqueceu.LinkColor = System.Drawing.Color.RoyalBlue;
            this.Link_Esqueceu.Location = new System.Drawing.Point(294, 373);
            this.Link_Esqueceu.Name = "Link_Esqueceu";
            this.Link_Esqueceu.Size = new System.Drawing.Size(175, 21);
            this.Link_Esqueceu.TabIndex = 6;
            this.Link_Esqueceu.TabStop = true;
            this.Link_Esqueceu.Text = "Esqueçeu a Senha?";
            this.Link_Esqueceu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Esqueçeu_LinkClicked);
            // 
            // Link_Cadastro
            // 
            this.Link_Cadastro.AutoSize = true;
            this.Link_Cadastro.BackColor = System.Drawing.Color.Transparent;
            this.Link_Cadastro.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_Cadastro.LinkColor = System.Drawing.Color.RoyalBlue;
            this.Link_Cadastro.Location = new System.Drawing.Point(497, 449);
            this.Link_Cadastro.Name = "Link_Cadastro";
            this.Link_Cadastro.Size = new System.Drawing.Size(168, 21);
            this.Link_Cadastro.TabIndex = 7;
            this.Link_Cadastro.TabStop = true;
            this.Link_Cadastro.Text = "Não tem cadastro?";
            this.Link_Cadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Cadastro_LinkClicked);
            // 
            // Btn_X
            // 
            this.Btn_X.Animated = true;
            this.Btn_X.AutoRoundedCorners = true;
            this.Btn_X.BackColor = System.Drawing.Color.Transparent;
            this.Btn_X.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_X.BorderRadius = 20;
            this.Btn_X.BorderThickness = 1;
            this.Btn_X.DefaultAutoSize = true;
            this.Btn_X.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_X.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_X.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_X.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_X.FillColor = System.Drawing.Color.Red;
            this.Btn_X.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.Btn_X.ForeColor = System.Drawing.Color.White;
            this.Btn_X.IndicateFocus = true;
            this.Btn_X.Location = new System.Drawing.Point(983, 12);
            this.Btn_X.Name = "Btn_X";
            this.Btn_X.Size = new System.Drawing.Size(50, 43);
            this.Btn_X.TabIndex = 8;
            this.Btn_X.Text = "X";
            this.Btn_X.UseTransparentBackground = true;
            this.Btn_X.Click += new System.EventHandler(this.Btn_X_Click);
            // 
            // Btn_entrar
            // 
            this.Btn_entrar.AutoRoundedCorners = true;
            this.Btn_entrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_entrar.BorderRadius = 21;
            this.Btn_entrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_entrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_entrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_entrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_entrar.FillColor = System.Drawing.Color.Maroon;
            this.Btn_entrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_entrar.ForeColor = System.Drawing.Color.White;
            this.Btn_entrar.Location = new System.Drawing.Point(750, 373);
            this.Btn_entrar.Name = "Btn_entrar";
            this.Btn_entrar.Size = new System.Drawing.Size(180, 45);
            this.Btn_entrar.TabIndex = 17;
            this.Btn_entrar.Text = "Entrar";
            this.Btn_entrar.UseTransparentBackground = true;
            this.Btn_entrar.Visible = false;
            this.Btn_entrar.Click += new System.EventHandler(this.Btn_entrar_Click);
            // 
            // Chk_Senha
            // 
            this.Chk_Senha.AutoSize = true;
            this.Chk_Senha.BackColor = System.Drawing.Color.Transparent;
            this.Chk_Senha.CheckedState.BorderColor = System.Drawing.Color.DarkRed;
            this.Chk_Senha.CheckedState.BorderRadius = 0;
            this.Chk_Senha.CheckedState.BorderThickness = 0;
            this.Chk_Senha.CheckedState.FillColor = System.Drawing.Color.DarkRed;
            this.Chk_Senha.CheckMarkColor = System.Drawing.Color.DodgerBlue;
            this.Chk_Senha.Enabled = false;
            this.Chk_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Chk_Senha.ForeColor = System.Drawing.Color.White;
            this.Chk_Senha.Location = new System.Drawing.Point(536, 326);
            this.Chk_Senha.Name = "Chk_Senha";
            this.Chk_Senha.Size = new System.Drawing.Size(101, 17);
            this.Chk_Senha.TabIndex = 18;
            this.Chk_Senha.Text = "Mostrar Senha?";
            this.Chk_Senha.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.Chk_Senha.UncheckedState.BorderRadius = 0;
            this.Chk_Senha.UncheckedState.BorderThickness = 0;
            this.Chk_Senha.UncheckedState.FillColor = System.Drawing.Color.White;
            this.Chk_Senha.UseVisualStyleBackColor = false;
            this.Chk_Senha.CheckedChanged += new System.EventHandler(this.Chk_Senha_CheckedChanged);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Mp3.Properties.Resources.Design_sem_nome1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 643);
            this.Controls.Add(this.Chk_Senha);
            this.Controls.Add(this.Btn_entrar);
            this.Controls.Add(this.Btn_X);
            this.Controls.Add(this.Link_Cadastro);
            this.Controls.Add(this.Link_Esqueceu);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Lbl_Login);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Login_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Login_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Login;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Nome;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_Senha;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Senha;
        private System.Windows.Forms.LinkLabel Link_Esqueceu;
        private System.Windows.Forms.LinkLabel Link_Cadastro;
        private Guna.UI2.WinForms.Guna2Button Btn_X;
        private Guna.UI2.WinForms.Guna2Button Btn_entrar;
        private Guna.UI2.WinForms.Guna2CheckBox Chk_Senha;
    }
}