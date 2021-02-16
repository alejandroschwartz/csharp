using System;

namespace _04_ClassesPOO
{
    public class Transaction
    {
        // PROPIEDADES
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }


        // CONSTRUCTOR
        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }



    }
}