using System;
namespace Simulation_Banking_Cash_Counter_Hash
{
        class Banking
        {
            /// <summary>
            /// Method to account holder how much cash withdraw
            /// </summary>
            /// <param name="cashToWithdraw">cash withdraw amount</param>
            /// <param name="currentBalance">Current balance in account</param>
            /// <returns></returns>
            public int cashWithdraw(int cashToWithdraw, int currentBalance)
            {
                currentBalance = currentBalance - cashToWithdraw;
                return currentBalance;
            }

            /// <summary>
            /// Method to account holder how much cash deposit 
            /// </summary>
            /// <param name="cashToDeposite">Cash deposit amount</param>
            /// <param name="currentBalance">current balance</param>
            /// <returns></returns>
            public int cashDeposite(int cashToDeposite, int currentBalance)
            {
                currentBalance = currentBalance + cashToDeposite;
                return currentBalance;
            }
            /// <summary>
            /// Method to take user input account holder name
            /// </summary>
            /// <returns></returns>
            public string setname()
            {
                string name = Console.ReadLine();
                return name;
            }
            /// <summary>
            ///Method to  take user input account holder account number
            /// </summary>
            /// <returns></returns>
            public int setAccountNo()
            {
                int accountNo = Convert.ToInt32(Console.ReadLine());
                return accountNo;
            }
        }
}


