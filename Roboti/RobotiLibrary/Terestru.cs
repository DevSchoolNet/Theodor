using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotiLibrary
{
   
    public class Terestru : Roboti
    {
        public Obiecte Obiecte { get; set; }


        public Terestru()
        {

        }

        public Terestru(string name, bool specializare )
        {
            this.name = name;
            this.specializare = specializare;
           
        }

        
       
        public override void deplasare()
        {
            Console.WriteLine(name + " " + Deplasare.Merge);
        }

        public override  void afisare()
        {
            if (this.specializare == true)
                Console.WriteLine("Nume: " + name + " ,de tip: " + Tip.Terestru + ", lucrator");
            else
                Console.WriteLine("Nume: " + name + " ,de tip: " + Tip.Terestru + ", luptator");

        

        }

        }
    }
