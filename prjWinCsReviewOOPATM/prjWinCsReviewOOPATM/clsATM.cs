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

        public clsATM(string Number, string Address, clsListClient Clients, string Company, string Status, decimal Balance)
        {
            this.Number = Number;
            this.Address = Address;
            this.Clients = Clients;
            this.Company = Company;
            this.Status = Status;
            this.Balance = Balance;
        }
        public clsATM(string Number, string Address, string Company, string Status, decimal Balance)
        {
            this.Number = Number;
            this.Address = Address;
            this.Clients = new clsListClient();
            this.Company = Company;
            this.Status = Status;
            this.Balance = Balance;
        }

        public clsATM()
        {
            vNumber = vCompany = vAddress = vStatus = "Undefined";
            vClients = new clsListClient();
        }

        public string Number
        {
            get { return vNumber; }
            set { vNumber = value; }
        }

        public string Address
        {
            get { return vAddress; }
            set { vAddress = value; }
        }

        public string Company
        {
            get { return vCompany; }
            set { vCompany = value; }
        }

        public string Status
        {
            get { return vStatus; }
            set { vStatus = value; }
        }

        public clsListClient Clients
        {
            get { return vClients; }
            set { vClients = value; }
        }

        public decimal Balance { get => vBalance; set => vBalance = value; }

        public void Open()
        {
            throw new System.NotImplementedException();
        }

        public void Close()
        {
            throw new System.NotImplementedException();
        }

        public bool Fill()
        {
            throw new System.NotImplementedException();
        }

        public string Display()
        {
            throw new System.NotImplementedException();
        }
    }
}