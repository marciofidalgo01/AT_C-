using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
        DateTime nascimento;

        try 
        {
            nascimento = DateTime.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Erro: Você não digitou uma data válida. Encerrando o programa.");
            return; 
        }
        
        DateTime hoje = DateTime.Today;
        
        DateTime proximoAniversario = nascimento.AddYears(hoje.Year - nascimento.Year);

        if (proximoAniversario < hoje)
        {
            proximoAniversario = proximoAniversario.AddYears(1);
        }

        int dias = (proximoAniversario - hoje).Days;

        if (dias == 0)
        {
            Console.WriteLine("Hoje é o seu aniversario");
        }
        else if (dias < 7)
        {
            Console.WriteLine($"Faltam só {dias} dias para o seu aniversário parabéns");
        }
        else
        {
            Console.WriteLine($"Faltam {dias} dias para o seu próximo aniversário.");
        }
    }
}