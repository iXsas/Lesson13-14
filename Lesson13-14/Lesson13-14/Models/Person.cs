using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Models
{
    internal class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int EventNo { get; set; }
        public bool Used { get; set; }=false;
            public Person(int personId, string name, 
            string role)
        {
            PersonId = personId;
            Name = name;
            Role = role;
            EventNo = 0;
            
        }
    }
}
