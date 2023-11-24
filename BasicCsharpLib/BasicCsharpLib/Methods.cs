using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpLib
{
    public class Methods
    {
        public void CalculateFactorial()
        {
            int number;
            int fact = 1;
            Console.WriteLine("Enter the number to calculate factorial");
            number=int.Parse(Console.ReadLine());
            for(int i=1;i<number;i++)
            {
                fact=fact*i;
                Console.WriteLine("Factorial of number: \t {0}",fact);
            }
        }
    }
}
