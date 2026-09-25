using System;

public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int aleatorio = random.Next(1, 51);

        int tentativasRestantes = 5;
        bool acertou = false;

        Console.WriteLine("Tente acertar o numero de 1 a 50");

        while (tentativasRestantes > 0)
        {
            Console.WriteLine($"\n Tentativas restantes: {tentativasRestantes}");

            int tentativa;

            try
            {
                tentativa = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite apenas numeros validos");
                continue; 
            }

          
            if (tentativa < 1 || tentativa > 50)
            {
                Console.WriteLine("Digite num intervalo de 1 a 50");
                continue; 
            }

            if (tentativa == aleatorio)
            {
                Console.WriteLine("Acertou");
                acertou = true;
                break;
            }
            else
            {
                tentativasRestantes--;

                if (tentativasRestantes > 0)
                {
                    Console.WriteLine("Tente novamente");
                }
            }
        }

        if (!acertou)
        {
            Console.WriteLine($"\nesgotou suas tentativas. O numero aleatorio era {aleatorio}.");
        }
    }
}