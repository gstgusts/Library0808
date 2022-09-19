namespace Library.Data
{
    public class Book
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public Author Author { get; set; }

        public GenreEnum Genre { get; set; }

        public string[] Keywords { get; set; }

        public byte Rating { get; set; }

    }
}