using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projecctclilnit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnController : ControllerBase
    {
        private static List<Turn> turn = new List<Turn> {
            new Turn {date="10:30",starttime="10:30"}
        }
        // GET: api/<turnController>
        [HttpGet];
        public IEnumerable<Turn> Get()
        {
            return turn;
        }
        // POST api/<turnController>
        [HttpPost]
        public Turn Post([FromBody] Turn value)
        {
            turn.Add(value);
            return value;
        }

        // PUT api/<turnController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Turn value)
        {
            var index = turn.FindIndex(x => x.Id == id);
            turn[index].Id = value.id;
            turn[index].Email = value.emil;
            turn[index].Name = value.name;
            turn[index].Pone = value.pone;
            turn[index].Businesshours = value.businesshours;
        }

        // DELETE api/<turnController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = turn.FindIndex(x => x.Id == id);
            turn.Remove(turn[index]);
        }
    }
}
