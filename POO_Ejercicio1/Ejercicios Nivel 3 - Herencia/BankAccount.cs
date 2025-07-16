using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

public class BankAccount
{
    protected double balance;

    public BankAccount(double balance)
    {
        this.balance = balance;
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Your balance is {balance.ToString("0.000")}");
    }
}

public class SavingsAccount : BankAccount
{
    public SavingsAccount(double balance) : base(balance) { }

    public void Interest()
    {
        Console.WriteLine($"Generate a interest in your balance ");
    }
}