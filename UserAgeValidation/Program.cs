// See https://aka.ms/new-console-template for more information


using System;

Console.WriteLine("Hello! Enter your Age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNum = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse resulr {isAgeNum}. User is {userAge} years old.");

if (isAgeNum)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    else
    {
        Console.WriteLine("You are too young my friend!");
    }
}
else
{
    Console.WriteLine("ERROR! Could not read yor age!");
}