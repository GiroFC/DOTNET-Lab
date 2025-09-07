namespace LibraryAPI.DTOs.Books
{
    public class BookCreateDto
    {
        public string Title { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public string Genre { get; set; } = string.Empty;
        public List<Guid> AuthorIds { get; set; } = new List<Guid>();
    }
}
