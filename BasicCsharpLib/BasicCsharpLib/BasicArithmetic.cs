using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpLib
{
    public class BasicArithmetic
    {
        public void Add(int n1, int n2)
        {
            double result;
            result = n1 + n2;
            Console.WriteLine("Result after adding {0} and {1} = \t{2}", n1, n2, result);
        }
        public void Sub(int n1, int n2)
        {
            double result;
            result = n1 - n2;
            Console.WriteLine("Result After substraction {0} and {1}=\t{2} ", n1, n2, result);
        }
        public void Multi(int n1, int n2)
        {
            double result;
            result = n1 * n2;
            Console.WriteLine("Result After multiplication {0} and {1}=\t{2} ", n1, n2, result);
        }
        public void Div(int n1, int n2)
        {
            double result;
            if (n1 == 0 || n2 == 0)
            {
                Console.WriteLine("The entered number is 0 so cannot be divisible");

            }
            else
            {
                result = n1 / n2;
                Console.WriteLine("Result After division {0} and {1}=\t{2} ", n1, n2, result);
            }
        }
    }
}
