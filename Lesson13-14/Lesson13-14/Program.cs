using Lesson13_14.Models;
using Lesson13_14.Repository;
using Lesson13_14.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            DateTime date1 = new DateTime(2022, 10, 1, 8, 0, 0);
           
            Console.WriteLine("Susigeneruojam iventus");
            for (int j = 0; j < 100; j++)
            { int i = rnd.Next(0, 10);//ridenu kauliuka, generuoju numerius
                if (persons[i].Used == true) continue;
  
                persons[i].EventNo++; int z = rnd.Next(0, 4);
                bool arpraejo = gates[z].WhoCanPass.Contains(persons[i].Role); 
                DateTime ivykioLaikas = date1.AddMinutes(rnd.Next(0, 59)).AddSeconds(rnd.Next(0, 59));
                         
                Event NewEvent = new Event(persons[i].EventNo, arpraejo, persons[i].Name, gates[z].GateId, ivykioLaikas);
                _EventRepo.AddEvent(NewEvent);
                //isejimas i pertrauka
                if (arpraejo)
                {persons[i].Used = true;
                    DateTime ivykiolaikasdu = ivykioLaikas.AddHours(rnd.Next(3, 4)).AddMinutes(rnd.Next(0, 30)).AddSeconds(rnd.Next(0, 59));
                    TimeSpan workhours = (ivykiolaikasdu - ivykioLaikas);
                    Console.WriteLine($"Darbuotojo {persons[i].Name} darbo laikas = {workhours}");//darboLaikas

                    NewEvent = new Event(persons[i].EventNo, arpraejo, persons[i].Name, gates[z].GateId, ivykiolaikasdu);
                    _EventRepo.AddEvent(NewEvent);
                }
                else { }
            }
            var naujas = _EventRepo.Retrieve().OrderBy(g => g.WhoPassed).ThenBy(g => g.WhenPassed);
            if (File.Exists("ataskaita.txt")) { File.Delete("ataskaita.txt"); }
            
            foreach (var x in naujas)
            { 
                Console.WriteLine($" {x.WhoPassed} {x.WhenPassed} laiku per vartus {x.WherePassed} ar praejo {x.IsPassed}");
                File.AppendAllText("ataskaita.txt", $" {x.WhoPassed} {x.WhenPassed} laiku per vartus {x.WherePassed} ar praejo {x.IsPassed} \n");
            }
          
        }
    }
}
/*kodo gabalai
 * 
 *  // var naujas = _EventRepo.Retrieve().OrderBy(g => g.WhenPassed);
            //.Sort((g1,g2) => g1.WhoPassed.CompareTo(g2.WhoPassed));           
            // _EventRepo.Retrieve().OrderBy(o => o.WhoPassed);
 //var orderby = from s in _EventRepo.Retrieve()
            //              orderby s.WhoPassed
            //              select s;
  Console.WriteLine("--------------------------------------------------------------------");        
            var cc = _EventRepo.Retrieve();
            cc.OrderBy(o => o.WhoPassed);
//    _EventRepo.Retrieve().Sort(StringComparer);
            //foreach (var x in _EventRepo.Retrieve())
            //{
            //    Console.WriteLine($" {x.WhoPassed} laiku {x.WhenPassed} per vartus {x.WherePassed} ar praejo {x.IsPassed}");
            //}
 */