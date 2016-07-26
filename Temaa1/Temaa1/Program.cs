using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Tema1
{
    public class Comenzi
    {
        private string denumire { get; set; } = "Ipad Mini";
        public string tip { get; set; }
        public int pret { get; set; }
        public int cantitate { get; set; }

        public Comenzi()
        {
            this.tip = "Tableta";
            this.pret = 1800;
            this.cantitate = 1;
        }

        public Comenzi(string denumire, string tip, int pret, int cantitate)
        {
            this.denumire = denumire;
            this.tip = tip;
            this.pret = pret;
            this.cantitate = cantitate;
        }

        // public string Name
        //{
        //    get { return nume; }
        //    set { nume = value; }
        //}

        public void afisare() => Console.WriteLine("Denumire: " + denumire + ", Tip: " + tip + ", Pret: " + pret + ", Cantitate: " + cantitate);
        //{
        //    Console.WriteLine("Denumire Produs: " + denumire);
        //    Console.WriteLine("Tip Produs: " + tip);
        //    Console.WriteLine("Pret Produs: " + pret);
        //    Console.WriteLine("Numarul de produse: " + cantitate);
        //}

        public int Valoarea()
        {
            return this.pret * this.cantitate;
        }


    }





    class Program
    {
        static void Main(string[] args)
        {
            Comenzi c1 = new Comenzi();
            Comenzi c2 = new Comenzi("Galaxy S5", "Smartphone", 1200, 2);
            c1.afisare();
            Console.WriteLine("Valoarea comenzii este: " + c1.Valoarea());
            Console.WriteLine();
            c2.afisare();
            Console.WriteLine("Valoarea comenzii este: " + c2.Valoarea());


            int Total = c1.Valoarea() + c2.Valoarea();
            Console.WriteLine();
            Console.WriteLine($"Suma totala a comenzilor este: {c1.Valoarea()} + {c2.Valoarea()} = {Total} ");

            Console.ReadKey();
        }
    }
}