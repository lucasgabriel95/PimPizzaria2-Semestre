using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.DAL
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar (String login , String senha)
        {
            ComandosLogin comandos = new ComandosLogin();
            tem = comandos.verificarLogin(login, senha);
            if (! comandos.mensagem.Equals(""))
            {
                this.mensagem = comandos.mensagem;
            }
            return tem;
        }
    }
}
