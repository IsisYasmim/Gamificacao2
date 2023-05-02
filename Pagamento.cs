using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao2
{
    public class Pagamento
    {
        private CarrinhoDeCompras _carrinho;
        private string _nomeCliente;
        private string _endereco;
        private string _formaPagamento;

        public Pagamento(CarrinhoDeCompras carrinho, string nomeCliente, string endereco, string formaPagamento)
        {
            _carrinho = carrinho;
            _nomeCliente = nomeCliente;
            _endereco = endereco;
            _formaPagamento = formaPagamento;
        }

        public string GerarNotaFiscal()
        {
            double valorTotal = _carrinho.CalcularValorTotal();
            string notaFiscal = "Nota Fiscal\n";
            notaFiscal += "Nome: " + _nomeCliente + "\n";
            notaFiscal += "Endereço: " + _endereco + "\n";
            notaFiscal += "Forma de Pagamento: " + _formaPagamento + "\n";
            notaFiscal += "Valor Total: " + valorTotal.ToString("F2") + "\n";
            return notaFiscal;
        }
    }
}
