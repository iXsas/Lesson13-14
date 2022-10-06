using Lesson13_14.Models;
using Lesson13_14.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Repository
{
    internal class EventRepository
    {
        public List<Event> EventSarasas = new List<Event>();

        public void AddEvent(Event x ) 
        {
            EventSarasas.Add(x);
        }

        public List<Event> Retrieve()
        {
            return EventSarasas;//ivykiulist
        }
    }
}
