using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    public class Angajat
    {
        public string Nume { get; set; }
        public Angajat (string nume)
        {
            Nume = nume;
        }
        public virtual void AfisareDetalii() { Console.WriteLine($"Numele angajatului este {Nume}"); }
        
    }
    public class Manager : Angajat
    {
        public string Departament { get; set; }
        public Manager(string nume, string departament) :base(nume)
        {
            Departament = departament;
        }
        public override void AfisareDetalii()
        {
            base.AfisareDetalii();
            Console.WriteLine($"Departamentul {Departament}");
        }

    }
}
