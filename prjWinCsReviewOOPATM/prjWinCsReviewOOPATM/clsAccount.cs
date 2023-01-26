using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCsReviewOOPATM
{
    public class clsAccount
    {
        private string vNumber;
        private string vType;
        private DateTime vOpenDate;
        private decimal vBalance;
        private string vStatus;

        public clsAccount(string Number, string Type, int Day, int Month, int Year, decimal Balance, string Status)
        {
            vNumber = Number;
            vType = Type;
            vOpenDate = new DateTime(Year, Month, Day);
            vBalance = Balance;
            vStatus = Status;
        }

        public clsAccount(string Number, string Type, DateTime OpenDate, decimal Balance, string Status)
        {
            vNumber = Number;
            vType = Type;
            vOpenDate = OpenDate;
            vBalance = Balance;
            vStatus = Status;
        }

        public clsAccount()
        {
            vNumber =  vType = vStatus = "Undefined";
            vOpenDate = DateTime.Now;
            vBalance = -1;
        }

        public string Number
        {
            get { return vNumber; }
            set
            {
                vNumber = value;
            }
        }

        public string Type
        {
            get { return vType; }
            set
            {
                vType = value;
            }
        }

        public DateTime OpenDate
        {
            get { return vOpenDate; }
            //set
            //{
            //    vOpenDate = value;
            //}
        }

        public decimal Balance
        {
            get { return vBalance; }
            //  This property is Read-Only, that's why we deleted the set
        }

        public string Status
        {
            get { return vStatus; }
            set
            {
                vStatus = value;
            }
        }

        public void Open(string Number, string Type)
        { 
            this.Number = Number;
            this.Type = Type;
            vOpenDate = DateTime.Now;
            vBalance = 0;
            this.Status = "Active";
        }

        /// <summary>
        /// Returns true if amount is between 2 and 20000 or false
        /// </summary>
        public bool Deposit(decimal Amount)
        {
            if (Amount >= 2 && Amount <= 20000)
            {
                vBalance = vBalance + Amount; // vBalance += Amount;
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Returns a number (0 = Success, 1 = Error Max, 2 = Error Min, -1 = Error Multiple, -2 = Error Funds)
        /// </summary>
        public int Withdraw(decimal Amount)
        {
            if (Amount < 20) return 2;
            else if (Amount > 500) return 1;
            else if (Amount % 20 != 0) return -1;
            else if (Amount > vBalance) return -2;
            else { vBalance = vBalance - Amount; return 0; }
        }

        public string Consult() 
        {
            string Info = "Number : " + vNumber + "\nType: " + vType;
            Info += "\nOpen Date : " + vOpenDate.ToShortDateString() 
                 + "\nStatus: " + vStatus + "\nBalance : " + vBalance;
            return Info;
        }
    }
}