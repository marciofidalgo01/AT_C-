using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


    public class RubricaAClass
    {
        public static void RubricaA()
        {
            List<Produto> produtos = new List<Produto>();
            int idProduto = 0;

            void CadastrarProduto(int id)
            {
               if (id < 2)
                {

                 Console.WriteLine("Digite o nome do produto");
                 string nome = Console.ReadLine();

                 Console.WriteLine("Digite a quantidade no estoque");
                 int quantidade = int.Parse(Console.ReadLine());

                 Console.WriteLine("Digite o preço unitario");
                 int preco = int.Parse(Console.ReadLine());

                 Produto produto = new Produto(nome, quantidade, preco);

                 produtos.Add(produto);

                }
                else
                {
                    Console.WriteLine("Limite de produtos atingido!");
                }           
            }

            void ListarProduto()
            {
                int id = 0;
                foreach (Produto p in produtos)
                {
                    id++;
                    Console.WriteLine($"\n Produto {id}: {p.Nome} | {p.QuantidadeEmEstoque} |  {p.PrecoUnitario} | ");
                }
            }


            while (true) 
            {
               Console.WriteLine("\n Digite uma das opções \n 1 - Encerrar o programa \n 2 - Cadastrar produto \n 3 - Listar produto");

                int opcao;

                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("erro: ", ex);
                    continue;
                }

                if (opcao == 1)
                {
                    Console.WriteLine("Encerrando...");
                    break;
                }

                else if (opcao == 2)
                {
                    
                    CadastrarProduto(idProduto);
                    idProduto++;
                }

                else if(opcao == 3)
                {
                    ListarProduto();
                }
            }
        }
    }
