using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicCsharpLib;

namespace LinkedBasicCsharpLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("Choose Task to perform");
                Console.WriteLine("1.Helloworld 2.Basic Arithmetic 3.Control Structure 4.Loops 5.Array 6.Methods 7.ExceptionHandling ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Helloworld.Display();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the value for num1");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the value for num2");
                            int num2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("1.Add 2.Diff 3.Multi 4.Div 5.Avg");
                            int ops = int.Parse(Console.ReadLine());
                            BasicArithmetic calc = new BasicArithmetic();
                            switch (ops)
                            {
                                case 1:
                                    {
                                        calc.Add(num1, num2);
                                        break;
                                    }
                                case 2:
                                    {
                                        calc.Sub(num1, num2);
                                        break;
                                    }
                                case 3:
                                    {
                                        calc.Multi(num1, num2);
                                        break;
                                    }
                                case 4:
                                    {
                                        calc.Div(num1, num2);
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Invalid operation choice!!!");
                                        break;
                                    }
                            }
                            break;
                        }
                    case 3:
                        {

                            ControlStructure ct = new ControlStructure();
                            ct.EvenOdd();
                            break;
                        }
                    case 4:
                        {
                            Loops lp = new Loops();
                            lp.print();
                            break;
                        }
                    case 5:
                        {
                            arraytask arr = new arraytask();
                            arr.Sum();
                            arr.Avg();
                            break;
                        }
                    case 6:
                        {
                            Methods mt = new Methods();
                            mt.CalculateFactorial();
                            break;
                        }
                    case 7:
                        {
                            ExceptionHandling exp = new ExceptionHandling();
                            exp.EnterAge();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice");
                            break;
                        }

                }
                Console.WriteLine("Do you wanna continue.....if yes press y");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");

            Console.ReadKey();
        }
    }
}



