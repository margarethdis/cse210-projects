using System;

class Program
{
    static void Main(string[] args)
    {
        Journal message = new Journal();
        string UserChoice = " ";
        while(UserChoice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program! ");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine(" 1.Write");
            Console.WriteLine(" 2.Display ");
            Console.WriteLine(" 3.Load ");
            Console.WriteLine(" 4.Save ");
            Console.WriteLine(" 5.Quit ");
            Console.WriteLine("What would you like to do?");
            
            UserChoice = Console.ReadLine();
                
            if(UserChoice == "1")
            {    
                //aqui te muestra un prompt
             
            
            }
            else if(UserChoice == "2")
            {       
                //aqui despliega otra vez el menu  
                
            }
            else if(UserChoice == "3")
            {         
                //aqui lo guarda
            } 
            else if(UserChoice == "4")
            {         
                //aqui termina el programa

            }

            }


               

            
    }
}
