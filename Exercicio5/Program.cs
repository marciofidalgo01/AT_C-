using System;

public class Program
{
    public static void Main()
    {
        DateTime dataFormatura = new DateTime(2026, 12, 15);

        Console.Write("Digite a data atual (00/00/0000): ");

        DateTime dataAtual;

        try
        {
            dataAtual = DateTime.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Erro: Formato de data inválido!");
            return;
        }

        if (dataAtual > DateTime.Today)
        {
            Console.WriteLine("Erro: A data informada não pode ser no futuro!");
            return;
        }

        if (dataAtual > dataFormatura)
        {
            Console.WriteLine("Parabéns! Você já deveria estar formado!");
            return;
        }

        int anos = dataFormatura.Year - dataAtual.Year;
        int meses = dataFormatura.Month - dataAtual.Month;
        int dias = dataFormatura.Day - dataAtual.Day;

        if (dias < 0)
        {
            meses--;
            DateTime mesAnterior = dataFormatura.AddMonths(-1);
            dias += DateTime.DaysInMonth(mesAnterior.Year, mesAnterior.Month);
        }

        if (meses < 0)
        {
            anos--;
            meses += 12;
        }

        if (anos > 0)
        {
            Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura!");
        }
        else
        {
            Console.WriteLine($"Faltam {meses} meses e {dias} dias para sua formatura!");
        }

        int totalMeses = (anos * 12) + meses;
        if (totalMeses < 6)
        {
            Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
        }
    }
}