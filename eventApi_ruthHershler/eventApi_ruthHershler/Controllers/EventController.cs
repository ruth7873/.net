using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eventApi_ruthHershler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private static List<Event> list = new List<Event> { new Event() {Id=0,
            Start = new DateTime(2023,9,7) }};
        private static int id = 1;
        // GET: api/<EventController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return list;
        }       

        // POST api/<EventController>
        [HttpPost]
        public void Post([FromBody] Event newEvent)
        {
            list.Add(new Event() { Id = id++, Title = newEvent.Title, Start = newEvent.Start, End = newEvent.Start });
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event newEvent)
        {
            Event e=list.Find(e=>e.Id==id);
            Event e1 = new Event(id, newEvent.Title, newEvent.Start, e.End);
            list.Remove(e);
            list.Add(e1);
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           var l= list.Find(e=>e.Id==id);
            list.Remove(l);
        }
    }
}
