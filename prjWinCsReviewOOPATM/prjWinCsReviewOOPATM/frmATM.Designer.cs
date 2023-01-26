namespace prjWinCsReviewOOPATM
{
    partial class frmATM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grpClientNumber = new System.Windows.Forms.GroupBox();
            this.btnNextNumber = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPin = new System.Windows.Forms.GroupBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnNextPin = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.cboAccounts = new System.Windows.Forms.ComboBox();
            this.btnNextAccount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpTransaction = new System.Windows.Forms.GroupBox();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.radConsult = new System.Windows.Forms.RadioButton();
            this.radWithdraw = new System.Windows.Forms.RadioButton();
            this.radDeposit = new System.Windows.Forms.RadioButton();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.btnNextTransaction = new System.Windows.Forms.Button();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.grpClientNumber.SuspendLayout();
            this.grpPin.SuspendLayout();
            this.grpAccount.SuspendLayout();
            this.grpTransaction.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROYAL BANK ATM";
            // 
            // grpClientNumber
            // 
            this.grpClientNumber.BackColor = System.Drawing.SystemColors.Control;
            this.grpClientNumber.Controls.Add(this.btnNextNumber);
            this.grpClientNumber.Controls.Add(this.txtNumber);
            this.grpClientNumber.Controls.Add(this.label2);
            this.grpClientNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClientNumber.Location = new System.Drawing.Point(55, 52);
            this.grpClientNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpClientNumber.Name = "grpClientNumber";
            this.grpClientNumber.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpClientNumber.Size = new System.Drawing.Size(605, 103);
            this.grpClientNumber.TabIndex = 1;
            this.grpClientNumber.TabStop = false;
            this.grpClientNumber.Text = "Client Identification";
            // 
            // btnNextNumber
            // 
            this.btnNextNumber.Location = new System.Drawing.Point(345, 65);
            this.btnNextNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextNumber.Name = "btnNextNumber";
            this.btnNextNumber.Size = new System.Drawing.Size(183, 27);
            this.btnNextNumber.TabIndex = 2;
            this.btnNextNumber.Text = "Next >>";
            this.btnNextNumber.UseVisualStyleBackColor = true;
            this.btnNextNumber.Click += new System.EventHandler(this.btnNextNumber_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(171, 30);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(309, 26);
            this.txtNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Client Number:";
            // 
            // grpPin
            // 
            this.grpPin.BackColor = System.Drawing.SystemColors.Control;
            this.grpPin.Controls.Add(this.lblWelcome);
            this.grpPin.Controls.Add(this.btnNextPin);
            this.grpPin.Controls.Add(this.txtPin);
            this.grpPin.Controls.Add(this.label3);
            this.grpPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPin.Location = new System.Drawing.Point(55, 171);
            this.grpPin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPin.Name = "grpPin";
            this.grpPin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPin.Size = new System.Drawing.Size(605, 143);
            this.grpPin.TabIndex = 2;
            this.grpPin.TabStop = false;
            this.grpPin.Text = "Pin Validation";
            // 
            // lblWelcome
            // 
            this.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWelcome.Location = new System.Drawing.Point(24, 36);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(302, 28);
            this.lblWelcome.TabIndex = 3;
            // 
            // btnNextPin
            // 
            this.btnNextPin.Location = new System.Drawing.Point(344, 106);
            this.btnNextPin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextPin.Name = "btnNextPin";
            this.btnNextPin.Size = new System.Drawing.Size(183, 27);
            this.btnNextPin.TabIndex = 2;
            this.btnNextPin.Text = "Next >>";
            this.btnNextPin.UseVisualStyleBackColor = true;
            this.btnNextPin.Click += new System.EventHandler(this.btnNextPin_Click);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(164, 76);
            this.txtPin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(309, 26);
            this.txtPin.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Your Pin:";
            // 
            // grpAccount
            // 
            this.grpAccount.BackColor = System.Drawing.SystemColors.Control;
            this.grpAccount.Controls.Add(this.cboAccounts);
            this.grpAccount.Controls.Add(this.btnNextAccount);
            this.grpAccount.Controls.Add(this.label5);
            this.grpAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccount.Location = new System.Drawing.Point(55, 330);
            this.grpAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAccount.Size = new System.Drawing.Size(605, 103);
            this.grpAccount.TabIndex = 3;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Account Types";
            // 
            // cboAccounts
            // 
            this.cboAccounts.FormattingEnabled = true;
            this.cboAccounts.Location = new System.Drawing.Point(203, 33);
            this.cboAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAccounts.Name = "cboAccounts";
            this.cboAccounts.Size = new System.Drawing.Size(277, 28);
            this.cboAccounts.TabIndex = 3;
            // 
            // btnNextAccount
            // 
            this.btnNextAccount.Location = new System.Drawing.Point(345, 66);
            this.btnNextAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextAccount.Name = "btnNextAccount";
            this.btnNextAccount.Size = new System.Drawing.Size(183, 27);
            this.btnNextAccount.TabIndex = 2;
            this.btnNextAccount.Text = "Next >>";
            this.btnNextAccount.UseVisualStyleBackColor = true;
            this.btnNextAccount.Click += new System.EventHandler(this.btnNextAccount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select the Account:";
            // 
            // grpTransaction
            // 
            this.grpTransaction.BackColor = System.Drawing.SystemColors.Control;
            this.grpTransaction.Controls.Add(this.txtWithdraw);
            this.grpTransaction.Controls.Add(this.txtDeposit);
            this.grpTransaction.Controls.Add(this.radConsult);
            this.grpTransaction.Controls.Add(this.radWithdraw);
            this.grpTransaction.Controls.Add(this.radDeposit);
            this.grpTransaction.Controls.Add(this.lblWithdraw);
            this.grpTransaction.Controls.Add(this.btnNextTransaction);
            this.grpTransaction.Controls.Add(this.lblDeposit);
            this.grpTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTransaction.Location = new System.Drawing.Point(55, 450);
            this.grpTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTransaction.Name = "grpTransaction";
            this.grpTransaction.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTransaction.Size = new System.Drawing.Size(605, 137);
            this.grpTransaction.TabIndex = 4;
            this.grpTransaction.TabStop = false;
            this.grpTransaction.Text = "Transactions";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(344, 55);
            this.txtWithdraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(109, 26);
            this.txtWithdraw.TabIndex = 8;
            this.txtWithdraw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWithdraw_KeyPress);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(344, 22);
            this.txtDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(109, 26);
            this.txtDeposit.TabIndex = 7;
            this.txtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposit_KeyPress);
            // 
            // radConsult
            // 
            this.radConsult.AutoSize = true;
            this.radConsult.Checked = true;
            this.radConsult.Location = new System.Drawing.Point(60, 80);
            this.radConsult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radConsult.Name = "radConsult";
            this.radConsult.Size = new System.Drawing.Size(94, 24);
            this.radConsult.TabIndex = 6;
            this.radConsult.TabStop = true;
            this.radConsult.Text = "Consult";
            this.radConsult.UseVisualStyleBackColor = true;
            this.radConsult.CheckedChanged += new System.EventHandler(this.radConsult_CheckedChanged);
            // 
            // radWithdraw
            // 
            this.radWithdraw.AutoSize = true;
            this.radWithdraw.Location = new System.Drawing.Point(60, 52);
            this.radWithdraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radWithdraw.Name = "radWithdraw";
            this.radWithdraw.Size = new System.Drawing.Size(108, 24);
            this.radWithdraw.TabIndex = 5;
            this.radWithdraw.TabStop = true;
            this.radWithdraw.Text = "Withdraw";
            this.radWithdraw.UseVisualStyleBackColor = true;
            this.radWithdraw.CheckedChanged += new System.EventHandler(this.radWithdraw_CheckedChanged);
            // 
            // radDeposit
            // 
            this.radDeposit.AutoSize = true;
            this.radDeposit.Location = new System.Drawing.Point(60, 23);
            this.radDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radDeposit.Name = "radDeposit";
            this.radDeposit.Size = new System.Drawing.Size(95, 24);
            this.radDeposit.TabIndex = 4;
            this.radDeposit.Text = "Deposit";
            this.radDeposit.UseVisualStyleBackColor = true;
            this.radDeposit.CheckedChanged += new System.EventHandler(this.radDeposit_CheckedChanged);
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Location = new System.Drawing.Point(459, 58);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(19, 20);
            this.lblWithdraw.TabIndex = 3;
            this.lblWithdraw.Text = "$";
            // 
            // btnNextTransaction
            // 
            this.btnNextTransaction.Location = new System.Drawing.Point(345, 100);
            this.btnNextTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextTransaction.Name = "btnNextTransaction";
            this.btnNextTransaction.Size = new System.Drawing.Size(183, 28);
            this.btnNextTransaction.TabIndex = 2;
            this.btnNextTransaction.Text = "Next >>";
            this.btnNextTransaction.UseVisualStyleBackColor = true;
            this.btnNextTransaction.Click += new System.EventHandler(this.btnNextTransaction_Click);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(459, 25);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(19, 20);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.Text = "$";
            // 
            // grpInfo
            // 
            this.grpInfo.BackColor = System.Drawing.SystemColors.Control;
            this.grpInfo.Controls.Add(this.lblInfo);
            this.grpInfo.Controls.Add(this.btnTerminate);
            this.grpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(55, 604);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInfo.Size = new System.Drawing.Size(605, 161);
            this.grpInfo.TabIndex = 5;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Account Information";
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Location = new System.Drawing.Point(23, 21);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(305, 125);
            this.lblInfo.TabIndex = 3;
            // 
            // btnTerminate
            // 
            this.btnTerminate.Location = new System.Drawing.Point(344, 113);
            this.btnTerminate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(185, 32);
            this.btnTerminate.TabIndex = 2;
            this.btnTerminate.Text = "Terminate";
            this.btnTerminate.UseVisualStyleBackColor = true;
            this.btnTerminate.Click += new System.EventHandler(this.btnTerminate_Click);
            // 
            // frmATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 980);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpTransaction);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.grpPin);
            this.Controls.Add(this.grpClientNumber);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmATM";
            this.Text = "frmATM";
            this.Load += new System.EventHandler(this.frmATM_Load);
            this.grpClientNumber.ResumeLayout(false);
            this.grpClientNumber.PerformLayout();
            this.grpPin.ResumeLayout(false);
            this.grpPin.PerformLayout();
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            this.grpTransaction.ResumeLayout(false);
            this.grpTransaction.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpClientNumber;
        private System.Windows.Forms.Button btnNextNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnNextPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.ComboBox cboAccounts;
        private System.Windows.Forms.Button btnNextAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpTransaction;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.RadioButton radConsult;
        private System.Windows.Forms.RadioButton radWithdraw;
        private System.Windows.Forms.RadioButton radDeposit;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Button btnNextTransaction;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnTerminate;
    }
}