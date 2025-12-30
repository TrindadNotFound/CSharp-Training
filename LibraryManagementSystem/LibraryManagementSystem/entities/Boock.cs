namespace LibraryManagementSystem.entities;

public class Boock
{
    private string _title;
    private string _author;
    private bool _isBorrowed;
    
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsBorrowed { get; private set; }

    public Boock(string title, string author)
    {
        Title = title;
        Author = author;
        IsBorrowed = false;
    }

    public void MarkAsBorrowed() => IsBorrowed = true;
}