using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankBalance
{
    class BankAccount
    {
        public string AccountNumber { get; }
        public double Balance { get; private set; }

        // List to store the operation log
        private List<string> operationLog;

        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            operationLog = new List<string>(); // Initialize the log
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                string logEntry = $"Deposit: {amount} грн on {DateTime.Now}. New Balance: {Balance} грн.";
                operationLog.Add(logEntry);
                MessageBox.Show($"Ваш рахунок {AccountNumber} поповнено на {amount} грн. Поточний баланс: {Balance} грн.");
            }
            else
            {
                MessageBox.Show("Сума поповнення має бути більше нуля.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                string logEntry = $"Withdrawal: {amount} грн on {DateTime.Now}. New Balance: {Balance} грн.";
                operationLog.Add(logEntry);
                MessageBox.Show($"З вашого рахунку {AccountNumber} знято {amount} грн. Поточний баланс: {Balance} грн.");
            }
            else if (amount <= 0)
            {
                MessageBox.Show("Сума зняття має бути більше нуля.");
            }
            else
            {
                MessageBox.Show("Недостатньо коштів на рахунку."); // Message for insufficient funds
            }
        }

        public void ShowAccountInfo()
        {
            Console.WriteLine($"Інформація про рахунок {AccountNumber}:");
            Console.WriteLine($"Баланс: {Balance} грн.");
        }

        // Method to get the operation log
        public List<string> GetOperationLog()
        {
            return operationLog;
        }
    }
}
