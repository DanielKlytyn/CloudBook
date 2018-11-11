using CloudBook.CloudBook.Model;
using CloudBook.CloudBook.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudBook
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        // Metodo que realiza o processo de criptografia do campo senha para comparação
        public string Criptografia(string senha)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(senha));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        // Botão que realiza o processo do login no sistema
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == string.Empty || TxtSenha.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos corretamente para efetuar o login!", "Aviso - CloudBook", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                LoginModel ObjLogin = new LoginModel();
                LoginController ObjLoginController = new LoginController();

                int logado;
                string senha = Criptografia(TxtSenha.Text);

                ObjLogin.Usuario = TxtUsuario.Text;
                ObjLogin.Senha = senha;

                logado = ObjLoginController.Login(ObjLogin);

                if (logado > 0)
                {
                    logado = 1;
                    this.Hide();
                    FrmPrincipal ObjFrmPrincipal = new FrmPrincipal();
                    ObjFrmPrincipal.ShowDialog();
                }
            }
        }
    }
}
