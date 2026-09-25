using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string arquivo = "contatos.txt";

        while (true)
        {
            Console.WriteLine("\n1 - Adicionar novo contato");
            Console.WriteLine("2 - Listar contatos cadastrados");
            Console.WriteLine("3 - Sair");

            Console.Write("Escolha uma opção: ");
            int opcao;

            try
            {
                opcao = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite um número válido.");
                continue;
            }

            if (opcao == 1)
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o telefone: ");
                string telefone = Console.ReadLine();

                Console.Write("Digite o email: ");
                string email = Console.ReadLine();

                using (StreamWriter escrever = new StreamWriter(arquivo, true))
                {
                    escrever.WriteLine(nome + "," + telefone + "," + email);
                }

                Console.WriteLine("Cadastrado com sucesso!");
            }
            else if (opcao == 2)
            {
                if (!File.Exists(arquivo))
                {
                    Console.WriteLine("Não há contatos cadastrados.");
                    continue;
                }

                List<Contato> contatos = new List<Contato>();

                using (StreamReader ler = new StreamReader(arquivo))
                {
                    string linha;

                    while ((linha = ler.ReadLine()) != null)
                    {
                        string[] dados = linha.Split(',');

                        if (dados.Length == 3)
                        {
                            Contato contato = new Contato();

                            contato.Nome = dados[0];
                            contato.Telefone = dados[1];
                            contato.Email = dados[2];

                            contatos.Add(contato);
                        }
                    }
                }

                if (contatos.Count == 0)
                {
                    Console.WriteLine("Não há contatos cadastrados.");
                    continue;
                }

                Console.WriteLine("\nEscolha o formato de exibição:");
                Console.WriteLine("1 - Markdown");
                Console.WriteLine("2 - Tabela");
                Console.WriteLine("3 - Texto puro");

                Console.Write("Formato: ");
                int formato;

                try
                {
                    formato = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite um número válido.");
                    continue;
                }

                ContatoFormatter formatador;

                if (formato == 1)
                {
                    formatador = new MarkdownFormatter();
                }
                else if (formato == 2)
                {
                    formatador = new TabelaFormatter();
                }
                else if (formato == 3)
                {
                    formatador = new RawTextFormatter();
                }
                else
                {
                    Console.WriteLine("Formato inválido.");
                    continue;
                }

                formatador.ExibirContatos(contatos);
            }
            else if (opcao == 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}

public class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
}

public abstract class ContatoFormatter
{
    public abstract void ExibirContatos(List<Contato> contatos);
    
}

public class MarkdownFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("## Lista de Contatos");

        foreach (Contato contato in contatos)
        {
            Console.WriteLine("- Nome: " + contato.Nome);
            Console.WriteLine("- Telefone: " + contato.Telefone);
            Console.WriteLine("- Email: " + contato.Email + "\n");
        }
    }
}

public class TabelaFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("| Nome | Telefone | Email |");
        Console.WriteLine("----------------------------------------");

        foreach (Contato contato in contatos)
        {
            Console.WriteLine("| " + contato.Nome + " | " +
                              contato.Telefone + " | " +
                              contato.Email + " |");
        }

        Console.WriteLine("----------------------------------------");
    }
}

public class RawTextFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        foreach (Contato contato in contatos)
        {
            Console.WriteLine("Nome: " + contato.Nome +
                              " | Telefone: " + contato.Telefone +
                              " | Email: " + contato.Email + "\n");
        }
    }
}