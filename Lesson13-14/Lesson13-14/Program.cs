using Lesson13_14.Models;
using Lesson13_14.Repository;
using Lesson13_14.Services;
using System;
using System.Collections.Generic;
using System.Net.Security;

namespace Lesson13_14
{
    internal class Program
    {
         
        static void Main(string[] args)
        {//pagrindine programa
            Random rnd = new Random();
            PersonRepository _PersonRepo = new PersonRepository();
            List<Person> persons = new List<Person>(); persons = _PersonRepo.Retrieve();
           
            GateRepository _GateRepo = new GateRepository();
            List<Gate> gates = new List<Gate>(); gates = _GateRepo.Retrieve();

            EventRepository _EventRepo = new EventRepository();
            // Define two dates.
            DateTime date1 = new DateTime(2022, 10, 1, 8, 0, 0);
            DateTime date2 = new DateTime(2022, 10, 1, 13, 30, 30);

            Console.WriteLine("Susigeneruojam iventus");
            for (int j = 0; j < 10; j++)
            { int i = rnd.Next(0, 10);//ridenu kauliuka, generuoju numerius
                persons[i].EventNo++; int z = rnd.Next(0, 4);
                bool arpraejo = gates[z].WhoCanPass.Contains(persons[i].Role);
                DateTime ivykioLaikas = date1.AddHours(rnd.Next(0, 5)).AddMinutes(rnd.Next(0, 59)).AddSeconds(rnd.Next(0, 59));
                DateTime pertpradziaLaikas = ivykioLaikas.AddMinutes(rnd.Next(0, 59)).AddSeconds(rnd.Next(0, 59));
                DateTime pertrabLaikas = pertpradziaLaikas.AddMinutes(rnd.Next(0, 59)).AddSeconds(rnd.Next(0, 59));
                Console.WriteLine($"Name {persons[i].Name} ID" +
               $" {persons[i].PersonId} role {persons[i].Role} event no. {persons[i].EventNo} " +
               $"vartai {gates[z].GateId} gali praeiti {arpraejo} laikas {ivykioLaikas} ");
                Event NewEvent = new Event(persons[i].EventNo, arpraejo, persons[i].Name, gates[z].GateId, ivykioLaikas, pertpradziaLaikas);
                _EventRepo.AddEvent(NewEvent);
            }
            foreach (var x in _EventRepo.Retrieve())
            {
                Console.WriteLine($" {x.WhoPassed} laiku {x.WhenPassed} per vartus {x.WherePassed} ar praejo {x.IsPassed}");
            }

        }
    }
}
