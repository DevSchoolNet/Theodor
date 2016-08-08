using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotiLibrary
{
    public class Subteran : Roboti
    {
        public Obiecte Obiecte { get; set; }

        public Subteran()
        {

        }

        public Subteran(string name, bool specializare)
        {
            this.name = name;
            this.specializare = specializare;

        }

        public void obiecte(Arma a, Unealta u)
        {

            if (specializare == true)
            {
                u.tip = "Unealta";
                Console.WriteLine(u.denumire);
               
            }

            else
            {
                a.tip = "Arma";
                Console.WriteLine(a.denumire);
            }
            
        }



        public override void deplasare()
        {
            Console.WriteLine(name + " " + Deplasare.Sapa);
        }

        public override void afisare()
        {
            if (this.specializare == true)
                Console.WriteLine("Nume: " + name + " ,de tip: " + Tip.Subteran + ", lucrator" + " " );
            else
                Console.WriteLine("Nume: " + name + " ,de tip: " + Tip.Subteran + ", luptator" + " " );
        }
    }
}