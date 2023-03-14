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
    
                Prompts p = new
                Prompts();

                Console.WriteLine(p.RandomQuestion());
                string answer =
                Console.ReadLine();

                

                Console.ReadLine();


            

                

               

                

                
                
               

                

                //crear date , el prompt , y el anser o user entry //
                

                

                
            
            }
            else if(UserChoice == "2")
            {       
                Journal midiario =  new Journal();
                midiario.Display();
                Console.ReadLine();




                
              

                
            }

            //load y save ton todos metodos dentro del journal class , y hacer uno para agregar un entri a la lista de entri del journal.
            else if(UserChoice == "3")
            {   

              //proceso leer el txt en cada linea del txt deberia haber un entry , el txt seria la lista de entries del journal
                Journal midiario = new Journal();
                midiario.Load();
                Console.ReadLine();
                

            }

            else if(UserChoice == "4")
            {      
              //para guardar yo tendria que abrir un archivo txt y por cada entrie que haya en la lista de entries del Journal que write en el txt en cada linea el entry que se va agregando.
            }

            }


               

            
    }
}
