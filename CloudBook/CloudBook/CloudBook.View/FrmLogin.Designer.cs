namespace CloudBook
{
    partial class FrmLogin
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
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.GpbInformacao = new System.Windows.Forms.GroupBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtnRecuperarSenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.GpbInformacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.BackgroundImage = global::CloudBook.Properties.Resources.logocloudbook;
            this.PicLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicLogo.Location = new System.Drawing.Point(60, 12);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(109, 71);
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // GpbInformacao
            // 
            this.GpbInformacao.BackColor = System.Drawing.Color.Transparent;
            this.GpbInformacao.Controls.Add(this.TxtSenha);
            this.GpbInformacao.Controls.Add(this.TxtUsuario);
            this.GpbInformacao.Controls.Add(this.LblSenha);
            this.GpbInformacao.Controls.Add(this.LblUsuario);
            this.GpbInformacao.Location = new System.Drawing.Point(12, 86);
            this.GpbInformacao.Name = "GpbInformacao";
            this.GpbInformacao.Size = new System.Drawing.Size(201, 82);
            this.GpbInformacao.TabIndex = 1;
            this.GpbInformacao.TabStop = false;
            this.GpbInformacao.Text = "Informações de acesso:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(15, 26);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(46, 13);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Uusario:";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Location = new System.Drawing.Point(20, 52);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(41, 13);
            this.LblSenha.TabIndex = 1;
            this.LblSenha.Text = "Senha:";
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Location = new System.Drawing.Point(138, 174);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(75, 23);
            this.BtnEntrar.TabIndex = 2;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUsuario.Location = new System.Drawing.Point(67, 23);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(118, 20);
            this.TxtUsuario.TabIndex = 2;
            // 
            // TxtSenha
            // 
            this.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSenha.Location = new System.Drawing.Point(67, 49);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(118, 20);
            this.TxtSenha.TabIndex = 3;
            // 
            // BtnRecuperarSenha
            // 
            this.BtnRecuperarSenha.Location = new System.Drawing.Point(30, 174);
            this.BtnRecuperarSenha.Name = "BtnRecuperarSenha";
            this.BtnRecuperarSenha.Size = new System.Drawing.Size(102, 23);
            this.BtnRecuperarSenha.TabIndex = 3;
            this.BtnRecuperarSenha.Text = "Recuperar senha";
            this.BtnRecuperarSenha.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CloudBook.Properties.Resources.flat_550x550_075_f_u1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(225, 204);
            this.Controls.Add(this.BtnRecuperarSenha);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.GpbInformacao);
            this.Controls.Add(this.PicLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CloudBook - Login do sistema";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.GpbInformacao.ResumeLayout(false);
            this.GpbInformacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.GroupBox GpbInformacao;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Button BtnRecuperarSenha;
    }
}

