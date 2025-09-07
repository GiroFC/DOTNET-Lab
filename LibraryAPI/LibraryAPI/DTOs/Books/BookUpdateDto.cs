namespace LibraryAPI.DTOs.Books
{
    public class BookUpdateDto
    {
        public string? Title { get; set; }
        public int? ReleaseYear { get; set; }
        public string? Genre { get; set; }
        public List<Guid>? AuthorIds { get; set; }
    }
}
