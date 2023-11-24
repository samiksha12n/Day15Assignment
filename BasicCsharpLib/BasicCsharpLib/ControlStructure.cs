using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpLib
{
    public class ControlStructure
    {
        public void EvenOdd()
        {
            int n1;
            Console.WriteLine("Enter the number");
            n1=int.Parse(Console.ReadLine());
            if (n1%2 == 0)
            {
                Console.WriteLine("The Entered number {0} is Even",n1);
            }
            else
            {
                Console.WriteLine("The entered number {0} is Odd",n1);
            }
        }
    }
}
