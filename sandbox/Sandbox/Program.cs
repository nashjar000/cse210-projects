using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        // for (int i = 5; i > 0; i--)
        // {
        //     Console.Write(i);
        //     Thread.Sleep(1000); // Pause for 1 second
        //     Console.Write("\b \b"); // Erase the previous character
        // }

        // for (int i=5; i>0; i--)
        // {
        //     Console.WriteLine(".");
        //     Thread.Sleep(1000); // Pause for 1 second
        // }

        // |/-\|\/-\|

        List<string> animaationStrings = new List<string>();
        animaationStrings.Add("|");
        animaationStrings.Add("/");
        animaationStrings.Add("-");
        animaationStrings.Add("\\");
        animaationStrings.Add("|");
        animaationStrings.Add("/");
        animaationStrings.Add("-");
        animaationStrings.Add("\\");
        animaationStrings.Add("|");

        // foreach (string s in animaationStrings)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(1000); // Pause for 1 second
        //     Console.Write("\b \b"); // Erase the previous character
        // }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animaationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b"); // Erase the previous character
            
            i++;

            if(i >= animaationStrings.Count)
            {
                i = 0;
            }
        }

        Console.WriteLine("Done");
    }
}