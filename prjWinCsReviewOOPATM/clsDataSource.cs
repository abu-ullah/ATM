using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prjWinCsReviewOOPATM
{
    public static class clsDataSource
    {

        public static clsListClient getAllClients()
        {
            //Declare local variable
            clsListClient theClients = new clsListClient();
            StreamReader myFile = new StreamReader("Clients.txt");
            while (myFile.EndOfStream == false)
            {
                string num = myFile.ReadLine();
                string name = myFile.ReadLine();
                string pin = myFile.ReadLine();
                string stat = myFile.ReadLine();
                clsClient temp = new clsClient(num, name, pin, stat);
                theClients.Add(temp);
            }
            myFile.Close();
            return theClients;
        }

        public static clsListAccount getAllAccountOfThisClient(string number)
        {
            //Declare local variable
            clsListAccount theAccounts = new clsListAccount();
            StreamReader myFile = new StreamReader("Accounts.txt");
            while (myFile.EndOfStream == false)
            {
                string numAc = myFile.ReadLine();
                string type = myFile.ReadLine();
                int day = Convert.ToInt32(myFile.ReadLine());
                int month = Convert.ToInt32(myFile.ReadLine());
                int year = Convert.ToInt32(myFile.ReadLine());
                string stat = myFile.ReadLine();
                decimal balance = Convert.ToDecimal(myFile.ReadLine());
                string numCl = myFile.ReadLine();
                if (numCl == number)
                {
                    clsAccount temp = new clsAccount(numAc, type, day, month, year, stat, balance);
                    theAccounts.Add(temp);
                }
            }
            myFile.Close();
            return theAccounts;
        }

    }
}
