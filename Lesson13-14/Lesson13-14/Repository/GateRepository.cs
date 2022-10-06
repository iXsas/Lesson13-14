using Lesson13_14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Repository
{
    internal class GateRepository
    {
    public List<Gate> VartuSarasas {get;set;}
        public GateRepository()
        {
            VartuSarasas = new List<Gate>();
            VartuSarasas.Add(new Gate("Gate1","ABC"));
            VartuSarasas.Add(new Gate("Gate2", "A"));
            VartuSarasas.Add(new Gate("Gate3", "B"));
            VartuSarasas.Add(new Gate("Gate4", "C"));
        }
        public List<Gate> Retrieve()
        {
            return VartuSarasas;
        }

    }
}
