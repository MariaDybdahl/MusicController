using MusicController.Rep;

namespace UnitTest
{
    [TestClass]
    public class MusicRepTest
    {
        private MusicRep musicRep;         
        [TestInitialize]
        public void initonce()
        {
            musicRep = new MusicRep();
        }

        


        [TestMethod]
        public void TestGetAll()
        {
          List<Music> musics=musicRep.GetAll();
          Assert.AreEqual(2,musics.Count());
          
           
        }
    }
}