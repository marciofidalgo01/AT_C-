using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program{
    public static void Main(string[] args){
       
            ContaBancaria conta1 = new ContaBancaria("Marcio", 100);

            conta1.ExibirSaldo();
      
            conta1.Sacar(200);

            conta1.Depositar(500);


        }

        class ContaBancaria
        {
            public string Titular;
            private decimal Saldo;

            public ContaBancaria(string Titular, decimal Saldo)
            {
                this.Titular = Titular;
                this.Saldo = Saldo;
            }


            public void Depositar(decimal Valor)
            {
                Console.WriteLine($"Saldo atual: R${Saldo}");
                Console.WriteLine($"Depósito de R${Valor} efetuado com sucesso");
                Saldo = Saldo + Valor;
                Console.WriteLine($"Saldo final: R${Saldo} \n");
            }

            public void Sacar(decimal Valor)
            {
               if(Valor <= Saldo)
                {
                    Console.WriteLine($"Saldo atual: R${Saldo}");
                    Console.WriteLine($"Saque de R${Valor} efetuado com sucesso");
                    Saldo = Saldo - Valor;
                    Console.WriteLine($"Saldo final: R${Saldo} \n");
                }
                else
                {
                    Console.WriteLine($"Tentativa de saque: R${Valor}");
                    Console.WriteLine("Saldo insuficiente para realizar o saque \n");
                }
            }

            public void ExibirSaldo()
            {
                Console.WriteLine($"Titular: {Titular}");
                Console.WriteLine($"Saldo atual: R${Saldo} \n");
            }
        }
    }

