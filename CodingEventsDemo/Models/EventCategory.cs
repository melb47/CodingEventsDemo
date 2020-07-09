using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CodingEventsDemo.Models
{
    public class EventCategory
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Event> Events { get; set; }

        public EventCategory() { }
        public EventCategory(string name)
        {
            Name = name;
        }
    }
}
