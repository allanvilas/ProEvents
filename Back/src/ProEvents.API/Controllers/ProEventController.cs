using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvents.API.Models;
namespace ProEvents.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProEventController : ControllerBase
    {   
        public IEnumerable<Event> _Event =  new Event[] {
            new Event(){
                EventId = 1,
                Local  = "Limeira",
                DateEvent = DateTime.Now.AddDays(2).ToString(),
                QtdParticipants = 250,
                Theme  = "Programming",
                ImageUrl = "https://cd.com",
                Lot =  "First Lot"
            },
            new Event(){
                EventId = 2,
                Local  = "Americana",
                DateEvent = DateTime.Now.AddDays(2).ToString(),
                QtdParticipants = 250,
                Theme  = "Programming",
                ImageUrl = "https://cd.com",
                Lot =  "First Lot"
            }
        };

        public ProEventController(){
            
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _Event;
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de delete com id = {id}";
        }
    }
}   