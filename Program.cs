using System;  // Importando uma biblioteca

namespace HelloWorldCamila
{
    // O que é uma class? 
    // Classe é uma representação de um objeto real ou de algo real que queremos representar. 
    internal class Program // isso é a classe principal dentro de um programa.
    {
        static void Main(string[] args)  // método ou função principal dentro desta classe
        {
            Console.WriteLine("Hello World, Camila!");

            Console.WriteLine("##########################");

            // for (; ; ) => é um "loop" infinito
            for (int indice = 0; indice < 100; indice++)  // Para essa ferramenta de desenvolvimento complementar o código, pressione tab+tab
            {
                Console.WriteLine("Estamos na interação nº" + indice);

                MostrarRoupas();

                Console.WriteLine("Você quer continuar? (pressione 1 para sim, 0 para não)");

                var decisaoDeParar = Console.ReadLine();

                if(Convert.ToInt32(decisaoDeParar) == 0)
                {
                    break;
                }
            }
        }

        static void MostrarRoupas()
        {
            Console.WriteLine("Qual é o seu nome? (no fim pressione enter)");

            var nome = Console.ReadLine();

            Console.WriteLine("Seja bem-vindo(a), " + nome + " ao Site de vendas de roupas CCs.");

            Console.WriteLine("Por favor, me informe a idade a pessoa que você quer comprar a roupa. (no fim pressione enter)");

            var idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 0 && idade <= 2) // && = and = e
            {
                Console.WriteLine("Aqui estão as roupas de bebe, entre 0 e 2 anos de idade.");
            }
            else if (idade >= 3 && idade <= 12)
            {
                Console.WriteLine("Aqui estão as roupas de criança, entre 3 e 12 anos de idade.");
            }
            else if (idade >= 13 && idade < 18)
            {
                Console.WriteLine("Aqui estão as roupas de adolescente, entre 13 e 17 anos de idade.");
            }
            else
            {
                Console.WriteLine("Aqui estão as roupas de adultos, entre 18 e 65 anos.");
                // Código aqui... 
            }
        }
    }
}