using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robotiv2
{
    public abstract class Robot 
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Specialization { get; set; }
        public static int NrRoboti;
       

        public Robot()
        {
            NrRoboti++;
        }

        public Robot(string Name, string Type, string Specialization)
        {
            this.Name = Name;
            this.Type = Type;
            this.Specialization = Specialization;
            NrRoboti++;
        }

        virtual public void Movement()
        {
            Console.WriteLine("Robotul " + Name + "|"+Specialization+"|"  + "se deplaseaza");
        }

        public void Equip(Tool t, Weapon w)
        {
            if (Specialization == "Warrior")
            Console.WriteLine("Robotul " +Name+ " a luat obiectul de tipul arma " + w.Name );
            else
            {
            if (Specialization == "Worker")
                Console.WriteLine("Robotul "+Name+" a luat obiectul de tipul unealta " + t.Name );
            }
            
        }

        public void Work()
        {
            
            if (Specialization == "Warrior")
               
            Console.WriteLine("Pleaca spre lupta"); 
            else
            {
                if (Specialization == "Worker") 
                   
                    Console.WriteLine("Pleaca spre munca");
            }
        }

    }
}