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
                Prompts p = new
                Prompts();

                Console.WriteLine(p.RandomQuestion());
                string answer = 
                Console.ReadLine();
            
            }
            else if(UserChoice == "2")
            {       
                //muestra la fecha que se guardo - prompt y la respuesta
               Journal j =  new
               Journal();

               Console.Write(j._myjournal);
               string respuestas = 
               Console.ReadLine();

               
              
               
              
               
               

               
        
                
            }
            else if(UserChoice == "3")
            {         
              


            }

            else if(UserChoice == "4")
            {      
              
            }

            }


               

            
    }
}
