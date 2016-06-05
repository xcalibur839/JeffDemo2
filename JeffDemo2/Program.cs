using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Show a good variety of data types
            int firstValue, secondValue, finalValue;
            float firstFloatValue, secondFloatValue, finalFloatValue;
            char sign;
            //Maybe introduce date first, then timezone as an extension
            TimeZone timeZone = TimeZone.CurrentTimeZone;
            DateTime now;

            Console.WriteLine("Enter the first number");            
            //firstValue = Console.ReadLine();
            //Use the above to demonstrate what won't work and why
            int.TryParse(Console.ReadLine(), out firstValue);

            Console.WriteLine("Enter the second number");
            int.TryParse(Console.ReadLine(), out secondValue);

            //Do a few arithmetic examples, let him experiment 
            finalValue = firstValue - secondValue;

            //Play around with timezone and demonstrate return types and how to view them in VS
            //now = DateTime.Now;
            now = timeZone.ToLocalTime(DateTime.Now);

            //Foreshadowing for next lesson, don't go too far in to detail just yet
            sign = finalValue > 0 ? '+' : '-';

            Console.WriteLine($"The total is {finalValue}");
            Console.WriteLine($"The sign of this operation is {sign}");
            //One more example of the ternary operator, with demonstration of resolving with and without parentheses
            Console.WriteLine("That makes the result {0}", finalValue > 0 ? "positive" : "negative");
            Console.WriteLine($"This calculation was performed at {now.ToLongTimeString()}");
            Console.ReadLine();
        }
    }
}
