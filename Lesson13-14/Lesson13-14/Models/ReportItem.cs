using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Models
{
    internal class ReportItem
    {   public int PersonId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int EventNumber { get; set; }
        public string GateId { get; set; }
        public string CanPass { get; set; }
        public int IsPassed { get; set; }
        public DateTime WhenPassed { get; set; }

        public ReportItem(int personId, string name, 
            string role, int eventNumber, string gateId, 
            string canPass, int isPassed, DateTime whenPassed)
        {
            PersonId = personId;
            Name = name;
            Role = role;
            EventNumber = eventNumber;
            GateId = gateId;
            CanPass = canPass;
            IsPassed = isPassed;
            WhenPassed = whenPassed;
        }
    }
}
