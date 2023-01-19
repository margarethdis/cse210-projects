using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();


        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        
        int userNumber = -1;
        while (userNumber !=0)
        {
            Console.Write("Enter number:  (if you have finished enter 0) ");


            string answer = Console.ReadLine();
            userNumber =  int.Parse(answer);

            if (userNumber !=0)
            {
                numbers.Add(userNumber);
            }

            
        }

        int sum = 0;
        foreach (int Numbers in numbers )
        {
            sum += Numbers;
        }

        Console.WriteLine($"The sum is: {sum}");

    

    
     



    }
}