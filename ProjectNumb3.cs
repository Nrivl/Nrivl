using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Your Student Numbers");

            string[] studentsnames = new string[Convert.ToInt32(Console.ReadLine())];

            int numbersofstudents = studentsnames.Length;

            Get(numbersofstudents);
            for (int i = 0; i < studentsnames.Length; i++)
            {

                Console.WriteLine(studentsnames);
                
            }
            Console.ReadKey(); 

        }
        static string[] Get(int Studednts)
        {
            int numbers = Studednts ;

            string[] studentrock = new string[numbers];
            for (int i = 0; i < studentrock.Length; i++)
            {

                Console.WriteLine("Enter Your Students Names");
                studentrock[i] = Console.ReadLine();
                
            }

            return studentrock;
        }
    }
}
