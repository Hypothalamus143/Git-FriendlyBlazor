namespace GitFriendly.Models;

public class Repository
{
    public int Id { get; set; }
    public string RepositoryTitle { get; set; } = string.Empty;

    // Foreign Keys
    public int UserId { get; set; }
    public User User { get; set; } = null!;

    // Relationships
    public ICollection<Folder> Folders { get; set; } = new List<Folder>();
}