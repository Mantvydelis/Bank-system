

using Banko_sistema.Models;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ManoPrograma
{
    public class BankoSistema
    {
        public static void Main()
        {
            Customer petras = new Customer("Petras Petraitis");
            Customer kestas = new Customer("Kestas Kestutaitis");

            Account account1 = new Account("LT56555555", 300.00);
            Account account2 = new Account("LT57265696", 854.00);
            Account account3 = new Account("LT66666666", 632.00);
            Account account4 = new Account("LT99336666", 489.00);

           petras.AddAccount(account1);
           petras.AddAccount(account2);
            kestas.AddAccount(account3);
            kestas.AddAccount(account4);

            account1.Withdraw(400);
            account2.Deposit(1000);
            account3.Withdraw(250);
            account4.Deposit(5000);

            Console.WriteLine(petras.GetTotalBalance());
            Console.WriteLine(kestas.GetTotalBalance());

        }





    }



}
