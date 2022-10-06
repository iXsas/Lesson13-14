using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Models
{
    internal class ReportWorkHours
    {
        public string Name { get; set; }
        public DateTime WhenPassed { get; set; }
        public decimal TimeAtWork { get; set; }

        public ReportWorkHours(string name, DateTime whenPassed, decimal timeAtWork)
        {
            Name = name;
            WhenPassed = whenPassed;
            TimeAtWork = timeAtWork;
        }
    }
}
