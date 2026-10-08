namespace GitFriendly.Models;

public class Comment
{
    public int Id { get; set; }
    public string RepositoryTitle { get; set; } = string.Empty;
    public string CommitMessage { get; set; } = string.Empty;
    public int Status { get; set; }
    public int Upvote { get; set; }
    public int Downvote { get; set; }

    // Foreign Keys
    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public int SuggestionId { get; set; }
    public Suggestion Suggestion { get; set; } = null!;
}