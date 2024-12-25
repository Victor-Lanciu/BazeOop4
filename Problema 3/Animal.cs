using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    public class Animal
    {
        public string Nume { get; set; }
        public virtual void AfisareDetalii()
        {
            Console.WriteLine($"Denumirea animalului: {Nume}");
        }
    }
    public class Mamifer : Animal
    {
        public string CuloareBlana { get; set; }
        public override void AfisareDetalii()
        {
            base.AfisareDetalii();
            Console.WriteLine($"Culoarea blanii: {CuloareBlana}");
        }
    }
    public class Pasare : Animal
    {
        public string TipZbor { get; set; }
        public override void AfisareDetalii()
        {
            base.AfisareDetalii();
            Console.WriteLine($"Tipul zborului: {TipZbor}");
        }
    }
    public class Papagal : Pasare
    {
        public int Vocabular { get; set; }
        public override void AfisareDetalii()
        {
            
            base.AfisareDetalii();
            Console.WriteLine($"Cuvinte stiute: {Vocabular}");
        }
    }

}
