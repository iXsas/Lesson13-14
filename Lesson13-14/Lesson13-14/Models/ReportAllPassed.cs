using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Models
{
    internal class ReportAllPassed
    {
        public string Name { get; set; }
        public string GateId { get; set; }
        public DateTime WhenPassed { get; set; }
        public string Role { get; set; }

        public ReportAllPassed(string name, string gateId, DateTime whenPassed, string role)
        {
            Name = name;
            GateId = gateId;
            WhenPassed = whenPassed;
            Role = role;
        }
    }
}
