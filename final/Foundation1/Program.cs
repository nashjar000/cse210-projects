class Program
{
    static void Main(string[] args)
    {
        Videos video1 = new Videos("My First Video", "Bill Murry", 120);
        Videos video2 = new Videos("How to Learn C#", "Jim Bane", 180);
        Videos video3 = new Videos("Movie: The Movie", "Kermit the Frog", 240);

        //Comments to video:
        video1.AddComment("Jake", "I love this video");
        video1.AddComment("Bob", "This video is alright");

        video2.AddComment("Timmy", "I don't understand how this works");
        video2.AddComment("User2", "I like this video");

        video3.AddComment("Joseph", "First comment");
        video3.AddComment("UserName", "Second comment");

        List<Videos> videosList = new List<Videos> { video1, video2, video3 };

        foreach (Videos video in videosList)
        {
            Console.WriteLine($"{video.Title} by {video.Author} is {video.LengthInSeconds} seconds long and has {video.Comments.Count} comments");
            foreach (Comments comment in video.Comments)
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.Comment}");
            }
            Console.WriteLine();
        }
    }
}