namespace Patterns.Specification.Models
{
    public struct Movie
    {
        public string Title { get; set; }
        public long Year { get; set; }

        public Movie(string title, long year)
        {
            Title = title;
            Year = year;
        }
    }
}
