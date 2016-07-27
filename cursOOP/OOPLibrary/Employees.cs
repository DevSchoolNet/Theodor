using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class Employees
    {
        public string Name
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int CNP
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Employees()
        {
        }

        public Employees(string Name, int CNP)
        {
            this.Name = Name;
            this.CNP = CNP;
        }
    }
}