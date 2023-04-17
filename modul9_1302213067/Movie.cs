namespace modul9_1302213067
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public List<string> Stars { get; set; }

        public Movie(string title, string director, string description, List<string> Stars)
        {
            Title = title;
            Director = director;
            Description = description;
            this.Stars = Stars;
        }
    }
}
