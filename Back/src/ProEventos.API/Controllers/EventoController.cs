using Microsoft.AspNetCore.Mvc;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController() 
        {     
        }

        [HttpGet]
        public string Get() 
        {
           return "value";
        }

        [HttpPost]
        public string Post() 
        {
           return "exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id) 
        {
           return $"exemplo de Put com id = {id}";
        }

         [HttpDelete("{id}")]
        public string Delete(int id) 
        {
           return $"exemplo de Delete com id = {id}";
        }

    }
}
