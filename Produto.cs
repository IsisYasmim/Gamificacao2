using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao2
{
    public abstract class Produto
    {
       
        private string _nome;
        private double _preco;
        private CategoriaProduto _categoria;

        public Produto( string nome, double preco, CategoriaProduto categoria)
        {
           
            _nome = nome;
            _preco = preco;
            _categoria = categoria;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public string GetNome()
        {
            return _nome;
        }

        public CategoriaProduto GetCategoria()
        {
            return _categoria;
        }
    }
}
