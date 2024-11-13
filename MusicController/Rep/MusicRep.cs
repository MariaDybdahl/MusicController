namespace MusicController.Rep
{
    public class MusicRep
    {
        private int nextid = 1;
        public List<Music> _music;
        
        public MusicRep()
        {
            _music = new List<Music>()
            {
                new Music{id=nextid++,Artist="AL",Duration=400, PublicationYear="2002",Title="Bad" },
                new Music{id=nextid++,Artist="GJ",Duration=100, PublicationYear="1930",Title="Julie" }

            };
        }

        public Music Add(Music music)
        {
            music.id = nextid++;
            _music.Add(music);
            return music;

        }

        public List<Music> GetAll()
        {
            return new List<Music>(_music);
        }
    }
}
