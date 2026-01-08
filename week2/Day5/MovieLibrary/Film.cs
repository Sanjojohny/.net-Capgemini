namespace MovieLibrary
{
    public class Film : IFilm
    {
        public string Title { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public int Year { get; set; }
    }
}
