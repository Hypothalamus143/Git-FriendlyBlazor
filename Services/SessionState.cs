namespace GitFriendly.Services;
using GitFriendly.Models;
using GitFriendly.Shared;
public class SessionState
{
    public User? currentUser { get; set; }

    // public event Action? OnChange;

    // public void SetUserName(string? name)
    // {
    //     CurrentUserName = name;
    //     NotifyStateChanged();
    // }

    // private void NotifyStateChanged() => OnChange?.Invoke();
}