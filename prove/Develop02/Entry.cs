using System;
using System.Collections.Generic;

public class Entry {
    public string _prompt {
        get;    // This gets the prompt from the PromptGenerator 
        set;    // This sets the prompt
    }

    public string _response {
        get;    // This gets the response from the user
        set;    // This sets the response from the user
    }

    public DateTime _date {
        get;    // This gets the date
        set;    // This sets the date
    }

    // This function creates a new entry
    public void WriteNewEntry() {
        PromptGenerator promptGenerator=new PromptGenerator(); // Create a new Prompt
        _prompt=promptGenerator.GenerateRandomPrompt();         // Generates a random prompt

        Console.WriteLine(_prompt); // Prints the prompt
        _response=Console.ReadLine();   // Gets the response

        _date=DateTime.Now; // Gets the date

        Journal.AddEntry(this); // Adds the entry to the journal
    }
}