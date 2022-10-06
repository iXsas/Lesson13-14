using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Models
{
    internal class Gate
    {
        public string GateId { get; set; }
        public string WhoCanPass { get; set; }

        public Gate(string gateId, string praejimoLeidimas)
        {
            GateId = gateId;
            WhoCanPass = praejimoLeidimas;
        }
    }
}
