using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Program{
    public static void Main(string[] args){
       {


            int opcao;

            Console.WriteLine("Digite 1 para ver a rubrica A do exercicio 9 ou 2 para ver a rubrica B");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                 Console.WriteLine("Rubrica A:");
                RubricaAClass.RubricaA();
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Rubrica B:");
                RubricaBClass.RubricaB();
            }
        }

        
    }
}
