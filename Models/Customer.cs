using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Banko_sistema.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public List<Account> Accounts { get; set; }

        public Customer(string name)
        {
            Name = name;
            Accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        public double GetTotalBalance()
        {
            double totalBalance = 0;
            foreach (Account account in Accounts)
            {
                totalBalance += account.Balance;
            }
            return totalBalance;
        }
    }
}
