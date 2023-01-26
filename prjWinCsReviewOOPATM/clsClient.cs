using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCsReviewOOPATM
{
    public class clsClient
    {
        private string vNumber;
        private string vName;
        private string vPin;
        private string vStatus;
        private clsListAccount vAccounts;

        public clsClient()
        {
            vNumber = vName = vPin = vStatus = "Not Defined";
            vAccounts = new clsListAccount();
        }

        public clsClient(string Number, string Name, string Pin, string Status, clsListAccount Accounts)
        {
            this.Number = Number;
            this.Name = Name;
            this.Pin = Pin;
            this.Status = Status;
            this.Accounts = Accounts;
        }

        public clsClient(string Number, string Name, string Pin, string Status)
        {
            this.Number = Number;
            this.Name = Name;
            this.Pin = Pin;
            this.Status = Status;
            this.Accounts = new clsListAccount();
        }

        public string Number
        {
            get
            {
                return vNumber;
            }
            set
            {
                vNumber = value;
            }
        }

        public string Name
        {
            get
            {
                return vName;
            }
            set
            {
                vName = value;
            }
        }

        public string Pin
        {
            get
            {
                return vPin;
            }
            set
            {
                vPin = value;
            }
        }

        public string Status
        {
            get
            {
                return vStatus;
            }
            set
            {
                vStatus = value;
            }
        }

        public clsListAccount Accounts
        {
            get
            {
                return vAccounts;
            }
            set
            {
                vAccounts = value;
            }
        }

        public void Register()
        {
            throw new System.NotImplementedException();
        }

        public string Display()
        {
            string info = "Number : " + vNumber + "\nName : " + vName +
                "\nPin : " + vPin + "\nStatus : " + vStatus +
                "\nClient's Accounts : " + vAccounts.Display();
            return info;
        }
    }
}