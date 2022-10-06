using Lesson13_14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Repository
{
    internal class PersonRepository
    {
        public List<Person> ZmoniuSarasas { get;private set; }
        public PersonRepository()
        {
            ZmoniuSarasas = new List<Person>();
            ZmoniuSarasas.Add(new Person(100, "Jonas","A"));
            ZmoniuSarasas.Add(new Person(8889, "Petras", "B"));
            ZmoniuSarasas.Add(new Person(9990, "Tomas", "C"));
            ZmoniuSarasas.Add(new Person(101, "Adomas", "A"));
            ZmoniuSarasas.Add(new Person(102, "Agne", "A"));
            ZmoniuSarasas.Add(new Person(103, "Laura", "A"));
            ZmoniuSarasas.Add(new Person(104, "Natali", "A"));
            ZmoniuSarasas.Add(new Person(8888, "Domas", "B"));
            ZmoniuSarasas.Add(new Person(105, "Gabija", "A"));
            ZmoniuSarasas.Add(new Person(105, "Juozas", "A"));
        }
        public List<Person> Retrieve()
        {
            return ZmoniuSarasas;
        }

    }
}
