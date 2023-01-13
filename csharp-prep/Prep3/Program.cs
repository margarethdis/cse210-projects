using System;

class GuessMyNumber
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        Console.WriteLine("");
        int Magic =  int.Parse(Console.ReadLine());

        Console.Write("What is your guess? ");
        int adivina = int.Parse(Console.ReadLine());

    
    
    //add loop
        if (Magic > adivina )
        {
            Console.WriteLine("HIGHER");
        
        }
        else if (Magic < adivina)
        {
            Console.WriteLine("LOWER");
        }
        else
        {
            Console.WriteLine("Your guessed it");
        }
    }
}