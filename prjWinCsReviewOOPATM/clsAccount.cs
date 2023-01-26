using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCsReviewOOPATM
{
    public class clsAccount
    {
        //-- Declaration of Private Fields
        //--------------------------------
        private string vNumber;
        private string vType;
        private DateTime vOpenDate;
        private decimal vBalance;
        private string vStatus;

        //-- Default Constructors without parameters
        //------------------------------------------
        public clsAccount()
        {
            vNumber = vType = vStatus = "Undefined";
            vOpenDate = DateTime.Now;
            vBalance = -1;
        }

        //-- Default Constructors with parameters
        //------------------------------------------
        public clsAccount(string Number, string Type, DateTime OpenDate, decimal Balance, string Status)
        {
            vNumber = Number;
            vType = Type;
            vOpenDate = OpenDate;
            vBalance = Balance;
            vStatus = Status;
        }

        public clsAccount(string Number, string Type, int Day, int Month, int Year, string Status, decimal Balance)
        {
            vNumber = Number;
            vType = Type;
            vOpenDate = new DateTime(Year, Month, Day);
            vStatus = Status;
            vBalance = Balance;
        }

        //-- Public Properties (Getter & Setter / Read & Write)
        //------------------------------------------
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

        public string Type
        {
            get
            {
                return vType;
            }
            set
            {
                vType = value;
            }
        }

        public DateTime OpenDate
        {
            get
            {
                return vOpenDate;
            }
            /// This property is read only, that's why we deleted the set
        }

        public decimal Balance
        {
            get
            {
                return vBalance;
            }
            /// This property is read only, that's why we deleted the set
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

        //-- Public Methods
        //------------------------------------------
        public void Open(string Number, string Type)
        {
            this.Number = Number;
            this.Type = Type;
            vOpenDate = DateTime.Now;
            vBalance = 0;
            this.Status = "active";
        }

        /// <summary>
        ///  Return true if Amount is between 2 & 20 000 or return false
        /// </summary>
        public bool Deposit(decimal Amount)
        {
            if (Amount >= 2 && Amount <= 20000)
            {
                vBalance = vBalance + Amount;  //vBalance += Amount
                return true;
            }
            else { return false; }
        }

        /// <summary>
        /// Returns a number (0 = Success, 1 = Error Max, 2 = Error Min, -1 = Error Multiple of 20, -2 = Error Insufficient Funds)
        /// </summary>
        public int Withdraw(decimal Amount)
        {
            if (Amount < 20) return 2;
            else if (Amount > 500) return 1;
            else if ((Amount % 20) != 0) return -1;
            else if (Amount > vBalance) return -2;
            else
            {
                vBalance = vBalance - Amount;
                return 0;
            }
        }

        public string Consult()
        {
            string info = "Number : " + vNumber + "\nType : " + vType;
            info += "\nOpen Date : " + vOpenDate.ToShortDateString()
                + "\nStatus : " + vStatus + "\nBalance : " + vBalance;
            return info;
        }

    }
}