using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotiLibrary
{
    public class Zburator : Roboti
    {
        public Obiecte Obiecte { get; set; }

        public Zburator()
        {

        }

        public Zburator(string name, bool specializare)
        {
            this.name = name;
            this.specializare = specializare;

        }

        
       

        public override void deplasare()
        {
            Console.WriteLine(name + " " + Deplasare.Zboara);
        }

        public override void afisare()
        {
            if (this.specializare == true)
                Console.WriteLine("Nume: " + name + " ,de tip: " + Tip.Zburator + ", lucrator");
            else
                Console.WriteLine("Nume: " + name + " ,de tip: " + Tip.Zburator + ", luptator");
        }
    }
}