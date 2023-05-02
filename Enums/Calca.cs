using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao2.Enums
{
    public class Calca : Produto
    {
        private string _tamanho;
        private string _cor;
        private string _modelo;

        public Calca(string nome, double preco, string tamanho, string cor, string modelo)
            : base(nome, preco, CategoriaProduto.Calca)
        {
            _tamanho = tamanho;
            _cor = cor;
            _modelo = modelo;
        }

        public string GetTamanho()
        {
            return _tamanho;
        }

        public string GetCor()
        {
            return _cor;
        }
        
        public string GetModelo()
        {
        return _modelo;
        }
    
        public virtual string Descricao(){
            return GetNome() + " - R$" + GetPreco() +" - "+ _tamanho + " - "+_cor;
        }
    }
    
}
