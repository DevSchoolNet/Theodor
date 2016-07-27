using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class Customer : User
    {
        public int CostumerId
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }

        }

        public int Zone
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int City
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public override void Login(string employeeId, string password)
        {
            throw new System.NotImplementedException();
        }

        public void Login(string name, string employeeId, string password)
        {
            base.Login(name, password);
            //codul nostru
        }

        public virtual void CreateCard(string name, int CostumerId)
        {
            throw new System.NotImplementedException();
        }
    }

}