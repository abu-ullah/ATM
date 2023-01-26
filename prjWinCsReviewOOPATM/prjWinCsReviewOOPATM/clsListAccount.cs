using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCsReviewOOPATM
{
    public class clsListAccount
    {
        // declarations of private collection that will encapsulate (hide) behind or class
        private Dictionary<string, clsAccount> myList = new Dictionary<string, clsAccount>();

        public int NumberOf
        {
            get { return myList.Count; }
        }

        public Dictionary<string, clsAccount>.ValueCollection Elements
        {
            get{ return myList.Values; }
        }

        public bool Add(clsAccount Account)
        {
            if (!myList.ContainsKey(Account.Number)) { myList.Add(Account.Number, Account); return true; }
            else return false;
        }

        public bool Delete(string Number)
        {
            return myList.Remove(Number);
        }

        public clsAccount Find(string Number)
        {
            if (myList.ContainsKey(Number)) return myList[Number];
            else return null;
        }

        public bool Exist(string Number)
        {
            return myList.ContainsKey(Number);
        }

        public string Display()
        {
            string info = "";
            foreach(clsAccount ac in myList.Values)
            {
                info += ac.Consult() + "\n--------------------------------\n";
            }
                
            return info;
        }
    }
}