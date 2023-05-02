using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao2
{
    public class Promocao
    {
        private string _tipoDesconto;
        private double _valorDesconto;

        public Promocao(string tipoDesconto, double valorDesconto)
        {
            _tipoDesconto = tipoDesconto;
            _valorDesconto = valorDesconto;
        }

        public double CalcularDesconto(double preco)
        {
            if (_tipoDesconto == "porcentagem")
            {
                return preco * (_valorDesconto / 100);
            }
            else if (_tipoDesconto == "valor_fixo")
            {
                return _valorDesconto;
            }
            else
            {
                throw new ArgumentException("Tipo de desconto inválido");
            }
        }
    }
}
