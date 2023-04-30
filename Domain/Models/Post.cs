namespace Domain.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int VoteAmount { get; set; }
    public DateTime CreatedAt { get; set; }
    public Post(string title, string description, int voteAmount, DateTime createdAt)
    {
        Title = title;
        Description = description;
        VoteAmount = voteAmount;
        CreatedAt = createdAt;
    }

    public Post()
    {

    }
}
