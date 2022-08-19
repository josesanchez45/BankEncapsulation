using BankEncapsulation;
var account= new Bank_Account();
Console.WriteLine($"Your current balance is: ");

account.GetBalance();

Console.WriteLine();

Console.WriteLine("How much Would you like to deposit?");

var userDeposit = Double.TryParse(Console.ReadLine(), out var userMoney);

account.Deposit(userMoney);

Console.WriteLine("Your new balance is: ");

account.GetBalance();

