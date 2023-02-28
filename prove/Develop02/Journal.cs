public class Journal
{
    // como atributos va tener una lista de entries
    //por ejemplo    date - prompt - user entry se reflejara luego cuando lo llame en el numero 2 del menu.
    public string _myjournal = " ";

    public List<Entry> _entries =  new List<Entry>();

    public void Display()
    {
       foreach (Entry entry in _entries)
       {
        entry.Display();
       }
    }

}

