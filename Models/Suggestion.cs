namespace GitFriendly.Models;

public class Suggestion
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

    // Self-Referencing Suggestion Hierarchy
    public int? ParentSuggestionId { get; set; }
    public Suggestion? ParentSuggestion { get; set; }

    // Relationships
    public ICollection<Suggestion> SubSuggestions { get; set; } = new List<Suggestion>();
    public ICollection<Folder> Folders { get; set; } = new List<Folder>();
    public ICollection<FileItem> Files { get; set; } = new List<FileItem>();
    public ICollection<Line> Lines { get; set; } = new List<Line>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}