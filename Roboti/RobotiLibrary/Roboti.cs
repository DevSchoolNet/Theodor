using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotiLibrary
{
    public abstract class Roboti
    {
        public bool specializare { get; set; }
        public string name { get; set; }
        public static int NrRoboti;
        public enum Tip { Terestru, Subteran, Zburator, Inotator }; 

        public Roboti()
        { NrRoboti++; }

        public Roboti(string name, bool specializare)
        {
            this.name = name;
            this.specializare = specializare;
            NrRoboti++;
        }

        ~Roboti()
        { }

        

        public virtual void deplasare()
        {
            Console.WriteLine("Robotul se deplaseaza");
        }

       

        public virtual void afisare()
        {
            if (this.specializare == true)
                Console.WriteLine("Nume: " + name + "Este Lucrator" );
            else
                Console.WriteLine("Nume: " + name + "Este Luptator");
        }
    }
}