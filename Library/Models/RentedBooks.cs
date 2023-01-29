namespace Library.Models
{
    //Temporary unused
    public class RentedBooks
    {
        public int RentalId { get; set; }
        public int BookId { get; set; }
        public BookModel Book { get; set; }
        public int UserId { get; set; }
        public UserModel User { get; set; }
        public DateTime RentalStartDate { get; set; }
    }
}
