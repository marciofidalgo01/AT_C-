
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program{
    public static void Main(string[] args){
       
            Funcionario funcionario1 = new Funcionario();
            Gerente gerente1 = new Gerente();

            funcionario1.Nome = "Marcio";
            funcionario1.Cargo = "Dev";

            gerente1.Nome = "Pedro";
            gerente1.Cargo = "Gerente";

            Console.WriteLine($"Nome: {funcionario1.Nome} \n Cargo: {funcionario1.Cargo} \n Salario: {funcionario1.GetSalario()} \n");
            Console.WriteLine($"Nome: {gerente1.Nome} \n Cargo: {gerente1.Cargo} \n Salario: {gerente1.GetSalario()}");
            
        }

        class Funcionario
        {
            public string Nome;
            public string Cargo;
            public double SalarioBase = 10000;

            public virtual double GetSalario()
            {
                return SalarioBase;
            }
           
        }

        class Gerente : Funcionario
        {
        
            public override double GetSalario()
                {
                    return SalarioBase + SalarioBase * 0.20;
                }
            
        }
    }

