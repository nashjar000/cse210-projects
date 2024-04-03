/*
Video that has the responsibility to track 
the title, author, and length (in seconds) 
of the video. Each video also has responsibility 
to store a list of comments, and should have a 
method to return the number of comments.
*/
class Videos
{
    public string Title { get; }
    public string Author { get; }
    public int LengthInSeconds { get; }
    public List<Comments> Comments { get; }

    public Videos(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comments>();
    }

    public void AddComment(string commenterName, string comment)
    {
        Comments.Add(new Comments(commenterName, comment));
    }
}