using PizzariaPim.Model.Bebidas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.Control
{
    class ControleBebidas
    {
        public bool tem;
        public String menssage;
        public String CadastrarBebida(String descricao,String tipo,int quantidade, double valor)
        {
            ComandosBebidas comandos = new ComandosBebidas();
            comandos.CadastrarBebidas (descricao,tipo,quantidade,valor);
            return menssage;
        }
        public void AlterarBebidas (DadosBebidas dadosBebidas) 
        {
            ComandosBebidas comandos = new ComandosBebidas();
            comandos.AlterarBebidas(dadosBebidas);
        }
        public void Excluir(int codigo)
        {
            ComandosBebidas comandos = new ComandosBebidas();
            comandos.Excluir(codigo);
        }
        public void LocalizarBebida(String valor)
        {          
            ComandosBebidas comandos = new ComandosBebidas();
            comandos.LocalizarBebida(valor);          
            
        }
    }
} 
