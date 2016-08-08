using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotiLibrary
{
    public class Inotator : Roboti
    {
        public Obiecte Obiecte { get; set; }

        public Inotator()
        {

        }

        public Inotator(string name, bool specializare)
        {
            this.name = name;
            this.specializare = specializare;

        }

        
        

        public override void deplasare()
        {
            Console.WriteLine(name + " " + Deplasare.Inoata);
        }

        public override void afisare()
        {
            if (this.specializare == true)
                Console.WriteLine("Nume: " + name + " ,de tip: " + Tip.Inotator + ", lucrator");
            else
                Console.WriteLine("Nume: " + name + " ,de tip: " + Tip.Inotator + ", luptator");
        }
    }
}