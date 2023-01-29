namespace Library.Models;

public class BookModel
{
    internal int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public UserModel? User { get; set; }//If null it means that book is not rented.
    public bool IsAvailable => User == null;
}