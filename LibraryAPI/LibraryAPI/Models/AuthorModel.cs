namespace LibraryAPI.Models
{
    public class AuthorModel
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public ICollection<BookModel> Books { get; private set; } = new List<BookModel>();

        public AuthorModel(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
        public void UpdateName(string newName)
        {
            if (!string.IsNullOrEmpty(newName))
                Name = newName;
        }
    }
}
