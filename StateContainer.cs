public class StateContainer
{
    public static string testID {get; set;}
    public static bool hiddenButton {get; set;} = true;
    public static bool startButtonPushed {get; set;} = false;

    public static bool foundUser {get; set;} = false; 

    private string? savedFineID;

    public static Fine myFine {get; set;} = new Fine("xxxxxxxxxxxx", "place holder", 0, new DateTime(2021,12,31), false);

    public string Property
    {
        get => savedFineID ?? string.Empty;
        set
        {
            savedFineID = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}