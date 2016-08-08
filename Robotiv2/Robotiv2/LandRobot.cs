using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robotiv2
{
    public class LandRobot : Robot
    {
        public Items Items { get; set; }

        public LandRobot()
        {

        }
        public LandRobot(string Name, string Type, string Specialization)
        {
            this.Name = Name;
            this.Type = Type;
            this.Specialization = Specialization;
        }

        override public void Movement()
        {
            Console.WriteLine("Robotul "+Name +"|" + Specialization + "|" + " merge");
        }
    }
}