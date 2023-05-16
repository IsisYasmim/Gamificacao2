/* ------------- ALUNOS -------------------
ÍSIS YASMIM
GUILHERME FAVERO
FELIPE BUENO
*/
using Gamificacao2.Enums;
using Gamificacao2.Models;
using Gamificacao2.Services;

namespace Gamificacao2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Loja loja = new Loja();
            loja.AdicionarProdutos();
            loja.AdicionarPromocoes();

            Menu menu = new Menu(loja);
            menu.IniciarMenu();
            }
        }
}
