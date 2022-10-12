using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Models
{
    internal class Event
    {
        public int EventId { get; set; }
        public bool IsPassed { get; set; }
        public string WhoPassed { get; set; }
        public string WherePassed { get; set; }
        public DateTime WhenPassed { get; set; }
    //   public Time WorkTime { get; set; }
        public Event(int eventId, bool isPassed, 
            string whoPassed, string wherePassed, 
            DateTime whenPassed)
        {
            EventId = eventId;
            IsPassed = isPassed;
            WhoPassed = whoPassed;
            WherePassed = wherePassed;
            WhenPassed = whenPassed;
       //     WorkTime = new Time(8, 0, 0); 
        }
    }
}
