using System;
using System.Collections.Generic;

public class Program{
    public static void Main(string[] args){
       
            Console.WriteLine("Digite um nome:");
            string nome = Console.ReadLine();

            char[] alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b' };
            char[] ALFABETO = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B' };

            List<char> palavraLista = new List<char>();

            foreach (char letra in nome)
            {
                int index = Array.IndexOf(alfabeto, letra);
                int INDEX = Array.IndexOf(ALFABETO, letra);

                if (index != -1)
                {
                    palavraLista.Add(alfabeto[index + 2]);
                }
                else if (INDEX != -1)
                {
                    palavraLista.Add(ALFABETO[INDEX + 2]);
                }
                else
                {
                    palavraLista.Add(letra); 
                }
            }

            string palavraFinal = string.Join("", palavraLista);
            Console.WriteLine(palavraFinal);
        }
    }
