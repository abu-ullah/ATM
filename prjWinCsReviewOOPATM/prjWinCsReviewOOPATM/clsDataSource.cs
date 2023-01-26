using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;

namespace prjWinCsReviewOOPATM
{
    public static class clsDataSource
    {
        public static clsListClient getAllClients()
        {
            // Text file version
            /*
            clsListClient theClients = new clsListClient();
            StreamReader myFile = new StreamReader("Clients.txt");
            while(!myFile.EndOfStream)
            {
                string num = myFile.ReadLine();
                string name = myFile.ReadLine();
                string pin = myFile.ReadLine();
                string status = myFile.ReadLine();

                clsClient temp = new clsClient(num, name, pin, status);
                theClients.Add(temp);
            }
            myFile.Close();

            return theClients;
        */

            // Database version
            clsListClient theClients = new clsListClient();
            OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\thanh\Desktop\prjWinCsReviewOOPATM\prjWinCsReviewOOPATM\prjWinCsReviewOOPATM\Databases\Bank.mdb;Persist Security Info=True");
            myCon.Open();
            OleDbCommand myCmd = new OleDbCommand("SELECT * FROM Clients", myCon);
            OleDbDataReader myReader = myCmd.ExecuteReader();

            while(myReader.Read())
            {
                string num = myReader["Number"].ToString();
                string name = myReader["ClientName"].ToString();
                string pin = myReader["Pin"].ToString();
                string status = myReader["Status"].ToString();

                clsClient temp = new clsClient(num, name, pin, status);
                theClients.Add(temp);
            }

            myCon.Close();
            return theClients;

        }
        public static clsListAccount getAllAccountsOfThisClient(string Number)
        {
            clsListAccount theAccounts = new clsListAccount();
            StreamReader myFile = new StreamReader("Accounts.txt");
            while (!myFile.EndOfStream)
            {
                string numAc = myFile.ReadLine();
                string type = myFile.ReadLine();
                int day = Convert.ToInt32(myFile.ReadLine());
                int month = Convert.ToInt32(myFile.ReadLine());
                int year = Convert.ToInt32(myFile.ReadLine());
                string status = myFile.ReadLine();
                decimal balance = Convert.ToDecimal(myFile.ReadLine());
                string numCl = myFile.ReadLine();

                if (numCl == Number)
                {
                    clsAccount temp = new clsAccount(numAc, type, day, month, year, balance, status);
                    theAccounts.Add(temp);
                }
            }
            myFile.Close();
            return theAccounts;
        }
    }
}
