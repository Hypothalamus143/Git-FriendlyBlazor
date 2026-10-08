namespace GitFriendly.Models;

public class Line
{
    public int Id { get; set; }
    public int LineNumber { get; set; }

    // Foreign Keys
    public int FileItemId { get; set; }
    public FileItem FileItem { get; set; } = null!;

    public int? SuggestionId { get; set; }
    public Suggestion? Suggestion { get; set; }
}