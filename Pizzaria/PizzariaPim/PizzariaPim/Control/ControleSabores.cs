using PizzariaPim.Model.Sabores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.Control
{
    class ControleSabores
    {
        public String menssage;

        public String Cadastrar(String nome, String ingredientes, double valorBroto, double ValorInteira, int quantidade)
        {
            ComandosSabores comandos = new ComandosSabores();
            comandos.cadastrar(nome, ingredientes,valorBroto,ValorInteira,quantidade);
            return menssage;
        }
        public void Alterar(DadosSabores dadosSabores)
        {
            ComandosSabores comandos = new ComandosSabores();
            comandos.Alterar(dadosSabores);
        }
        public void Excluir(int codigo)
        {
            ComandosSabores comandos = new ComandosSabores();
            comandos.Excluir(codigo);
        }
        public void Localizar(String valor)
        {
            ComandosSabores comandos = new ComandosSabores();
            comandos.localizar(valor);

        }
    }
}
