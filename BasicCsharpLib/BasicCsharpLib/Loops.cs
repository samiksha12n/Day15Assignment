using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpLib
{
    public class Loops
    {
        public void print()
        {
           
            for (int i = 0; i < 10; i++)
            {
                while (i >= 10)
                {
                    Console.WriteLine("The numbers from 1 to 10 printed using Loop", i);
                    i++;
                }
            }
        }
    }
}
