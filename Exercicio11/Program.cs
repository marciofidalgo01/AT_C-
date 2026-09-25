using System;
using System.IO;

public class Program{
    public static void Main(string[] args){
       
        string arquivo = "arquivo.txt";

        while (true)
        {
             Console.WriteLine("\n 1 - Adicionar novo contato \n 2 - Listar contatos cadastrados \n 3 - Sair \n");
            
            int opcao = 0;
            try
            {
               opcao = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite um numero valido");
            }

            if(opcao == 1)
            {
                 Console.Write("Digite o nome: ");
                 string nome = Console.ReadLine();
                 Console.Write("Digite o email: ");
                 string email = Console.ReadLine();
                 Console.Write("Digite o telefone: ");
                 string telefone = Console.ReadLine();

                using (StreamWriter escrever = new StreamWriter(arquivo, true))
                {
                    escrever.WriteLine($"{nome},{telefone},{email}");
                }

                 Console.Write("Cadastrado com sucesso! \n");

            }else if (opcao == 2)
            {
                
                FileInfo arquivoInfo = new FileInfo(arquivo);
                 if (File.Exists(arquivo) == false || arquivoInfo.Length == 0)
            {
                Console.WriteLine("O arquivo não existe ou nao tem usuarios cadastrados");
            }
            else
            {
                 using (StreamReader ler = new StreamReader(arquivo))
                {
                    string linha;
                    while ((linha = ler.ReadLine()) != null)
                    {

                       string[] dados = linha.Split(',');
                       if (dados.Length == 3)
                    {
                        Console.WriteLine($"Nome: {dados[0]} | Telefone: {dados[1]} | Email: {dados[2]}");
                    }
                    }
                }
            }
            }else if(opcao == 3)
            {
                break;
            }
        }  
    }
}
// João Silva,21 99999-9999,joao@email.com
// Maria Oliveira,11 98888-7777,maria@email.com