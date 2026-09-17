using System;
using System.Collections.Generic;
using System.IO; // Adicionado apenas para reconhecer StreamWriter e File
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


    public class RubricaBClass
    {
        public static void RubricaB()
        {

            string arquivo = @"arquivo.txt";
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


                 using(StreamWriter escrever = new StreamWriter(arquivo, true))
                    {
                        
                        escrever.WriteLine($"Produto {id + 1}: {produto.Nome}, {produto.QuantidadeEmEstoque}, {produto.PrecoUnitario}, \n");  
                    };

                }
                else
                {
                    Console.WriteLine("Limite de produtos atingido!");
                }           
            }

            void ListarProduto()
            {
               string conteudo = File.ReadAllText(arquivo);
               Console.WriteLine(conteudo);
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
                    Console.WriteLine("Encerrando");
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
