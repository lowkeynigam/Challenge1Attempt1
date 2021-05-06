using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Challenge1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type 'roll' to begin");
            string start = Console.ReadLine();
            Random rand = new Random(); 
            List<int> mynumbers = new List<int>();
            Dictionary<int, int> numberDict = new Dictionary<int, int>(); 
            bool isWordStop = false;
            
            if (start == "roll")
            {
                while (!isWordStop)
                { 
                int number = rand.Next(1,7);
                mynumbers.Add(number); 
                Console.WriteLine("Type 'roll' to continue, or 'stop' to stop");
                string word = Console.ReadLine();  
                int sum = mynumbers.Sum();
                if (word == "stop")
                {
                    isWordStop = true;
                    Console.WriteLine("Here are your rolls, and the their sum");
                    foreach (int item in mynumbers)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("SUM: " + sum);
                }
                }
            }


        }
    }
}
