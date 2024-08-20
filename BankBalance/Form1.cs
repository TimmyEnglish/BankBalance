using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankBalance
{
    public partial class Form1 : Form
    {
        private BankAccount account;
        public Form1()
        {
            InitializeComponent();
            account = new BankAccount("123456789", 1000);
            lblAccountInfo.Text = $"Account Number: {account.AccountNumber}\nBalance: {account.Balance} грн.";
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAmount.Text, out double amount))
            {
                account.Deposit(amount);
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAmount.Text, out double amount))
            {
                account.Withdraw(amount);
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            lblAccountInfo.Text = $"Account Number: {account.AccountNumber}\r\nBalance: {account.Balance} грн.";
            var log = account.GetOperationLog();
            foreach (var entry in log)
            {
                lstOperationLog.Items.Add(entry);
            }
        }
    }
}
