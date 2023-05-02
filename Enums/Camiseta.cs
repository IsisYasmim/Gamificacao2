using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao2.Enums
{
    public class Camiseta : Produto
    {
        private string _tamanho;
        private string _cor;

        public Camiseta(string nome, double preco, string tamanho, string cor)
            : base(nome, preco, CategoriaProduto.Camiseta)
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
        public virtual string Descricao(){
            return GetNome() + " - R$" + GetPreco() +" - "+ _tamanho + " - "+_cor;
        }
    }
}
