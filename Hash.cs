using System;
namespace Simulation_Banking_Cash_Counter_Hash
{
    class Hash
    {
        int size;
        int[] element;
        int hashvalue;
        int nextSlot;
        int front;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="size"></param>
        public Hash(int size)
        {
            this.size = size;
            element = new int[size];
            hashvalue = 0;
            nextSlot = 0;
            front = 0;
        }
        /// <summary>
        /// Method to deposit the cash in hash
        /// </summary>
        /// <param name="balance">customer balance</param>
        public void Put(int balance)
        {
            hashvalue = balance % size;
            if (element[hashvalue] == 0)
            {
                element[hashvalue] = balance;
            }
            else
            {
                if (element[hashvalue] == balance)
                {
                    element[hashvalue] = balance;
                }
                else
                {
                    nextSlot = (hashvalue + 1) % size;
                    while (element[nextSlot] != 0 && element[nextSlot] != balance)
                    {
                        nextSlot = (nextSlot) % size;
                    }
                    if (element[nextSlot] == 0)
                    {
                        element[nextSlot] = balance;
                    }
                    else
                    {
                        element[nextSlot] = balance;
                    }
                }
            }

        }
        /// <summary>
        /// Method to withdraw the cash from hash
        /// </summary>
        public void Remove()
        {


            int value = element[front];
            this.front = this.front + 1;
            //  size = size - 1;


        }
        /// <summary>
        /// method to display the cash in hash 
        /// </summary>
        public void Display()
        {
            for (int i = front; i < size; i++)
            {
                Console.WriteLine(element[i]);
            }
        }
    }
}
