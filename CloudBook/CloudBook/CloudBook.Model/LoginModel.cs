using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudBook.CloudBook.Model
{
    public class LoginModel
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string RecuperarSenha { get; set; }

        public LoginModel()
        {
            this.Usuario = "";
            this.Senha = "";
            this.RecuperarSenha = "";
        }
    }
}

