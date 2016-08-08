using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotiLibrary;


namespace Roboti
{
    class Program
    {
        static void Main(string[] args)
        {



            Terestru t1 = new Terestru("Ultron", true );
            t1.afisare();
            Inotator i1 = new Inotator("Serban", false);
            i1.afisare();
            Subteran s1 = new Subteran("Eminem", true);
            Subteran s2 = new Subteran("50Cent", false);
            Unealta u1 = new Unealta("Unealta","Sapa");
            Arma a1 = new Arma("Arma","Ak47");
            //var robots = new List<RobotiLibrar>() { };
            //implementare interfata pt tip de robot(Warrior, Worker)

            s2.afisare();
            s2.obiecte(a1,u1);

            //Zburator z1 = new Zburator("Bee", false);
            //Zburator z2 = new Zburator("Fly", true);
            //z1.afisare();

            // CW ("Map:") Mappare in functie de functii , CW ("Reduce")
            //

          
            

         


            Console.ReadKey();
        }
    }
}
