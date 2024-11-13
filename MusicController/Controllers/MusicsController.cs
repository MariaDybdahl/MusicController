using Microsoft.AspNetCore.Mvc;
using MusicController.Rep;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicsController : ControllerBase
    {
        private readonly MusicRep MusicRep;
        public MusicsController(MusicRep musicRep) 
        { 
            MusicRep = musicRep;
        }
        // GET: api/<MusicsController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public ActionResult<List<Music>> Get()
        {
            List<Music> MusicList = MusicRep.GetAll();
            if (MusicList == null) 
            {
                return NotFound("Ingen ting i listen");
            }
            return Ok(MusicList);
        }

        // GET api/<MusicsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MusicsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MusicsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MusicsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
