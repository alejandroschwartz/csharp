using System;

namespace BranchesAndLoops
{
    class Program
    {
        #region ExploreIf
        static void ExploreIf()
        {
            int a = 5;
            int b = 6;

            if (a + b > 10)
            {
                Console.WriteLine("Resultado es MAYOR a 10");
            }
            else 
            {
                Console.WriteLine("Resultado es MENOR a 10");
            }
        }
        #endregion

        #region AndOperator
        static void AndOperator()
        {
            int a = 7;
            int b = 3;
            int c = 4;

            if ( (a + b + c > 10) && (a > b) )
            {
                Console.WriteLine("Resultado es MAYOR a 10");
                Console.WriteLine("Y el valor de a es MAYOR al de b");
            } 
            else
            {
                Console.WriteLine("Resultado es MENOR a 10");
                Console.WriteLine("Y el valor de a es MENOR al de b");
            }
        }
        #endregion

        #region OrOperator
        static void OrOperator()
        {
            int a = 7;
            int b = 3;
            int c = 4;

            if ( (a + b + c > 10) && (a > b) )
            {
                Console.WriteLine("Resultado es MAYOR a 10");
                Console.WriteLine("O el valor de a es MAYOR al de b");
            } 
            else
            {
                Console.WriteLine("Resultado es MENOR a 10");
                Console.WriteLine("O el valor de a es MENOR al de b");
            }
        }
        #endregion

        #region LoopWhile
        static void LoopWhile()
        {
            int contador = 0;
            while (contador < 10)
            {
            Console.WriteLine($"Hola! el contador esta en {contador}");
            contador++;
            }
        }
        #endregion

        #region LoopDoWhile
        static void LoopDoWhile()
        {
            int contador = 0;
            do
            {
            Console.WriteLine($"Hola! EL contador esta en {contador}");
            contador++;
            } while (contador < 10);
        } 
        #endregion

        #region LoopFor (Iniciador; Condición; iterador)
        static void LoopFor()
        {
            for (int index = 0; index <10; index++)
            {
                Console.WriteLine($"Hola! El Indice es {index}");
            }
        } 
        #endregion

        #region NestedLoops
        static void NestedLoops()
        {
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                Console.WriteLine($"La celda es: ({row}, {column})");
                }
            }
        }
        #endregion

        #region Exersice
        static void Exersice()
        {
            int resultado = 0;
            for (int index = 0; index < 21; index++)
            {
                int answer = index % 3;
                int divicion = index / 3;
                Console.WriteLine($"Indice: {index};  Divición: {divicion};  Resto: {answer}");

                if (answer == 0)
                {
                    resultado = resultado + index;
                    Console.WriteLine($"El resultado PARCIAL es: {resultado}");
                }
            }
            Console.WriteLine($"El resultado TOTAL es: {resultado}");
        }
        #endregion

        static void Main(string[] args)
        {
            // ExploreIf();

            // AndOperator();

            // OrOperator();

            // LoopWhile();

            // LoopDoWhile();

            // LoopFor();

            // NestedLoops();

            Exersice();
        }
    }
}
