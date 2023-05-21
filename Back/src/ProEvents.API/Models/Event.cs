using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEvents.API.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Local { get; set; }
        public string DateEvent { get; set; }
        public int QtdParticipants {get; set;}
        public string Theme { get; set; }
        public string ImageUrl { get; set; }
        public string Lot { get; set; }

    }
}