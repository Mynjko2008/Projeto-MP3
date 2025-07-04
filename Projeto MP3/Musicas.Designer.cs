
namespace Projeto_Mp3
{
    partial class Frm_Musicas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Musicas));
            this.Btn_X = new Guna.UI2.WinForms.Guna2Button();
            this.Cmb_Tipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Cmb_Estilo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Cmb_Artista = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Cmb_Musica = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Lbl_Tipo = new System.Windows.Forms.Label();
            this.Lbl_Estilo = new System.Windows.Forms.Label();
            this.Lbl_Artista = new System.Windows.Forms.Label();
            this.Lbl_Musica = new System.Windows.Forms.Label();
            this.Pic_Albuns = new System.Windows.Forms.PictureBox();
            this.Cmb_Velocidade = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Btn_VolumeUp = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Btn_VolumeDown = new Guna.UI2.WinForms.Guna2CircleButton();
            this.LblVolume = new System.Windows.Forms.Label();
            this.Lbl_Velocidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Albuns)).BeginInit();
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
            this.Btn_X.Location = new System.Drawing.Point(1071, 1);
            this.Btn_X.Name = "Btn_X";
            this.Btn_X.Size = new System.Drawing.Size(50, 43);
            this.Btn_X.TabIndex = 19;
            this.Btn_X.Text = "X";
            this.Btn_X.UseTransparentBackground = true;
            this.Btn_X.Click += new System.EventHandler(this.Btn_X_Click);
            // 
            // Cmb_Tipo
            // 
            this.Cmb_Tipo.AutoRoundedCorners = true;
            this.Cmb_Tipo.BackColor = System.Drawing.Color.Transparent;
            this.Cmb_Tipo.BorderColor = System.Drawing.Color.Black;
            this.Cmb_Tipo.BorderRadius = 17;
            this.Cmb_Tipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Tipo.FillColor = System.Drawing.Color.DimGray;
            this.Cmb_Tipo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_Tipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_Tipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cmb_Tipo.ForeColor = System.Drawing.Color.Black;
            this.Cmb_Tipo.ItemHeight = 30;
            this.Cmb_Tipo.Location = new System.Drawing.Point(159, 90);
            this.Cmb_Tipo.Name = "Cmb_Tipo";
            this.Cmb_Tipo.Size = new System.Drawing.Size(140, 36);
            this.Cmb_Tipo.TabIndex = 1;
            this.Cmb_Tipo.SelectedIndexChanged += new System.EventHandler(this.Cmb_Tipo_SelectedIndexChanged);
            // 
            // Cmb_Estilo
            // 
            this.Cmb_Estilo.AutoRoundedCorners = true;
            this.Cmb_Estilo.BackColor = System.Drawing.Color.Transparent;
            this.Cmb_Estilo.BorderColor = System.Drawing.Color.Black;
            this.Cmb_Estilo.BorderRadius = 17;
            this.Cmb_Estilo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_Estilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Estilo.FillColor = System.Drawing.Color.DimGray;
            this.Cmb_Estilo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_Estilo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_Estilo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cmb_Estilo.ForeColor = System.Drawing.Color.Black;
            this.Cmb_Estilo.ItemHeight = 30;
            this.Cmb_Estilo.Location = new System.Drawing.Point(344, 90);
            this.Cmb_Estilo.Name = "Cmb_Estilo";
            this.Cmb_Estilo.Size = new System.Drawing.Size(140, 36);
            this.Cmb_Estilo.TabIndex = 21;
            this.Cmb_Estilo.Visible = false;
            this.Cmb_Estilo.SelectedIndexChanged += new System.EventHandler(this.Cmb_Estilo_SelectedIndexChanged);
            // 
            // Cmb_Artista
            // 
            this.Cmb_Artista.AutoRoundedCorners = true;
            this.Cmb_Artista.BackColor = System.Drawing.Color.Transparent;
            this.Cmb_Artista.BorderColor = System.Drawing.Color.Black;
            this.Cmb_Artista.BorderRadius = 17;
            this.Cmb_Artista.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_Artista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Artista.FillColor = System.Drawing.Color.DimGray;
            this.Cmb_Artista.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_Artista.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_Artista.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cmb_Artista.ForeColor = System.Drawing.Color.Black;
            this.Cmb_Artista.ItemHeight = 30;
            this.Cmb_Artista.Location = new System.Drawing.Point(529, 90);
            this.Cmb_Artista.Name = "Cmb_Artista";
            this.Cmb_Artista.Size = new System.Drawing.Size(140, 36);
            this.Cmb_Artista.TabIndex = 22;
            this.Cmb_Artista.Visible = false;
            this.Cmb_Artista.SelectedIndexChanged += new System.EventHandler(this.Cmb_Artista_SelectedIndexChanged);
            // 
            // Cmb_Musica
            // 
            this.Cmb_Musica.AutoRoundedCorners = true;
            this.Cmb_Musica.BackColor = System.Drawing.Color.Transparent;
            this.Cmb_Musica.BorderColor = System.Drawing.Color.Black;
            this.Cmb_Musica.BorderRadius = 17;
            this.Cmb_Musica.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_Musica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Musica.FillColor = System.Drawing.Color.DimGray;
            this.Cmb_Musica.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_Musica.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_Musica.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cmb_Musica.ForeColor = System.Drawing.Color.Black;
            this.Cmb_Musica.ItemHeight = 30;
            this.Cmb_Musica.Location = new System.Drawing.Point(714, 90);
            this.Cmb_Musica.Name = "Cmb_Musica";
            this.Cmb_Musica.Size = new System.Drawing.Size(140, 36);
            this.Cmb_Musica.TabIndex = 23;
            this.Cmb_Musica.Visible = false;
            // 
            // Lbl_Tipo
            // 
            this.Lbl_Tipo.AutoSize = true;
            this.Lbl_Tipo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Tipo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Tipo.Location = new System.Drawing.Point(209, 59);
            this.Lbl_Tipo.Name = "Lbl_Tipo";
            this.Lbl_Tipo.Size = new System.Drawing.Size(61, 24);
            this.Lbl_Tipo.TabIndex = 25;
            this.Lbl_Tipo.Text = "Tipos";
            // 
            // Lbl_Estilo
            // 
            this.Lbl_Estilo.AutoSize = true;
            this.Lbl_Estilo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Estilo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estilo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Estilo.Location = new System.Drawing.Point(374, 59);
            this.Lbl_Estilo.Name = "Lbl_Estilo";
            this.Lbl_Estilo.Size = new System.Drawing.Size(75, 24);
            this.Lbl_Estilo.TabIndex = 26;
            this.Lbl_Estilo.Text = "Estilos";
            // 
            // Lbl_Artista
            // 
            this.Lbl_Artista.AutoSize = true;
            this.Lbl_Artista.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Artista.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Artista.ForeColor = System.Drawing.Color.White;
            this.Lbl_Artista.Location = new System.Drawing.Point(562, 59);
            this.Lbl_Artista.Name = "Lbl_Artista";
            this.Lbl_Artista.Size = new System.Drawing.Size(83, 24);
            this.Lbl_Artista.TabIndex = 27;
            this.Lbl_Artista.Text = "Artistas";
            // 
            // Lbl_Musica
            // 
            this.Lbl_Musica.AutoSize = true;
            this.Lbl_Musica.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Musica.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Musica.ForeColor = System.Drawing.Color.White;
            this.Lbl_Musica.Location = new System.Drawing.Point(748, 59);
            this.Lbl_Musica.Name = "Lbl_Musica";
            this.Lbl_Musica.Size = new System.Drawing.Size(85, 24);
            this.Lbl_Musica.TabIndex = 28;
            this.Lbl_Musica.Text = "Músicas";
            // 
            // Pic_Albuns
            // 
            this.Pic_Albuns.Location = new System.Drawing.Point(344, 191);
            this.Pic_Albuns.Name = "Pic_Albuns";
            this.Pic_Albuns.Size = new System.Drawing.Size(367, 264);
            this.Pic_Albuns.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Albuns.TabIndex = 29;
            this.Pic_Albuns.TabStop = false;
            this.Pic_Albuns.Visible = false;
            // 
            // Cmb_Velocidade
            // 
            this.Cmb_Velocidade.AutoRoundedCorners = true;
            this.Cmb_Velocidade.BackColor = System.Drawing.Color.Transparent;
            this.Cmb_Velocidade.BorderColor = System.Drawing.Color.Black;
            this.Cmb_Velocidade.BorderRadius = 17;
            this.Cmb_Velocidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_Velocidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Velocidade.FillColor = System.Drawing.Color.DimGray;
            this.Cmb_Velocidade.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_Velocidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_Velocidade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cmb_Velocidade.ForeColor = System.Drawing.Color.Black;
            this.Cmb_Velocidade.ItemHeight = 30;
            this.Cmb_Velocidade.Location = new System.Drawing.Point(766, 334);
            this.Cmb_Velocidade.Name = "Cmb_Velocidade";
            this.Cmb_Velocidade.Size = new System.Drawing.Size(140, 36);
            this.Cmb_Velocidade.TabIndex = 35;
            this.Cmb_Velocidade.Visible = false;
            this.Cmb_Velocidade.SelectedIndexChanged += new System.EventHandler(this.Cmb_Velocidade_SelectedIndexChanged_1);
            // 
            // Btn_VolumeUp
            // 
            this.Btn_VolumeUp.BackColor = System.Drawing.Color.Transparent;
            this.Btn_VolumeUp.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_VolumeUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_VolumeUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_VolumeUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_VolumeUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_VolumeUp.FillColor = System.Drawing.Color.White;
            this.Btn_VolumeUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_VolumeUp.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_VolumeUp.Image = global::Projeto_Mp3.Properties.Resources.Mais;
            this.Btn_VolumeUp.Location = new System.Drawing.Point(57, 151);
            this.Btn_VolumeUp.Name = "Btn_VolumeUp";
            this.Btn_VolumeUp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_VolumeUp.Size = new System.Drawing.Size(72, 69);
            this.Btn_VolumeUp.TabIndex = 36;
            this.Btn_VolumeUp.Visible = false;
            // 
            // Btn_VolumeDown
            // 
            this.Btn_VolumeDown.BackColor = System.Drawing.Color.Transparent;
            this.Btn_VolumeDown.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_VolumeDown.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_VolumeDown.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_VolumeDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_VolumeDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_VolumeDown.FillColor = System.Drawing.Color.White;
            this.Btn_VolumeDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_VolumeDown.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_VolumeDown.Image = global::Projeto_Mp3.Properties.Resources.Menos;
            this.Btn_VolumeDown.Location = new System.Drawing.Point(57, 301);
            this.Btn_VolumeDown.Name = "Btn_VolumeDown";
            this.Btn_VolumeDown.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_VolumeDown.Size = new System.Drawing.Size(72, 69);
            this.Btn_VolumeDown.TabIndex = 37;
            this.Btn_VolumeDown.Visible = false;
            // 
            // LblVolume
            // 
            this.LblVolume.AutoSize = true;
            this.LblVolume.BackColor = System.Drawing.Color.Transparent;
            this.LblVolume.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVolume.ForeColor = System.Drawing.Color.White;
            this.LblVolume.Location = new System.Drawing.Point(53, 259);
            this.LblVolume.Name = "LblVolume";
            this.LblVolume.Size = new System.Drawing.Size(24, 24);
            this.LblVolume.TabIndex = 41;
            this.LblVolume.Text = "T";
            this.LblVolume.Visible = false;
            // 
            // Lbl_Velocidade
            // 
            this.Lbl_Velocidade.AutoSize = true;
            this.Lbl_Velocidade.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Velocidade.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Velocidade.ForeColor = System.Drawing.Color.White;
            this.Lbl_Velocidade.Location = new System.Drawing.Point(780, 301);
            this.Lbl_Velocidade.Name = "Lbl_Velocidade";
            this.Lbl_Velocidade.Size = new System.Drawing.Size(111, 24);
            this.Lbl_Velocidade.TabIndex = 42;
            this.Lbl_Velocidade.Text = "Velocidade";
            this.Lbl_Velocidade.Visible = false;
            // 
            // Frm_Musicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 633);
            this.Controls.Add(this.Lbl_Velocidade);
            this.Controls.Add(this.LblVolume);
            this.Controls.Add(this.Btn_VolumeDown);
            this.Controls.Add(this.Btn_VolumeUp);
            this.Controls.Add(this.Cmb_Velocidade);
            this.Controls.Add(this.Pic_Albuns);
            this.Controls.Add(this.Lbl_Musica);
            this.Controls.Add(this.Lbl_Artista);
            this.Controls.Add(this.Lbl_Estilo);
            this.Controls.Add(this.Lbl_Tipo);
            this.Controls.Add(this.Cmb_Musica);
            this.Controls.Add(this.Cmb_Artista);
            this.Controls.Add(this.Cmb_Estilo);
            this.Controls.Add(this.Cmb_Tipo);
            this.Controls.Add(this.Btn_X);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_Musicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musicas";
            this.Load += new System.EventHandler(this.Frm_Musicas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Albuns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Btn_X;
        private Guna.UI2.WinForms.Guna2ComboBox Cmb_Estilo;
        private Guna.UI2.WinForms.Guna2ComboBox Cmb_Artista;
        private Guna.UI2.WinForms.Guna2ComboBox Cmb_Musica;
        private System.Windows.Forms.Label Lbl_Tipo;
        private System.Windows.Forms.Label Lbl_Estilo;
        private System.Windows.Forms.Label Lbl_Artista;
        private System.Windows.Forms.Label Lbl_Musica;
        private Guna.UI2.WinForms.Guna2ComboBox Cmb_Tipo;
        private System.Windows.Forms.PictureBox Pic_Albuns;
        private Guna.UI2.WinForms.Guna2ComboBox Cmb_Velocidade;
        private Guna.UI2.WinForms.Guna2CircleButton Btn_VolumeUp;
        private Guna.UI2.WinForms.Guna2CircleButton Btn_VolumeDown;
        private System.Windows.Forms.Label LblVolume;
        private System.Windows.Forms.Label Lbl_Velocidade;
    }
}