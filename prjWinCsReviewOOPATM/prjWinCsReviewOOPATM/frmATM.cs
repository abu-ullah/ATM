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
        // Global form variables
        clsATM myBank;
        clsClient currentClient;
        clsAccount currentAccount;
        private void frmATM_Load(object sender, EventArgs e)
        {
            clsListClient theClients = clsDataSource.getAllClients();
            myBank = new clsATM("atm123", "Lasalle College", theClients, "Royal Bank", "active", 200000);
            txtDeposit.Visible = txtWithdraw.Visible = lblDeposit.Visible = lblWithdraw.Visible = false;
            this.Height = 175;
        }

        private void btnNextNumber_Click(object sender, EventArgs e)
        {
            string number = txtNumber.Text.Trim();
            currentClient = myBank.Clients.Find(number);
            if (currentClient == null)
            {
                MessageBox.Show("Client number not found, try again. Wrong Client Number");
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
                MessageBox.Show("Wrong password : try again. Invalid password");
                txtPin.Clear();
                txtPin.Focus();
                return;
            }
            this.Height = 398;

            currentClient.Accounts = clsDataSource.getAllAccountsOfThisClient(currentClient.Number);
            foreach(clsAccount ac in currentClient.Accounts.Elements)
            { cboAccounts.Items.Add(ac.Type); }
            // Select account type by default
            cboAccounts.SelectedIndex = 0;
        }

        private void btnNextAccount_Click(object sender, EventArgs e)
        {
            foreach(clsAccount ac in currentClient.Accounts.Elements)
            {
                if(cboAccounts.SelectedItem.ToString() == ac.Type)
                { currentAccount = ac; }
            }
            this.Height = 522;
        }

        private void btnNextTransaction_Click(object sender, EventArgs e)
        {
            decimal amount = 0;

            if(radDeposit.Checked)
            {
                amount = Convert.ToDecimal(txtDeposit.Text);
                if (!currentAccount.Deposit(amount))
                {
                    MessageBox.Show("The amount must be between $2 and $20000," +
                        "Deposit transaction fails");
                    txtDeposit.Focus();
                    return;
                }
            }
            else if(radWithdraw.Checked)
            {
                amount = Convert.ToDecimal(txtWithdraw.Text);

                int result = currentAccount.Withdraw(amount);
                switch (result)
                {
                    case 1:
                        MessageBox.Show("The Maximum amount to withdraw is $20000, Maximum Error");
                        txtWithdraw.Focus();
                        return;
                    case 2:
                        MessageBox.Show("The Minimum amount to withdraw is $20, Minimum Error");
                        txtWithdraw.Focus();
                        return;
                    case -1:
                        MessageBox.Show("The amount must be a multiple of $20, Multiple Error");
                        txtWithdraw.Focus();
                        return;
                    case -2:
                        MessageBox.Show("Insufficient Funds, your balance is " + currentAccount.Balance
                                        + "Overdraw Error");
                        txtWithdraw.Focus();
                        return;
                    case 0:
                        MessageBox.Show("Withdraw Transaction Succeeded! Transaction Succeeded");
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
            txtWithdraw.Visible = lblWithdraw.Visible = false;
        }

        private void radWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            txtDeposit.Visible = lblDeposit.Visible = false;
            txtWithdraw.Visible = lblWithdraw.Visible = true;
        }

        private void radConsult_CheckedChanged(object sender, EventArgs e)
        {
            txtDeposit.Visible = txtWithdraw.Visible = lblDeposit.Visible = lblWithdraw.Visible = false;
        }

        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtWithdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
