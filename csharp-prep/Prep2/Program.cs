using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter your percentage: ");
        string percentageFromUser = Console.ReadLine();
        int number = int.Parse(percentageFromUser);

        string letter = " ";

        if ( number >= 90)
        {
           letter = "A";
        }
        else if ( number >= 80 )
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is : {letter}");








    }
}

//A >= 90
//B >= 80//
//C >= 70
//D >= 60//
//F < 60
//Assignment