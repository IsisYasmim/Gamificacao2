using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao2
{
    public class CarrinhoDeCompras
    {
        private List<Produto> _produtos;
        private List<Promocao> _promocoes;

        public CarrinhoDeCompras()
        {
            _produtos = new List<Produto>();
            _promocoes = new List<Promocao>();
        }

        public void AdicionarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public void AdicionarPromocao(Promocao promocao)
        {
            _promocoes.Add(promocao);
        }

        public double CalcularValorTotal()
        {
            double valorTotal = 0;

            foreach (var produto in _produtos)
            {
                valorTotal += produto.GetPreco();
            }

            foreach (var promocao in _promocoes)
            {
                double desconto = 0;

                foreach (var produto in _produtos)
                {
                    desconto += promocao.CalcularDesconto(produto.GetPreco());
                }

                valorTotal -= desconto;
            }

            return valorTotal;
        }
    }
}
