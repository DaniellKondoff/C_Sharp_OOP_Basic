using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    static void Main(string[] args)
    {
        BankAccount bankAccount = new BankAccount();
        bankAccount.ID = 1;
        bankAccount.Balance = 15;
        Console.WriteLine($"Account {bankAccount.ID}, balance {bankAccount.Balance}");
    }
}

