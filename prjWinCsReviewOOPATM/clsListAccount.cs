using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCsReviewOOPATM
{
    public class clsListAccount
    {
        //Declarations of private collection that will encapsulate(hide) our class
        private Dictionary<string, clsAccount> myList = new Dictionary<string, clsAccount>();

        //-- Public Properties (Getter & Setter) / Read & Write 
        //-----------------------------------------
        public int NumberOf
        {
            get { return myList.Count; }
        }

        public Dictionary<string, clsAccount>.ValueCollection Elements
        {
            get
            {
                return myList.Values;
            }
        }

        //-- Public Methods
        //------------------------------------------
        public bool Add(clsAccount Account)
        {
            if (myList.ContainsKey(Account.Number) == false)
            {
                myList.Add(Account.Number, Account);
                return true;
            }
            else
                return false;
        }

        public bool Delete(string Number)
        {
            return myList.Remove(Number);
        }

        public clsAccount Find(string Number)
        {
            if (myList.ContainsKey(Number) == true)
            {
                return myList[Number];
            }
            else
                return null;
        }

        public bool Exist(string Number)
        {
            return myList.ContainsKey(Number);
        }

        public string Display()
        {
            string info = "";
            foreach (clsAccount ac in myList.Values)
            {
                info = info + ac.Consult() + "\n--------------------------------\n";
            }
            return info; 
        }
    }
}