namespace GitFriendly.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    // Relationships
    public ICollection<Repository> Repositories { get; set; } = new List<Repository>();
    public ICollection<Suggestion> Suggestions { get; set; } = new List<Suggestion>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}