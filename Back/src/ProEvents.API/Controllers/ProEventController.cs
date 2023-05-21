using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvents.API.Data;
using ProEvents.API.Models;
namespace ProEvents.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProEventController : ControllerBase
    {   
        private readonly DataContext context;

        public ProEventController(DataContext context){
            this.context = context;
            
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return context.Events;
        }

        [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
            return context.Events.Where(Event => Event.EventId == id);
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