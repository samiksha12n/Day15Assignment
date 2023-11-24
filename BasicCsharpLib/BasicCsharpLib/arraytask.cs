using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpLib
{
    public class arraytask
    {
        int[] array = {10,50,78,89,12};
        int sum;
        int avg;
        public void Sum()
        {
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                Console.WriteLine("Sum of array elements is :\t{0}",sum);
            }
        }
        public void Avg()
        {
            for(int i = 0;i < array.Length;i++)
            {
                avg += array[i]/array.Length;
                Console.WriteLine("Average of array elements: \t{0}", avg);
            }
        }

    }
}
