using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCsReviewOOPATM
{
    public class clsATM
    {
        private string vNumber;
        private clsListClient vClients;
        private string vCompany;
        private string vAddress;
        private string vStatus;
        private decimal vBalance;

        public clsATM()
        {
            vNumber = vCompany = vAddress = vStatus = "Not Defined";
            vClients = new clsListClient();
        }

        public clsATM(string Number, string Company, string Address, string Status, decimal Balance)
        {
            this.Number = Number;
            this.Company = Company;
            this.Address = Address;
            this.Status = Status;
            this.Clients = new clsListClient();
            this.Balance = Balance;
        }

        public clsATM(string Number, string Company, string Address, clsListClient Clients, string Status, decimal Balance)
        {
            this.Number = Number;
            this.Company = Company;
            this.Address = Address;
            this.Status = Status;
            this.Clients = Clients;
            this.Balance = Balance;
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

        public string Address
        {
            get
            {
                return vAddress;
            }
            set
            {
                vAddress = value;
            }
        }

        public string Company
        {
            get
            {
                return vCompany;
            }
            set
            {
                vCompany = value;
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

        public clsListClient Clients
        {
            get
            {
                return vClients;
            }
            set
            {
                vClients = value;
            }
        }

        public decimal Balance
        {
            get
            { 
                return vBalance;
            }
            set
            {
                vBalance = value;
            }
        }

        public void Open()
        {
            throw new System.NotImplementedException();
        }

        public void Close()
        {
            throw new System.NotImplementedException();
        }

        public void Fill()
        {
            throw new System.NotImplementedException();
        }

        public string Display()
        {
            throw new System.NotImplementedException();
        }
    }
}