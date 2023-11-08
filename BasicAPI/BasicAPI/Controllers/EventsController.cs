using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private List<Event> events = new List<Event> { new Event { Id = 1, Title = "default event" } };
        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Event> GetAllEvents()
        {
            return events;
        }

        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Event> GetAllEvents(int id)
        {
            return events;
        }

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Event newEvent)
        {
            events.Add(new Event { Id = 2, Title = newEvent.Title, Description = newEvent.Description });
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event newEvent)
        {
            //TODO
            //find event by id
            //udpate event properties
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var eve = events.Find(e => e.Id == id);
            events.Remove(eve);
        }
    }
}
