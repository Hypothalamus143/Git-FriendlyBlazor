namespace GitFriendly.Models;

public class FileItem
{
    public int Id { get; set; }
    public string FolderName { get; set; } = string.Empty; // Named as folder_name in ERD

    // Foreign Keys
    public int FolderId { get; set; }
    public Folder Folder { get; set; } = null!;

    public int? SuggestionId { get; set; }
    public Suggestion? Suggestion { get; set; }

    // Relationships
    public ICollection<Line> Lines { get; set; } = new List<Line>();
}