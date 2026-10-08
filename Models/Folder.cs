namespace GitFriendly.Models;

public class Folder
{
    public int Id { get; set; }
    public string FolderName { get; set; } = string.Empty;

    // Foreign Keys & Self-Referencing Parent
    public int RepositoryId { get; set; }
    public Repository Repository { get; set; } = null!;

    public int? ParentFolderId { get; set; }
    public Folder? ParentFolder { get; set; }

    public int? SuggestionId { get; set; }
    public Suggestion? Suggestion { get; set; }

    // Relationships
    public ICollection<Folder> SubFolders { get; set; } = new List<Folder>();
    public ICollection<FileItem> Files { get; set; } = new List<FileItem>();
}