﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robotiv2
{
    public class UnderGroundRobot : Robot
    {
        public Items Items { get; set; }

        public UnderGroundRobot()
        {

        }
        public UnderGroundRobot(string Name, string Type, string Specialization)
        {
            this.Name = Name;
            this.Type = Type;
            this.Specialization = Specialization;
        }

        
        

        override public void Movement()
        {
            Console.WriteLine("Robotul " + Name+ "|" + Specialization + "|"  + " sapa");
        }

    }
}