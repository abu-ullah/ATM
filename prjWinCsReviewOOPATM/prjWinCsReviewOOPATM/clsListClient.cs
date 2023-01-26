using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCsReviewOOPATM
{
    public class clsListClient
    {
        // declarations of private collection that will encapsulate (hide) behind or class
        private Dictionary<string, clsClient> myList = new Dictionary<string, clsClient>();

        public int NumberOf
        {
            get { return myList.Count; }
        }

        public Dictionary<string, clsClient>.ValueCollection Elements
        {
            get { return myList.Values; }
        }

        public bool Add(clsClient Client)
        {
            if (!myList.ContainsKey(Client.Number)) { myList.Add(Client.Number, Client); return true; }
            else return false;
        }

        public bool Delete(string Number)
        {
            return myList.Remove(Number);
        }

        public clsClient Find(string Number)
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
            foreach (clsClient cl in myList.Values)
            {
                info += cl.Display() + "\n--------------------------------\n";
            }

            return info;
        }
    }
}