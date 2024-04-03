class Videos
/*
Video that has the responsibility to track 
the title, author, and length (in seconds) 
of the video. Each video also has responsibility 
to store a list of comments, and should have a 
method to return the number of comments.
*/
{
    private string _author { get; set; }
    private string _title { get; set; }
    public List<Comments> Comments { get; set; }

    // Constructor
    public Videos(string author, string title, int lengthInSeconds)
    {
        _author = author;
        _title = title;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comments>();
    }

    public int LengthInSeconds { get; set; }

    public void AddComment(string commenterName, string comment)
    {
        Comments.Add(new Comments(commenterName, comment));
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}