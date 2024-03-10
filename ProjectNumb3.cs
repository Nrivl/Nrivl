using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number");

            int number = Convert.ToInt32(Console.ReadLine());
            string[] Get = new string[number];

            Get = GiveNames(number);

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(Get[i]);
            }
            Console.ReadKey();
        }
        static string[] GiveNames(int studentsnumbers)
        {
            string[] studentsnames = new string[studentsnumbers];

            for (int i = 0; i < studentsnames.Length; i++)
            {
                Console.WriteLine("Enter Your Students Numbers");
                studentsnames[i] = Console.ReadLine();
            }
            return studentsnames;
        }
    }
}
