using System;

public class PromptGenerator {
    // Worked on this in class...
    public string[] _promptGenerator=new string[] { //Prompts to use...I can add more if I want to :)
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        // more sample prompts:
        "What is one thing that I am grateful for today?",
        "What was one thing that made me laugh today?",
        "What did I learn about myself today?",
        "What's a new skill I learned today?",
        "What's one thing I accomplished today that I am proud of?",
        "What goal do I have for tomorrow?",
        "What was I inspired by today?",
        "What's something I learned from someone today?",
        "How did I show kindness to someone today?",
        "What's one thing that happened today that I would want to do again?",
    }

    ;
    public string _randomPrompt=""; // random prompt is put in an empty string

    public string GenerateRandomPrompt() { // This generates a random prompt
        Random random=new Random(); // Create a new random prompt from the list of prompts
        int index=random.Next(_promptGenerator.Length); // Get a random index from the list
        return _randomPrompt=_promptGenerator[index];   // Return the random prompt
    }

}