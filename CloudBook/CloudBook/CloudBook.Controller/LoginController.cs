using CloudBook.CloudBook.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudBook.CloudBook.Controller
{
    public class LoginController
    {    
        // Metodo responsavel por realizar o login e verificação no banco de dados
        public int Login(LoginModel Login)
        {
            int logado = 0;
            MySqlCommand ObjCommand = new MySqlCommand();
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.CommandText = "SP_LoginUsuario";

            ObjCommand.Parameters.Add("@pusuario", MySqlDbType.VarChar).Value = Login.Usuario;
            ObjCommand.Parameters.Add("@psenha", MySqlDbType.VarChar).Value = Login.Senha;

            using (MySqlConnection ObjConnection = ConexaoController.GetInstancia().GetConexao())
            {
                try
                {
                    ObjConnection.Open();
                    ObjCommand.Connection = ObjConnection;

                    MySqlDataReader ObjReader = ObjCommand.ExecuteReader();

                    if (ObjReader.Read())
                    {
                        logado = 1;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao logar verifique usuario e senha!", "Aviso - CloudBook", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao logar no sistema verifique conexão com banco de dados: ", "Aviso - CloudBook", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Informações do erro:" + ex.Message);
                }
                finally
                {
                    ObjConnection.Close();
                }
                return logado;
            }
        }

        // Metodo responsavel por recuperar a senha do um usuario
        public void RecuperarSenha(LoginModel login)
        {
            MySqlCommand ObjCommand = new MySqlCommand();
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.CommandText = "SP_RecuperarUsuario";

            ObjCommand.Parameters.Add("@pusuario", MySqlDbType.VarChar).Value = login.RecuperarSenha;

            using (MySqlConnection ObjConnection = ConexaoController.GetInstancia().GetConexao())
            {
                try
                {
                    ObjConnection.Open();
                    ObjCommand.Connection = ObjConnection;

                    MySqlDataReader ObjReader = ObjCommand.ExecuteReader();

                    while (ObjReader.Read())
                    {
                        if (ObjReader["senha"] != null)
                        {
                            MessageBox.Show("Anote sua senha!", "Aviso - CloudBook", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(ObjReader["senha"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no sistema verifique conexão com banco de dados: ", "Aviso - CloudBook", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Informações do erro:" + ex.Message);
                }
                finally
                {
                    ObjConnection.Close();
                }
            }
        }
    }
}

