using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class Individual : Customer
    {
        private int CNP
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public override void CreateCard(string name, int CNP)
        {
            throw new System.NotImplementedException();
        }
    }
}