using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Program{
    public static void Main(string[] args){

        static double Soma( int a1, int a2)
        {
            return a1 + a2;
        }

        static double Subtracao(int a1, int a2)
        {
            return a1 - a2;
        }

        static double Multiplicacao(int a1, int a2)
        {
            return a1 * a2;
        }

        static double Divisao(int a1, int a2)
        {
            if (a2 == 0)
            {
                Console.WriteLine("sem dividir por zero");
                return 0;
            }
            else
            {
                return (double) a1 / a2;
            }
        }

        static void Menu()
        {
            try
            {
                Console.WriteLine("\nDigite um numero");
                int numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um segundo numero");
                int numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Diga a operação \n 1: Soma \n 2: Subtracao\n 3: Multiplicacao\n 4: Divisao\n");
                int operacao = int.Parse(Console.ReadLine());

                if (operacao == 1)
                {
                    Console.WriteLine("Resultado: " + Soma(numero1, numero2));
                }
                else if (operacao == 2)
                {
                    Console.WriteLine("Resultado: " + Subtracao(numero1, numero2));
                }
                else if (operacao == 3)
                {
                    Console.WriteLine("Resultado: " + Multiplicacao(numero1, numero2));
                }
                else if (operacao == 4)
                {
                    Console.WriteLine("Resultado: " + Divisao(numero1, numero2));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ocorreu um erro. Digite apenas numeros");
            }
        }

        static void Loop()
        {
            Menu();

            while (true)
            {
                try
                {
                    Console.WriteLine("Digite 1 para continuar e 2 para encerrar o programa \n");
                    int opcao = int.Parse(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Menu();
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Digite apenas 1 ou 2 para continuar/encerrar o programa \n");
                }
            }
        }

        Loop();
    }
}