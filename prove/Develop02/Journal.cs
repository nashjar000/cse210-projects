using System;
using System.Globalization;

public class Journal {
    // New journal entry for user to add
    public static List<Entry>JournalEntries=new List<Entry>();

    // adds a new journal entry
    public static void AddEntry(Entry entry) {
        JournalEntries.Add(entry);
    }

    // function to display entries
    public static void DisplayEntries() {
        foreach (var entry in JournalEntries) { // For every entry...
            Console.WriteLine($"Date: {entry._date}");  // Display the date
            Console.WriteLine($"Prompt: {entry._prompt}");  // Display the prompt
            Console.WriteLine($"Response: {entry._response}"); // Display the response from the user
            Console.WriteLine();    // Add a blank line
        }
    }

    // Saving files:
    public static void SaveToFile(string fileName) {
        try {
            using (StreamWriter writer=new StreamWriter(fileName)) {    // Open the file
                foreach (var entry in JournalEntries) { // For every entry...
                    writer.WriteLine($"Date: {entry._date}");   // Write the date
                    writer.WriteLine($"Prompt: {entry._prompt}");   // Write the prompt
                    writer.WriteLine($"Response: {entry._response}");   // Write the response
                    writer.WriteLine(); // Write an empty line (because it looks nice)
                }
            }

            Console.WriteLine("Journal saved to file successfully!"); // Tell the user that the file was saved
        }

        catch (Exception ex) { // This checks if there was an error
            Console.WriteLine($"An error occurred while saving the journal: {ex.Message}"); // If there was an error, tell the user... the ex.Message string Exception.Message { get; } Gets a message that describes the current exception. Then, it returns: The error message that explains the reason for the exception, or an empty string ("")
        }
    }

    // Loading Files:
    public static void LoadFromFile(string fileName) {  // This loads the file
        try {
            List<Entry>newJournalEntries=new List<Entry>(); // Create a new list of entries

            using (StreamReader reader=new StreamReader(fileName)) {    // Open the file
                while ( !reader.EndOfStream) {  // While we haven't reached the end of the file yet...
                    Entry entry=new Entry();    // Create a new entry

                    // Parse the date with the specified format
                    entry._date=DateTime.ParseExact(reader.ReadLine().Split(':')[1].Trim(), "M/d/yyyy H", CultureInfo.InvariantCulture);

                    entry._prompt=reader.ReadLine().Split(':')[1].Trim(); // Read the prompt
                    entry._response=reader.ReadLine().Split(':')[1].Trim(); // Read the response
                    reader.ReadLine(); // Read the empty line
                    newJournalEntries.Add(entry); // Add the entry to the list
                }
            }

            JournalEntries=newJournalEntries; // Replace the current journal entries with the loaded entries
            Console.WriteLine("Journal loaded from file successfully!"); // Tell the user that the file was loaded
        }

        catch (Exception ex) { // This checks if there was an error
            Console.WriteLine($"An error occurred while loading the journal: {ex.Message}"); //Tells the user that there was an error (see line 39 for more details)
        }
    }
}