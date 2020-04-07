using System;

namespace Simulation_Banking_Cash_Counter_Hash
{
    class CashCounter
    {
        /// <summary>
        /// Constant
        /// </summary>
        private static int accountantBalance = 5000;
        /// <summary>
        /// Variable
        /// </summary>
        private static int totalAccountantBalance = 0;
        private static string name;
        private static int accountNo;
        private static int count;
       
        static void Main(string[] args)
        {
            Console.WriteLine("!!Welcome to Banking Simulator Cash Counter !!");
            Console.WriteLine("no. of accountants");
            int numberOfAccountants = Convert.ToInt32(Console.ReadLine()); ;
            Hash myStack = new Hash(numberOfAccountants); // object creation of Hash
            Banking bank = new Banking(); // object creation of Banking
            int choice = 0;
            do
            {

                try
                {
                    Console.WriteLine("---------Bank Cash Counter ---------");
                    Console.WriteLine("1.Deposite Money");
                    Console.WriteLine("2.Withdraw Money");
                    Console.WriteLine("enter your choice:");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the accountant name");
                            name = bank.setname();
                            Console.WriteLine("Enter the account number");
                            accountNo = bank.setAccountNo();
                            Console.WriteLine("Enter Deposite amount: ");
                            int depositeCash = Convert.ToInt32(Console.ReadLine());
                            totalAccountantBalance = bank.cashDeposite(depositeCash, accountantBalance);
                            myStack.Put(totalAccountantBalance);
                            myStack.Display();
                            myStack.Remove();
                            depositeCash = 0;
                            break;

                        case 2:
                            Console.WriteLine("Enter the accountant name");
                            name = bank.setname();
                            Console.WriteLine("Enter the account number");
                            accountNo = bank.setAccountNo();
                            Console.WriteLine("Enter withdraw amount: ");
                            int withdrawCash = Convert.ToInt32(Console.ReadLine());
                            if (accountantBalance < withdrawCash)
                            {
                                Console.WriteLine("!!** insufficient balance to withdraw **!!\n");
                            }
                            else
                            {
                                totalAccountantBalance = bank.cashWithdraw(withdrawCash, accountantBalance);
                                myStack.Put(totalAccountantBalance);
                                myStack.Display();
                                myStack.Remove();
                                withdrawCash = 0;
                            }
                            break;
                    }
                    count++;
                }
                catch
                {
                    Console.WriteLine("!!**Enter appropriate value.**!!\n");
                }
            } while (count < numberOfAccountants);
        }
    }
}
