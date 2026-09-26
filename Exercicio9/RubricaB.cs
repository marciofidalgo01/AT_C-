using System;
using System.IO;

public class RubricaBClass
{
    public static void RubricaB()
    {
        string arquivo = "estoque.txt";

        int ObterTotalProdutos()
        {
            if (!File.Exists(arquivo)) return 0;
            return File.ReadAllLines(arquivo).Length;
        }

        void CadastrarProduto()
        {
            int total = ObterTotalProdutos();

            if (total < 5)
            {
                Console.WriteLine("Digite o nome do produto");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a quantidade no estoque");
                int quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o preço unitario");
                double preco = double.Parse(Console.ReadLine());

                using (StreamWriter escrever = new StreamWriter(arquivo, true))
                {
                    escrever.WriteLine($"{nome},{quantidade},{preco:F2}");
                }
            }
            else
            {
                Console.WriteLine("Limite de produtos atingido!");
            }           
        }

        void ListarProduto()
        {
            if (!File.Exists(arquivo) || new FileInfo(arquivo).Length == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado");
                return;
            }

            try
            {
                using (StreamReader leitor = new StreamReader(arquivo))
                {
                    string linha;
                    while ((linha = leitor.ReadLine()) != null)
                    {
                        string[] dados = linha.Split(',');
                        if (dados.Length == 3)
                        {
                            Console.WriteLine($"Produto: {dados[0]} | Quantidade: {dados[1]} | Preço: R$ {dados[2]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao ler o arquivo: " + ex.Message);
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
                Console.WriteLine("erro: " + ex.Message);
                continue;
            }

            if (opcao == 1)
            {
                Console.WriteLine("Encerrando");
                break;
            }
            else if (opcao == 2)
            {
                CadastrarProduto();
            }
            else if (opcao == 3)
            {
                ListarProduto();
            }
        }
    }
}