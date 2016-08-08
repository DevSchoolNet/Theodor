using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotiv2
{
    
    class Program
    {
        public static void Menu()
        {
            System.Console.WriteLine("\nPuteti efectua urmatoarele actiuni:");
            System.Console.WriteLine("Apasati tasta 1 pentru a pune robotii in miscare");
            System.Console.WriteLine("Apasati tasta 2 pentru a spune robotilor sa se pregateasca ");
            System.Console.WriteLine("Apasati tasta 3 pentru a spune robotilor sa munceasca ");
            System.Console.WriteLine("Apasati tasta 0 pentru a iesi.\n ");
           
        }
        
        static void Main(string[] args)
        {
            bool exit = false;
            string alege = "0";


            LandRobot L1 = new LandRobot("Gigel", "LandRobot","Worker");
            FlyingRobot F1 = new FlyingRobot("Musca", "FlyingRobot", "Warrior");
            UnderGroundRobot U1 = new UnderGroundRobot("Cartita", "UnderGroundRobot", "Worker");
            WaterRobot W1 = new WaterRobot("Sharky", "WaterRobot", "Worker");

            Tool t = new Tool();
            t.Name = "CyberLopata";
            Tool t1 = new Tool();
            t1.Name = "CyberFurca";
            Tool t2 = new Tool();
            t2.Name = "CyberUndita";
            Tool t3 = new Tool();
            W1.Items = t3;


            Weapon w = new Weapon();
            w.Name = "LaserSword";

            var listOfRobots =
                new List<Robot>() { L1, F1, U1, W1 };

            while (!exit)
            {
                Menu();
                alege = Console.ReadLine();
                switch (alege)
                {
                    case "1":
                        foreach(var robot in listOfRobots)
                        {
                            robot.Movement();
                        }
                        break;

                    case "2":
                        foreach(var robot in listOfRobots)
                        {
                            if (robot.Type == "UnderGroundRobot")
                                robot.Equip(t, w);
                            else if (robot.Type == "WaterRobot")
                                robot.Equip(t2, w);
                            else
                                robot.Equip(t1, w);
                        }
                        break;

                    case "3":
                        foreach(var robot in listOfRobots)
                        {
                            robot.Work();
                        }
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Error");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
