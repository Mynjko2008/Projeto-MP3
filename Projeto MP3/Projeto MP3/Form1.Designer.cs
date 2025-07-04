
namespace Projeto_Mp3
{
    partial class Frm_Acesso
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Acesso));
            this.Btn_X = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_login = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Btn_Cadastro = new Guna.UI2.WinForms.Guna2CircleButton();
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
            this.Btn_X.Location = new System.Drawing.Point(1040, 12);
            this.Btn_X.Name = "Btn_X";
            this.Btn_X.Size = new System.Drawing.Size(50, 43);
            this.Btn_X.TabIndex = 0;
            this.Btn_X.Text = "X";
            this.Btn_X.UseTransparentBackground = true;
            this.Btn_X.Click += new System.EventHandler(this.Btn_X_Click);
            // 
            // Btn_login
            // 
            this.Btn_login.BackColor = System.Drawing.Color.Transparent;
            this.Btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_login.FillColor = System.Drawing.Color.Red;
            this.Btn_login.FocusedColor = System.Drawing.Color.Transparent;
            this.Btn_login.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_login.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_login.Location = new System.Drawing.Point(233, 439);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_login.Size = new System.Drawing.Size(148, 148);
            this.Btn_login.TabIndex = 9;
            this.Btn_login.Text = "Login";
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Btn_Cadastro
            // 
            this.Btn_Cadastro.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cadastro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Cadastro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Cadastro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Cadastro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Cadastro.FillColor = System.Drawing.Color.Blue;
            this.Btn_Cadastro.FocusedColor = System.Drawing.Color.Transparent;
            this.Btn_Cadastro.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Cadastro.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Cadastro.Location = new System.Drawing.Point(748, 439);
            this.Btn_Cadastro.Name = "Btn_Cadastro";
            this.Btn_Cadastro.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_Cadastro.Size = new System.Drawing.Size(148, 148);
            this.Btn_Cadastro.TabIndex = 10;
            this.Btn_Cadastro.Text = "Cadastro";
            this.Btn_Cadastro.Click += new System.EventHandler(this.Btn_Cadastro_Click);
            // 
            // Frm_Acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Mp3.Properties.Resources.Sim;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1137, 658);
            this.Controls.Add(this.Btn_Cadastro);
            this.Controls.Add(this.Btn_login);
            this.Controls.Add(this.Btn_X);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_Acesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Acesso_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Btn_X;
        private Guna.UI2.WinForms.Guna2CircleButton Btn_login;
        private Guna.UI2.WinForms.Guna2CircleButton Btn_Cadastro;
    }
}

