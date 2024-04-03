/*
 A comment should be defined by the Comment class which has 
 the responsibility for tracking both the name of the person 
 who made the comment and the text of the comment.
*/
public class Comments
{
    public string CommenterName { get; }
    public string Comment { get; }

    public Comments(string commenterName, string comment)
    {
        CommenterName = commenterName;
        Comment = comment;
    }
}