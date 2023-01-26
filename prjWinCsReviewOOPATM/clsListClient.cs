using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCsReviewOOPATM
{
    public class clsListClient
    {
        //Declarations of private collection that will encapsulate(hide) our class
        private Dictionary<string, clsClient> myList = new Dictionary<string, clsClient>();

        //-- Public Properties (Getter & Setter) / Read & Write 
        //-----------------------------------------
        public int NumberOf
        {
            get { return myList.Count; }
        }

        public Dictionary<string, clsClient>.ValueCollection Elements
        {
            get
            {
                return myList.Values;
            }
        }

        //-- Public Methods
        //------------------------------------------
        public bool Add(clsClient Client)
        {
            if (myList.ContainsKey(Client.Number) == false)
            {
                myList.Add(Client.Number, Client);
                return true;
            }
            else
                return false;
        }

        public bool Delete(string Number)
        {
            return myList.Remove(Number);
        }

        public clsClient Find(string Number)
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
            foreach (clsClient cl in myList.Values)
            {
                info = info + cl.Display() + "\n--------------------------------\n";
            }
            return info;
        }
    }
}