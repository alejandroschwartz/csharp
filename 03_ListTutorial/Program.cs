using System;
using System.Collections.Generic;

namespace _03_ListTutorial
{
    class Program
    {
        #region WorkingWithStrings
        static void WorkingWithStrings()
        {
            var nombres = new List<string>
            {
                "Ale",
                "Juan",
                "Matias",
                "Cesar",
                "Maria",
                "Lidia"
            };

            nombres.Add("Jorge");    // Adiciona un objeto a la lista
            nombres.Add("Juliana");
            nombres.Remove("Cesar");    // Remueve un objeto de la lista
            Console.WriteLine($"El 4to en la lista es: {nombres[3]}");
            Console.WriteLine($"La lista tiene {nombres.Count} objetos");
            Console.WriteLine("--------------------");


            // Recorre la lista y trae los elementos uno a uno.
            foreach (var nombre in nombres)
            {                
                Console.WriteLine($"Hola {nombre.ToUpper()} !");
            }
            Console.WriteLine("--------------------");


            // "IndexOf" Busca un elemento y devuelve su índice 
            var index = nombres.IndexOf("Maria");
            if (index == -1)
            {
                Console.WriteLine($"Cuando no se encentra, retorna {index}");
            }
            else
            {
                Console.WriteLine($"El nombre {nombres[index]} esta en el indice {index}");
            }
            index = nombres.IndexOf("Not Found");

            if (index == -1)
            {
                Console.WriteLine($"Cuando no se encentra, retorna {index}");
            }
            else
            {
                Console.WriteLine($"El nombre {nombres[index]} esta en el indice {index}");
            }
            Console.WriteLine("--------------------");


            // "Sort" Devuelve la lista en orden Alfabetico
            nombres.Sort();
            foreach (var nombre in nombres)
            {
                Console.WriteLine($"Hola {nombre} !");
            }
        }
        #endregion

        #region Excercise Fibonacci
        static void Excercise()
        {
            var fibonacciNumbers = new List<int> {1, 1};
            
            for (int index = 0; index < 18; index++)
            {   
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);   

            }

            int loop = 0;
            foreach (var item in fibonacciNumbers)
            {
                loop++;

                Console.WriteLine($"Serie: {loop}  -  Valor: {item}");
            }          
        }
        #endregion

        static void Main(string[] args)
        {
            // WorkingWithStrings();

            Excercise();
        }
    }
}
