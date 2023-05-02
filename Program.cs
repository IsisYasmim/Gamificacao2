/* ------------- ALUNOS -------------------
ÍSIS YASMIM
GUILHERME FAVERO
FELIPE BUENO
*/
using Gamificacao2;
using Gamificacao2.Enums;

namespace Gamificacao2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //produtos disponiveis na loja
            Camiseta camiseta = new Camiseta("Camiseta Polo", 49.99, "M", "Azul");
            Camiseta camiseta2 = new Camiseta("Camiseta de Botão", 59.99, "GG", "Branco");
            Calca calca = new Calca("Calça Social", 120.89, "M", "Preto");
            Calca calca2 = new Calca("Calça Jeans", 78.98, "M", "Azul");
            Sapato sapato = new Sapato("Sapato Social", 99.99, "42", "Preto", "Social");
            Sapato sapato2 = new Sapato("Sapato de Salto", 150.99, "35", "Vermelho", "Social");
            Bolsa bolsa = new Bolsa("Bolsa de Couro", 149.99, "Grande", "Marrom", "Couro");
            Bolsa bolsa2 = new Bolsa("Bolsa de Lantejoula", 30, "Pequena", "Rosa", "Lantejoula");

            //implementação de promoções de acordo com o enum dos produtos
            Promocao promocaoCamiseta = new Promocao("porcentagem", 10);
            Promocao promocaoSapato = new Promocao("valor_fixo", 20);
            Promocao promocaoBolsa = new Promocao("porcentagem", 15);
            Promocao promocaoCalca = new Promocao("porcentagem", 5);

            //criação do carrinho
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            int opcao;
            do
            {
                //menu do usuário
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adicionar camiseta ao carrinho de compras");
                Console.WriteLine("2 - Adicionar calça ao carrinho de compras");
                Console.WriteLine("3 - Adicionar bolsa ao carrinho de compras");
                Console.WriteLine("4 - Adicionar sapato ao carrinho de compras");
                Console.WriteLine("5 - Adicionar promoções");
                Console.WriteLine("6 - Finalizar compra");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Escolha uma camiseta pelo número: ");
                        Console.WriteLine("1 - " + camiseta.Descricao());
                        Console.WriteLine("2 - " + camiseta2.Descricao());
                        int opcaoCamisa = int.Parse(Console.ReadLine());
                        if (opcaoCamisa == 1)
                        {
                            carrinho.AdicionarProduto(camiseta);
                        }
                        else if (opcaoCamisa == 2)
                        {
                            carrinho.AdicionarProduto(camiseta2);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida!");
                        }

                        break;


                    case 2:
                        Console.WriteLine("Escolha uma calça pelo número: ");
                        Console.WriteLine("1 - " + calca.Descricao());
                        Console.WriteLine("2 - " + calca2.Descricao());
                        int opcaoCalca = int.Parse(Console.ReadLine());
                        if (opcaoCalca == 1)
                        {
                            carrinho.AdicionarProduto(calca);
                        }
                        else if (opcaoCalca == 2)
                        {
                            carrinho.AdicionarProduto(calca2);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida!");
                        }
                        break;


                    case 3:
                        Console.WriteLine("Escolha uma bolsa pelo número: ");
                        Console.WriteLine("1 - " + bolsa.Descricao());
                        Console.WriteLine("2 - " + bolsa2.Descricao());
                        int opcaoBolsa = int.Parse(Console.ReadLine());
                        if (opcaoBolsa == 1)
                        {
                            carrinho.AdicionarProduto(bolsa);
                        }
                        else if (opcaoBolsa == 2)
                        {
                            carrinho.AdicionarProduto(bolsa2);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida!");
                        }
                        break;



                    case 4:
                        Console.WriteLine("Escolha um sapato pelo número: ");
                        Console.WriteLine("1 - " + sapato.Descricao());
                        Console.WriteLine("2 - " + sapato2.Descricao());
                        int opcaoSapato = int.Parse(Console.ReadLine());
                        if (opcaoSapato == 1)
                        {
                            carrinho.AdicionarProduto(sapato);
                        }
                        else if (opcaoSapato == 2)
                        {
                            carrinho.AdicionarProduto(sapato2);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida!");
                        }

                        break;

                    case 5:
                        int opcaoPromocao;
                        do
                        {
                            Console.WriteLine("Escolha uma opção:");
                            Console.WriteLine("1 - Adicionar promoção à camiseta");
                            Console.WriteLine("2 - Adicionar promoção à calça");
                            Console.WriteLine("3 - Adicionar promoção à bolsa");
                            Console.WriteLine("4 - Adicionar promoção ao sapato");
                            Console.WriteLine("0 - Sair");
                            opcaoPromocao = int.Parse(Console.ReadLine());
                            switch (opcaoPromocao)
                            {
                                case 1:
                                    carrinho.AdicionarPromocao(promocaoCamiseta);
                                    break;

                                case 2:
                                    carrinho.AdicionarPromocao(promocaoCalca);
                                    break;

                                case 3:
                                    carrinho.AdicionarPromocao(promocaoBolsa);
                                    break;

                                case 4:
                                    carrinho.AdicionarPromocao(promocaoSapato);
                                    break;

                                case 0:
                                    Console.WriteLine("Saindo...");
                                    break;

                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                            }
                            Console.WriteLine("\nPressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                        } while (opcaoPromocao != 0);

                        break;

                    case 6:
                        Console.WriteLine("Valor total com descontos: " + carrinho.CalcularValorTotal());
                        Console.WriteLine("Insira o nome do cliente: ");
                        string cliente = Console.ReadLine();
                        Console.WriteLine("Insira o endereço do cliente: ");
                        string endereco = Console.ReadLine();
                        Console.WriteLine("Insira o método de pagamento do cliente: ");
                        string metodo = Console.ReadLine();
                        Pagamento pagamento = new Pagamento(carrinho, cliente, endereco, metodo);
                        Console.WriteLine(pagamento.GerarNotaFiscal());
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;


                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcao != 0);
        }
    }
}

