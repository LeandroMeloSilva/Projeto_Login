using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Login
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginComando loginComando = new LoginComando();
            tem = loginComando.verificarLogin(login, senha);
            if(!loginComando.mensagem.Equals(""))
            {
                this.mensagem = loginComando.mensagem;
            }
            return tem;
        }
        public String cadastrar(String usuario, String senha, String confSenha)
        {
            return mensagem;
        }
    }
    
}
