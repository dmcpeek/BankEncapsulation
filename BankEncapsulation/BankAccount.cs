using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class BankAccount
{
    public BankAccount() //Constructor
    {
    }

    private double _balance = 0;
    public void Deposit(double amount)
    {
        _balance += amount;
    }
    public double GetBalance()
    {
        return _balance;
    } 
}
