using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banko_sistema.Models
{
    public class Transaction
    {
        public double Amount { get; set; }
        public string Type { get; set; }

        public Transaction(double amount, string type)
        {
            Amount = amount;
            Type = type;
        }
    }



}
