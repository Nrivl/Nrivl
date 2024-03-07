using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
       {

           double Numb1;
           double Numb2;
           double result;

           Console.WriteLine("Enter Number 1");
           Numb1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Enter Number 2");
           Numb2 = Convert.ToDouble(Console.ReadLine());

           result = Power(Numb1, Numb2);

           Console.WriteLine(result);

           Console.ReadKey();


        }
        static double Power(double x , double y)
        {

            double a = Math.Pow(x, y);
            return a;

        }
    }
}
