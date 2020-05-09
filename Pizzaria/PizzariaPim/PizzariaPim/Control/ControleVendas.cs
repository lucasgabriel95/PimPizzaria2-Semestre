using PizzariaPim.Model.Vendas.Vendas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.Control
{
    class ControleVendas
    {
        public void CadatrarItens(int CodigoProduto, int CodigoVenda, int Quantidade, double Valor)
        {
            ComandosCadVenda comandos = new ComandosCadVenda();
            comandos.CadatrarItens(CodigoProduto, CodigoVenda, Quantidade, Valor);
        }
        public void Excluir(int codigo)
        {
            ComandosCadVenda comandos = new ComandosCadVenda();
            comandos.ExcluirIntens(codigo);
        }
       
        public void Alterar(DadosCadVenda dados)
        {

            ComandosCadVenda comandos = new ComandosCadVenda();
            comandos.Alterar(dados);

        }       
    }
}
