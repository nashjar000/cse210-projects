using System;
using System.Collections.Generic;

// other ideas from class: I can add a scripture .txt file this can read from, randomize the scripture

public class Program {
    static void Main(string[] args) {
        // Scripture references go in a text file:
        string[] lines=File.ReadAllLines("scriptures.txt"); // Read the text file
        List<Scripture>scriptures=new List<Scripture>(); // Create a list of scriptures

        foreach (string line in lines) // Loop through the text file

            {
            string[] parts=line.Split('/'); // Split the text into parts where ever there's a /
            if (parts.Length==2) // Check if the parts array has two elements

                {
                scriptures.Add(new Scripture(parts[0], parts[1])); // Add the scripture to the list of scriptures
            }
        }

        // Loop until user chooses to quit
        // Something I could've done differently here: switch statement....
        while (true) {
            Console.Clear(); // Clear the console before displaying the next selection
            Console.WriteLine("Choose a scripture to memorize:"); // Display the list of scriptures
            for (int i=0; i < scriptures.Count; i++) // Loop through the list of scriptures

                {
                Console.WriteLine($"{i + 1}. {scriptures[i]._reference}"); // Display the list of scriptures
            }

            Console.WriteLine("0. Quit"); // quit option

            string input=Console.ReadLine(); // Get the user's choice
            if (input=="0") // Check if the user chose to quit

                {
                break; // Break out of the loop
            }

            if (int.TryParse(input, out int choice) && choice >=1 && choice <=scriptures.Count) // Check if the user's choice is valid

                {
                Scripture selectedScripture=scriptures[choice - 1]; // Get the selected scripture

                while (true) // Loop until user chooses to quit

                    {
                    Console.Clear(); // Clear the console before displaying the next selection
                    Console.WriteLine($"Reference: {selectedScripture._reference}"); // Display the selected scripture reference
                    Console.WriteLine(selectedScripture._text); // Display the text of the selected scripture 

                    Console.Write("Press Enter to hide a word, type 'quit' to choose another scripture: "); // Prompt the user to hide a word
                    string subInput=Console.ReadLine(); // Get the user's input
                    if (subInput.ToLower()=="quit") // Check if the user chose to quit

                        {
                        break; // Break out of the loop if the user chose to quit
                    }

                    selectedScripture.HideRandomWord(); // Hide a random word in the selected scripture
                }
            }

            // Check if the user's choice is valid
            else {
                Console.WriteLine("Invalid choice. Please try again."); // Display an error message
            }
        }
    }
}