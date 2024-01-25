// See https://aka.ms/new-console-template for more information
using FactoryMethodEx;

string code;
string card;
string userName;
BankFactory bankfactory = new BankFactory();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("please enter card number");
card = Console.ReadLine();
Console.WriteLine("please enter use name");
userName = Console.ReadLine();
code = card.Substring(0, 6);
IBank bank = bankfactory.GetBank(code);
if (bank == null)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Invalid card");
}
else
{
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(bank.WelcomeMessage(userName));
    }
}
Console.ReadKey();

