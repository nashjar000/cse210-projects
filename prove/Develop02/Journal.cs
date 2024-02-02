using System;
using System.Globalization;

public class Journal {
    public static List<Entry>JournalEntries=new List<Entry>();

    public static void AddEntry(Entry entry) {
        JournalEntries.Add(entry);
    }

    public static void DisplayEntries() {
        foreach (var entry in JournalEntries) {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Response: {entry._response}");
            Console.WriteLine();
        }
    }

    // Saving files:
    public static void SaveToFile(string fileName) {
        try {
            using (StreamWriter writer=new StreamWriter(fileName)) {
                foreach (var entry in JournalEntries) {
                    writer.WriteLine($"Date: {entry._date}");
                    writer.WriteLine($"Prompt: {entry._prompt}");
                    writer.WriteLine($"Response: {entry._response}");
                    writer.WriteLine();
                }
            }

            Console.WriteLine("Journal saved to file successfully!");
        }

        catch (Exception ex) {
            Console.WriteLine($"An error occurred while saving the journal: {ex.Message}");
        }
    }

    // Loading Files:
    public static void LoadFromFile(string fileName) {
        try {
            List<Entry>newJournalEntries=new List<Entry>();

            using (StreamReader reader=new StreamReader(fileName)) {
                while ( !reader.EndOfStream) {
                    Entry entry=new Entry();

                    // Parse the date with the specified format
                    entry._date=DateTime.ParseExact(reader.ReadLine().Split(':')[1].Trim(), "M/d/yyyy H", CultureInfo.InvariantCulture);

                    entry._prompt=reader.ReadLine().Split(':')[1].Trim();
                    entry._response=reader.ReadLine().Split(':')[1].Trim();
                    reader.ReadLine(); // Read the empty line
                    newJournalEntries.Add(entry);
                }
            }

            JournalEntries=newJournalEntries; // Replace the current journal entries with the loaded entries
            Console.WriteLine("Journal loaded from file successfully!");
        }

        catch (Exception ex) {
            Console.WriteLine($"An error occurred while loading the journal: {ex.Message}");
        }
    }
}