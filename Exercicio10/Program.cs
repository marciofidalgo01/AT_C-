using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program{
    public static void Main(string[] args){
       
            Random random = new Random();


            int aleatorio = random.Next(1, 51);
            Console.WriteLine(aleatorio);

            Console.WriteLine("Tente acertar o numero de 1 a 50");
            int tentativa = int.Parse(Console.ReadLine());

            while (true)
            {
                if (tentativa <= 5 || tentativa >= 1)
                {
                    Console.WriteLine("Erro: Digite num intervalo de 1 a 50");
                }
                else if (tentativa == aleatorio)
                {
                    Console.WriteLine("Acertou");
                    break;
                }
                else if (tentativa != aleatorio)
                {
                    {
                        Console.WriteLine("Tente novamente");
                    }
                }
            }
        }
    }


