using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotiLibrary
{
    public class Arma : Obiecte
    {
        public Arma()
        {

        }

        public Arma(string tip, string denumire)
        {
            this.denumire = denumire;
            this.tip = tip;
        }

    }
}