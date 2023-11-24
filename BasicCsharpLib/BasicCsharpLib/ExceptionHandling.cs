using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpLib
{
    public class ExceptionHandling
    {
        public class InvalidAge : Exception
        {
            public InvalidAge(string message) : base(message)
            {

            }
            public void valid()
            {
                int age;
                try
                {
                    Console.WriteLine("Enter Age");
                    age = int.Parse(Console.ReadLine());
                    if (age <= 0 || age >= 150)
                    {
                        throw new InvalidAge("Age must be not negative or greater than 150");

                    }
                    else if (age >= 18)
                    {
                        Console.WriteLine("Eligible to Cast Vote");

                    }
                    else
                    {
                        Console.WriteLine("Not Eligible to cast vote");
                    }
                    Console.WriteLine("Age \t" + age);
                }
                catch (InvalidAge ex)
                {
                    Console.WriteLine("Invalid Age Error !!!" + ex.Message);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("error !!!" + ex.Message);
                }
                finally
                {
                    Console.WriteLine("End of Program !!!");
                    Console.ReadKey();
                }
            }
        }


    }
}

