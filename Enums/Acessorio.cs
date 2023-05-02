using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao2.Enums
{
    public abstract class Acessorio : Produto
    {
        protected string _tamanho;
        protected string _cor;

        public Acessorio(string nome, double preco, CategoriaProduto categoria, string tamanho, string cor)
            : base(nome, preco, categoria)
        {
            _tamanho = tamanho;
            _cor = cor;
        }

        public string GetTamanho()
        {
            return _tamanho;
        }

        public string GetCor()
        {
            return _cor;
        }
    }

}
