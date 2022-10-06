using Lesson13_14.Models;
using Lesson13_14.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Services
{
    internal class EventService
    {
      //  public PersonRepository _PersonRepository { get; set; }
     //   public GateRepository _GateRepository { get; set; }
        public Event Ivykis { get; set; }

        public EventService(PersonRepository personRepository, GateRepository gateRepository, 
            Event ivykis)
        {
         //   _PersonRepository = personRepository;
        //    _GateRepository = gateRepository;
            Ivykis = ivykis;
        }
       
    }
}
