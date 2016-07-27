using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class Companies : Customer
    {
        private string CUI
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }


        public Boolean FinancialStatus
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Employees Employees
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public override  void CreateCard(string name, int CUI)
        {
            throw new System.NotImplementedException();
        }

        public  void CreateCard(string Name, int CNP, string CompanyName )
        {
            base.CreateCard(name, CNP);
        }
    }
}