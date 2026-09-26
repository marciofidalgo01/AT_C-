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
        Produto[] produtos = new Produto[5];
        int idProduto = 0;

        void CadastrarProduto(int id)
        {
            if (id < 5)
            {
                Console.WriteLine("Digite o nome do produto");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a quantidade no estoque");
                int quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o preço unitario");
                double preco = double.Parse(Console.ReadLine());

                produtos[idProduto] = new Produto(nome, quantidade, preco);
                idProduto++;
            }
            else
            {
                Console.WriteLine("Limite de produtos atingido");
            }           
        }

        void ListarProduto()
        {
            int id = 0;
            foreach (Produto p in produtos)
            {
                if (p == null)
                {
                    continue;
                }

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
            }
            else if (opcao == 3)
            {
                ListarProduto();
            }
        }
    }
}