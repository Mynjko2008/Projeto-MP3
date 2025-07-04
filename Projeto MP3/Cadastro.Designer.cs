
namespace Projeto_Mp3
{
    partial class Frm_Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastro));
            this.Btn_X = new Guna.UI2.WinForms.Guna2Button();
            this.Lbl_Cadastro = new System.Windows.Forms.Label();
            this.Lbl_Nome_do_Perfil = new System.Windows.Forms.Label();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Link_Cadastro = new System.Windows.Forms.LinkLabel();
            this.Txt_Nome = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_Senha = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_enviar = new Guna.UI2.WinForms.Guna2Button();
            this.Chk_Senha = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
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
            this.Btn_X.Location = new System.Drawing.Point(951, 2);
            this.Btn_X.Name = "Btn_X";
            this.Btn_X.Size = new System.Drawing.Size(50, 43);
            this.Btn_X.TabIndex = 9;
            this.Btn_X.Text = "X";
            this.Btn_X.UseTransparentBackground = true;
            this.Btn_X.Click += new System.EventHandler(this.Btn_X_Click);
            // 
            // Lbl_Cadastro
            // 
            this.Lbl_Cadastro.AutoSize = true;
            this.Lbl_Cadastro.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Cadastro.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cadastro.ForeColor = System.Drawing.Color.White;
            this.Lbl_Cadastro.Location = new System.Drawing.Point(514, 120);
            this.Lbl_Cadastro.Name = "Lbl_Cadastro";
            this.Lbl_Cadastro.Size = new System.Drawing.Size(115, 29);
            this.Lbl_Cadastro.TabIndex = 10;
            this.Lbl_Cadastro.Text = "Cadastro";
            // 
            // Lbl_Nome_do_Perfil
            // 
            this.Lbl_Nome_do_Perfil.AutoSize = true;
            this.Lbl_Nome_do_Perfil.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Nome_do_Perfil.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome_do_Perfil.ForeColor = System.Drawing.Color.White;
            this.Lbl_Nome_do_Perfil.Location = new System.Drawing.Point(295, 250);
            this.Lbl_Nome_do_Perfil.Name = "Lbl_Nome_do_Perfil";
            this.Lbl_Nome_do_Perfil.Size = new System.Drawing.Size(142, 21);
            this.Lbl_Nome_do_Perfil.TabIndex = 11;
            this.Lbl_Nome_do_Perfil.Text = "Nome do Perfil";
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Senha.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Senha.ForeColor = System.Drawing.Color.White;
            this.Lbl_Senha.Location = new System.Drawing.Point(298, 384);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(63, 21);
            this.Lbl_Senha.TabIndex = 12;
            this.Lbl_Senha.Text = "Senha";
            // 
            // Link_Cadastro
            // 
            this.Link_Cadastro.AutoSize = true;
            this.Link_Cadastro.BackColor = System.Drawing.Color.Transparent;
            this.Link_Cadastro.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_Cadastro.LinkColor = System.Drawing.Color.RoyalBlue;
            this.Link_Cadastro.Location = new System.Drawing.Point(475, 503);
            this.Link_Cadastro.Name = "Link_Cadastro";
            this.Link_Cadastro.Size = new System.Drawing.Size(154, 21);
            this.Link_Cadastro.TabIndex = 13;
            this.Link_Cadastro.TabStop = true;
            this.Link_Cadastro.Text = "Já tem cadastro?";
            this.Link_Cadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Cadastro_LinkClicked);
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
            this.Txt_Nome.Location = new System.Drawing.Point(298, 282);
            this.Txt_Nome.MaxLength = 30;
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.PasswordChar = '\0';
            this.Txt_Nome.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Txt_Nome.PlaceholderText = "";
            this.Txt_Nome.SelectedText = "";
            this.Txt_Nome.Size = new System.Drawing.Size(389, 36);
            this.Txt_Nome.TabIndex = 1;
            this.Txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nome_KeyPress);
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
            this.Txt_Senha.Location = new System.Drawing.Point(298, 420);
            this.Txt_Senha.MaxLength = 8;
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '•';
            this.Txt_Senha.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Txt_Senha.PlaceholderText = "";
            this.Txt_Senha.SelectedText = "";
            this.Txt_Senha.Size = new System.Drawing.Size(200, 36);
            this.Txt_Senha.TabIndex = 15;
            this.Txt_Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Senha_KeyPress);
            // 
            // Btn_enviar
            // 
            this.Btn_enviar.AutoRoundedCorners = true;
            this.Btn_enviar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_enviar.BorderRadius = 21;
            this.Btn_enviar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_enviar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_enviar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_enviar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_enviar.FillColor = System.Drawing.Color.Maroon;
            this.Btn_enviar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_enviar.ForeColor = System.Drawing.Color.White;
            this.Btn_enviar.Location = new System.Drawing.Point(700, 479);
            this.Btn_enviar.Name = "Btn_enviar";
            this.Btn_enviar.Size = new System.Drawing.Size(180, 45);
            this.Btn_enviar.TabIndex = 16;
            this.Btn_enviar.Text = "Enviar";
            this.Btn_enviar.UseTransparentBackground = true;
            this.Btn_enviar.Visible = false;
            this.Btn_enviar.Click += new System.EventHandler(this.Btn_enviar_Click);
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
            this.Chk_Senha.Location = new System.Drawing.Point(554, 439);
            this.Chk_Senha.Name = "Chk_Senha";
            this.Chk_Senha.Size = new System.Drawing.Size(101, 17);
            this.Chk_Senha.TabIndex = 17;
            this.Chk_Senha.Text = "Mostrar Senha?";
            this.Chk_Senha.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.Chk_Senha.UncheckedState.BorderRadius = 0;
            this.Chk_Senha.UncheckedState.BorderThickness = 0;
            this.Chk_Senha.UncheckedState.FillColor = System.Drawing.Color.White;
            this.Chk_Senha.UseVisualStyleBackColor = false;
            this.Chk_Senha.CheckedChanged += new System.EventHandler(this.Chk_Senha_CheckedChanged);
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Mp3.Properties.Resources.Design_sem_nome__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 637);
            this.Controls.Add(this.Chk_Senha);
            this.Controls.Add(this.Btn_enviar);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Link_Cadastro);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Lbl_Nome_do_Perfil);
            this.Controls.Add(this.Lbl_Cadastro);
            this.Controls.Add(this.Btn_X);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Cadastro_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Cadastro_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Btn_X;
        private System.Windows.Forms.Label Lbl_Cadastro;
        private System.Windows.Forms.Label Lbl_Nome_do_Perfil;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.LinkLabel Link_Cadastro;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Nome;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Senha;
        private Guna.UI2.WinForms.Guna2Button Btn_enviar;
        private Guna.UI2.WinForms.Guna2CheckBox Chk_Senha;
    }
}