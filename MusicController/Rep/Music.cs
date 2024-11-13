namespace MusicController.Rep
{
    public class Music
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public string PublicationYear { get; set; }

        public Music(int id, string title, string artist, int duration, string publicationYear)
        {
            this.id = id;
            Title = title;
            Artist = artist;
            Duration = duration;
            PublicationYear = publicationYear;
        }

        public Music()
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(id)}={id.ToString()}, {nameof(Title)}={Title}, {nameof(Artist)}={Artist}, {nameof(Duration)}={Duration.ToString()}, {nameof(PublicationYear)}={PublicationYear}}}";
        }
    }
}
