namespace Library.Models
{
    public class UserModel
    {
        internal int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public ICollection<BookModel>? RentedBooks { get; private set; }

    }
}
