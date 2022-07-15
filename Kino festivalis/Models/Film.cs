namespace Kino_festivalis.Models
{
    public class Film
    {
        private FilmContext context;

        public int FilmId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ReleaseYear { get; set; }

        public int Length { get; set; }

        public string Rating { get; set; }

        
    }
}
