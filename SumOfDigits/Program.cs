using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalDigits = 0;
            
            Console.WriteLine("Please enter a string containing digits:");
            string userInput = Console.ReadLine();

            

            foreach (char i in userInput)
            {
                if (Regex.IsMatch(i.ToString(), @"^\d+$")) { totalDigits += int.Parse(i.ToString()); }
                
            }

            Console.WriteLine("The sum is:" + totalDigits);
            
            Console.ReadKey();
        }
    }
}
