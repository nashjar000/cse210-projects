using System;
using System.Collections.Generic;

// other ideas from class: I can add a scripture .txt file this can read from, randomize the scripture

public class Program
{
    static void Main(string[] args)
    {
    // Scripture references go here: 
    // Scripture reference = new Scripture(reference, text);
        Scripture john316 = new Scripture(
            "John 3:16", 
            "For God so loved the world, that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
        );

        Scripture ether1227 = new Scripture(
            "Ether 12:27",
            "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."
        );

        // Note: Still need to figure out how to split up the verse:
        Scripture alma71113 = new Scripture(
            "Alma 7:11-13",
            "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities."
        );
        
        // Create a list of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            john316,
            ether1227,
            alma71113
        };

    // Loop until user chooses to quit
    // Something I could've done differently here: switch statement....
        while (true)
        {
            Console.Clear();    // Clear the console before displaying the next selection
            Console.WriteLine("Choose a scripture to memorize:");   // Display the list of scriptures
            for (int i = 0; i < scriptures.Count; i++)  // Loop through the list of scriptures
            {
                Console.WriteLine($"{i + 1}. {scriptures[i]._reference}");  // Display the list of scriptures
            }
            Console.WriteLine("0. Quit");   // quit option

            string input = Console.ReadLine();  // Get the user's choice
            if (input == "0")   // Check if the user chose to quit
            {
                break;  // Break out of the loop
            }

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= scriptures.Count)   // Check if the user's choice is valid
            {
                Scripture selectedScripture = scriptures[choice - 1];   // Get the selected scripture

                while (true)    // Loop until user chooses to quit
                {
                    Console.Clear();    // Clear the console before displaying the next selection
                    Console.WriteLine($"Reference: {selectedScripture._reference}");    // Display the selected scripture reference
                    Console.WriteLine(selectedScripture._text); // Display the text of the selected scripture 

                    Console.Write("Press Enter to hide a word, type 'quit' to choose another scripture: "); // Prompt the user to hide a word
                    string subInput = Console.ReadLine();   // Get the user's input
                    if (subInput.ToLower() == "quit") // Check if the user chose to quit
                    {
                        break;  // Break out of the loop if the user chose to quit
                    }

                    selectedScripture.HideRandomWord(); // Hide a random word in the selected scripture
                }
            }

            // Check if the user's choice is valid
            else
            {
                Console.WriteLine("Invalid choice. Please try again."); // Display an error message
            }
        }
    }
}