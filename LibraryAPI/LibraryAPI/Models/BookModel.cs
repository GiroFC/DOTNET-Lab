namespace LibraryAPI.Models
{
    public class BookModel
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public int ReleaseYear { get; private set; }
        public string Genre { get; private set; }
        public ICollection<AuthorModel> Authors { get; private set; } = new List<AuthorModel>();


        public BookModel(string title, int releaseYear, string genre)
        {
            Id = Guid.NewGuid();
            Title = title;
            ReleaseYear = releaseYear;
            Genre = genre;
        }

        public void UpdateTite(string newTitle)
        {
            if(!string.IsNullOrEmpty(newTitle))
                Title = newTitle;   
        }

        public void UpdateGenre(string newGenre)
        {
            if (!string.IsNullOrEmpty(newGenre))
                Genre = newGenre;
        }

        public void UpdateReleaseYear(int newReleaseYear)
        {
            if (newReleaseYear > 0)
                ReleaseYear = newReleaseYear;
        }

        public void AddAuthor(AuthorModel author)
        {
            if (!Authors.Contains(author))
                Authors.Add(author);
        }

        public void RemoveAuthor(AuthorModel author)
        {
            if (Authors.Contains(author))
                Authors.Remove(author);
        }
    }
}
