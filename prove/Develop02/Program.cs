using System;

class Program {
    static void Main(string[] args) {
        Journal journal=new Journal();
        string userChoice="1";

        while (userChoice !="5") {
            // Display welcome message & menu options
            Console.WriteLine("Welcome to the journal program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");

            userChoice=Console.ReadLine();
            // Display user options that they can choose from

            Entry entry=new Entry();

            switch (userChoice) {
                case "1":
                    Console.WriteLine("Write");
                    Entry newEntry=new Entry();
                newEntry.WriteNewEntry();
                break;
                case "2":
                    Console.WriteLine("Display");
                    Journal.DisplayEntries();
                break;
                case "3":
                    Console.WriteLine("Load");
                    Console.WriteLine("Enter the file name to load from: ");
                    string loadFileName=Console.ReadLine();
                    Journal.LoadFromFile(loadFileName);
                break;
                case "4":
                    Console.WriteLine("Save");
                    Console.WriteLine("Enter the file name: ");
                    string fileName=Console.ReadLine();
                    Journal.SaveToFile(fileName);
                break;
                case "5":
                    Console.WriteLine("Goodbye!");
                break;
                default:
                    Console.WriteLine("Please enter a number from 1-5.");
                break;
            }
        }
    }
}

// Personal note: I could have done this a bit differently if I wanted to. From class, we added some more lines of code to this file to save the entries etc.
// What I did instead was use the Journal class to save some of these things then I called some of the functions in the case statements.