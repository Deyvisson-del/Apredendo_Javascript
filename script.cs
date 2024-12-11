using System;
using System.Collections.Generic;

namespace BoasVindas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome:");
            string name = Console.ReadLine();
            Console.WriteLine("Bem-vindo: " + name);
        }
    }
}

class Program
{
    static void Main()
    {
        List<string> pokemon = new List<string> { "pikachu", "charmander", "Bulbasaur" };
        
        pokemon.RemoveAt(pokemon.Count - 1); // Remove o último elemento
        pokemon.RemoveAt(0); // Remove o primeiro elemento
        
        Console.WriteLine(string.Join(", ", pokemon)); // Exibe o array resultante
    }
}
