using System.IO;
public class Journal

{
    // como atributos va tener una lista de entries
    //por ejemplo    date - prompt - user entry se reflejara luego cuando lo llame en el numero 2 del menu.
    public string _myjournal = " ";
    public string _fileName= " ";
    

    public List<Entry> _entries =  new List<Entry>();


    public void Load()
    {
         //metodo load y por cada linea del archivo de texto te agregue un entrie a la lista de enttries de esta clase es decir en _entries.
         //esto va ir agregando mis respuestas a la lista interna Entry.
        //metodo por ejemplo void add entry en el cual como parametro de etrada de la funcion de lagrego un entri y ese entri que se agregue a la lista interna de my journal.
        //agregar un metodo que agregue un entry.

    






       

    }


    public void Save()
    {
        //para guardar yo tendria que abrir un archivo txt y por cada entrie que haya en la lista de entries del Journal que write en el txt en cada linea el entry que se va agregando.
        // aqui usaria el txt code.
        


    }

    public void Display()
    {
       foreach (Entry entry in _entries)
       {
        entry.Display();
       }
    }

    
   

}

