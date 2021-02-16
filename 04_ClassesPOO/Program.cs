using System;

namespace _04_ClassesPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Ale", 1000);

            Console.WriteLine($"La cuenta {account.Number} se creado para {account.Owner} con {account.Balance} de balance inicial.");

            account.MakeWithdrawal(500, DateTime.Now, "Pago alquiler del negocio");
            Console.WriteLine(account.Balance);

            account.MakeDeposit(100, DateTime.Now, "Deposito de compra art 1");
            Console.WriteLine(account.Balance);

            account.MakeDeposit(75, DateTime.Now, "Deposito de compra art 2");
            Console.WriteLine(account.Balance);
            Console.WriteLine("--------------------");

            // Test que los saldos iniciales deben ser positivos.
            try
            {
                var invalidAccount = new BankAccount("invalido", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Excepción detectada creando una cuenta con saldo negativo");
                Console.WriteLine($"El error es: {e.ToString()}");
                Console.WriteLine("--------------------");
            }

            // Test para un balance negativo.
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Intento de sacar mas que el saldo");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Excepción atrapada tratando de sacar mas que el saldo");
                Console.WriteLine($"El error es: {e.ToString()}" );
                Console.WriteLine("--------------------");
            }

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
