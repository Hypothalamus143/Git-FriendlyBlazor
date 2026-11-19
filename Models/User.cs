namespace GitFriendly.Models;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("user")]
public class User : BaseModel

{
    [PrimaryKey("id", false)]
    public int Id { get; set; }

    [Column("username")]
    public string Username { get; set; } = string.Empty;

    [Column("password")]
    public string Password { get; set; } = string.Empty;

    // Relationships
    // public ICollection<Repository> Repositories { get; set; } = new List<Repository>();
    // public ICollection<Suggestion> Suggestions { get; set; } = new List<Suggestion>();
    // public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}