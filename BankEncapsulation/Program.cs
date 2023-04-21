//using C36EncapsulationDemo;

using System.ComponentModel;
using System.Security.Principal;

var account = new BankAccount();

account.Deposit(0);

Console.WriteLine("How much would you like to deposit: ");
var userInput = double.Parse(Console.ReadLine());
account.Deposit(userInput);

Console.WriteLine($"Your balance is $ {account.GetBalance()}");
