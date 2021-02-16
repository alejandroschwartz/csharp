using System;
using System.Collections.Generic;

namespace _04_ClassesPOO
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;  // "private" significa que solo es accesible en esta clase BankAccount


        // PROPIEDADES de la clase (Number, Owner, Balance)   
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;

                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }


        // CONSTRUCTOR de la clase. Crea objeto con "new BankAccount"
        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        private List<Transaction> allTransactions = new List<Transaction>();


        // METODOS de la clase (MakeAccount, MakeWithDrawal)
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "El monto del depósito debe ser positivo");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "La cantidad de retiro debe ser positiva");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("No hay fondos suficientes para este retiro");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Fecha\t\tMonto\tBalance\tDetalles");
            Console.WriteLine("Reporteador de operaciones realizadas");

            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }
    }
}
