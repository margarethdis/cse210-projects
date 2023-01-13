using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        
        Console.Write("Enter number: ");
        int Number =  int.Parse(Console.ReadLine());
        

        List<int> numbers;
        numbers = new List<int>();

        numbers.Add(Number);
        Console.WriteLine(numbers.Count);


    }
}