using System;

public class Entry
{
    public string _date = "" ;
    public string _prompt = "";
    public string _userEntry = "";
    public Prompts prompts = new Prompts();

    public Entry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();

        _prompt= prompts.RandomQuestion();
        


        

    }





}