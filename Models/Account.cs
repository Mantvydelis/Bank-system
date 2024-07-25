using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Banko_sistema.Models
{
    public class Account
    {
        public string Number { get; set; }
        public double Balance { get; set; }
        public List<Transaction> Transactions { get; set; }


        public Account(string number, double balance, List<Transaction> transactions)
        {
            Number = number;
            Balance += balance;
            Transactions = new List<Transaction>();
        }

        public void Deposit(double amount)
        {
            Transactions.Add(new Transaction(amount, "Deposit"));
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Transactions.Add(new Transaction(amount, "Withdraw"));
            Balance -= amount;
        }

    }
}
