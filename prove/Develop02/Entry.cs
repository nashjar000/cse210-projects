using System;
using System.Collections.Generic;

public class Entry {
    public string _prompt {
        get;
        set;
    }

    public string _response {
        get;
        set;
    }

    public DateTime _date {
        get;
        set;
    }

    public void WriteNewEntry() {
        PromptGenerator promptGenerator=new PromptGenerator();
        _prompt=promptGenerator.GenerateRandomPrompt();

        Console.WriteLine(_prompt);
        _response=Console.ReadLine();

        _date=DateTime.Now;

        Journal.AddEntry(this);
    }
}