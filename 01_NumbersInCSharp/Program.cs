using System;


namespace _01_NumbersInCSharp
{
    class Program
    {
        #region WorkingWithIntegers
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;

            // Suma
            int c = a + b;
            Console.WriteLine($"La suma de {a} + {b} es {c}");

            // Resta
            c = a - b;
            Console.WriteLine($"La resta de {a} - {b} es {c}");

            // Multiplicación
            c = a * b;
            Console.WriteLine($"La multiplicación de {a} - {b} es {c}");

            // División
            c = a / b;
            Console.WriteLine($"La división de {a} - {b} es {c}");
        }
        #endregion

        #region OrderPrecedence
        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;

            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);
        }
        #endregion 

        #region TestLimits
        static void TestLimits()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"Resto: {d}");
            Console.WriteLine($"Modulo: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"Rango de entero es de: {min} a {max}");

            int desdoblamiento = max + 3;
            Console.WriteLine($"Ejemplo de desdoblamiento: {desdoblamiento}");

            float floatTercio = 1 / 3;
            Console.WriteLine($"Un tercio es: {floatTercio}");

            double tercio = 1.0 / 3.0;
            Console.WriteLine($"Un tercio en double es: {tercio}");

            decimal decimalTercio = 1.0M / 3.0M;
            Console.WriteLine($"Un tercio en decimal es: {decimalTercio}");
        }
        #endregion

        #region CircleArea
        static void CircleArea()
        {
            double radio = 2.5;
            double pi = Math.PI;

            double area = pi * (radio * radio);
            Console.WriteLine($"El area del circulo es: {area} cm^2.");
        }
        #endregion

        static void Main(string[] args)
        {
            // WorkingWithIntegers();

            // OrderPrecedence();

            // TestLimits();

            // CircleArea();

        }
    }
}