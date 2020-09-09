using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;

namespace ConsoleApp1
{
    class InvalidNumberException : ApplicationException 
    {
        public string msg { get; set; }
        public InvalidNumberException()
        {
            msg = "The entered number should not be zero";
        }
    }
    class Exception
    {
        void Calculate()
        {
            double a, b,res;
            try 
            {
                Console.WriteLine("Enter 1st no.");
                 a = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter 2nd no.");
                 b = Convert.ToInt64(Console.ReadLine());
                if(a==0 || b==0)
                {
                    throw new InvalidNumberException();
                }
                res = a + b;
                Console.WriteLine("Sum is {0}",res);
                res = a * b;
                Console.WriteLine("Product is {0}", res);

            }
            catch (InvalidNumberException e)
            {
                Console.WriteLine(e.msg);
                Console.WriteLine("Enter 1st no.");
                a = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter 2nd no.");
                b = Convert.ToInt64(Console.ReadLine());
                res = a + b;
                Console.WriteLine("Sum is {0}", res);
                res = a * b;
                Console.WriteLine("Product is {0}", res);
            }
            
        }
        static void Main(string[] args)
        {
            Exception exception = new Exception();
            exception.Calculate();
            Console.ReadKey();
        }
    }
}
