namespace LibraryAPI.DTOs.Books
{
    public class BookResponseDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public string Genre { get; set; } = string.Empty;
        public List<string> Authors { get; set; } = new();
    }
}
