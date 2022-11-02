// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Text.RegularExpressions;

Console.WriteLine("Hello! Enter your full name:");

string userFullName = Console.ReadLine();

Console.WriteLine("Enter yor Gender: (m/f)");

char userGender = Char.Parse(Console.ReadLine());

if (userGender == 'm')
{
    Console.WriteLine($"Welcome Mr. {userFullName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome Ms. {userFullName}!");
}
else
{
    Console.WriteLine($"Welcome stranger {userFullName}!");
}





