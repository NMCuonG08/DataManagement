using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Database
{
    internal class BankAccount
    {
        private int bankAccountID;
        private string accountName;
        private string bankName;
        private string accountNumber;
        private int employeeID; 
        public BankAccount() { }

        public BankAccount(int bankAccountID, string accountName, string bankName, string accountNumber, int employeeID)
        {
            this.BankAccountID = bankAccountID;
            this.AccountName = accountName;
            this.BankName = bankName;
            this.AccountNumber = accountNumber;
            this.employeeID = employeeID;
        }

        public int BankAccountID { get => bankAccountID; set => bankAccountID = value; }
        public string AccountName { get => accountName; set => accountName = value; }
        public string BankName { get => bankName; set => bankName = value; }
        public string AccountNumber { get => accountNumber; set => accountNumber = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
    }
}
