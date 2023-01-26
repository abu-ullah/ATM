using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsReviewOOPATM
{
    public partial class frmATM : Form
    {
        public frmATM()
        {
            InitializeComponent();
        }

        //Global Form Variables
        clsATM myBank;
        clsClient currentClient;
        clsAccount currentAccount;

        private void frmATM_Load(object sender, EventArgs e)
        {
            clsListClient theClients = clsDataSource.getAllClients();
            myBank = new clsATM("atm123", "Royale Bank", "Lasalle College", theClients, "active", 200000);
            this.Height = 175;
            txtDeposit.Visible = txtWithdraw.Visible = lblDeposit.Visible = lblWithdraw.Visible = false;
        }

        private void btnNextNumber_Click(object sender, EventArgs e)
        {
            string number = txtNumber.Text.Trim();
            currentClient = myBank.Clients.Find(number);
            if(currentClient == null)
            {
                MessageBox.Show("Client Number Not Found, Try Again", "Wrong Client Number");
                txtNumber.Focus();
                return;
            }
            lblWelcome.Text = "Welcome " + currentClient.Name;
            txtPin.Focus();
            this.Height = 305;
        }

        private void btnNextPin_Click(object sender, EventArgs e)
        {
            string pin = txtPin.Text.Trim();
            if(pin != currentClient.Pin)
            {
                MessageBox.Show("Wrong Password | Try Again", "Invalid Password");
                txtPin.Clear();
                txtPin.Focus();
                return;
            }
            cboAccounts.Focus();
            this.Height = 398;
            currentClient.Accounts = clsDataSource.getAllAccountOfThisClient(currentClient.Number);
            foreach (clsAccount Ac in currentClient.Accounts.Elements)
            {
                cboAccounts.Items.Add(Ac.Type);
            }
            //select the first account type by default
            cboAccounts.SelectedIndex = 0;
        }

        private void btnNextAccount_Click(object sender, EventArgs e)
        {
            foreach (clsAccount Ac in currentClient.Accounts.Elements)
            {
                if(cboAccounts.SelectedItem.ToString() == Ac.Type)
                {
                    currentAccount = Ac;
                }
            }
            this.Height = 522;
        }

        private void btnNextTransaction_Click(object sender, EventArgs e)
        {
            decimal amount = 0;
            if (radDeposit.Checked)
            {
                amount = Convert.ToDecimal(txtDeposit.Text);
                if (currentAccount.Deposit(amount) == false)
                {
                    MessageBox.Show("The amount must be between $2 and $20, 000", "Deposit Transaction Failed");
                    txtDeposit.Focus();
                    return;
                }
            }
            else if (radWithdraw.Checked)
            {
                amount = Convert.ToDecimal(txtWithdraw.Text);
                int result = currentAccount.Withdraw(amount);
                switch (result)
                {
                    case 2:
                        MessageBox.Show("The Minimum amount to withdraw is $20", "Minimum Error");
                        txtWithdraw.Focus();
                        return;
                    case 1:
                        MessageBox.Show("The Maximum amount to withdraw is $500", "Maximum Error");
                        txtWithdraw.Focus();
                        return;
                    case -1:
                        MessageBox.Show("The amount must be a multiple of $20", "Multiple of 20 Error");
                        txtWithdraw.Focus();
                        return;
                    case -2:
                        MessageBox.Show("Insufficient Funds, your balance is" + currentAccount.Balance, "Insufficient Funds");
                        txtWithdraw.Focus();
                        return;
                    case 0:
                        MessageBox.Show("Withdraw Transaction Succeeded!", "Succesful Transaction");
                        break;
                }
            }
            this.Height = 670;
            lblInfo.Text = currentAccount.Consult();
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            this.Height = 175;
        }

        private void radDeposit_CheckedChanged(object sender, EventArgs e)
        {
            txtDeposit.Visible = lblDeposit.Visible = true;
            txtDeposit.Focus();
            txtWithdraw.Visible = lblWithdraw.Visible = false;
        }

        private void radWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            txtWithdraw.Visible = lblWithdraw.Visible = true;
            txtWithdraw.Focus();
            txtDeposit.Visible = lblDeposit.Visible = false;
        }

        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;   //block users from typing 
            }
            //if (char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;  //allow users to delete digits from textbox
            //}
        }

        private void txtWithdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;   //block users from typing 
            }
        }
    }
}
