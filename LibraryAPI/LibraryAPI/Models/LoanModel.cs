namespace LibraryAPI.Models
{
    public class LoanModel
    {
        public Guid Id { get; private set; }

        public Guid UserId { get; private set; }
        public UserModel? User { get; private set; }

        public Guid BookId { get; private set; }
        public BookModel? Book { get; private set; }

        public DateTime LoanAt { get; private set; } = DateTime.Now;
        public DateTime? ReturnDate { get; private set; }

        public LoanModel(UserModel user, BookModel book)
        {
            Id = Guid.NewGuid();
            User = user;
            UserId = user.Id;
            Book = book;
            BookId = book.Id;
        }

        public void ReturnBook()
        {
            ReturnDate = DateTime.Now;
        }

    }
}
