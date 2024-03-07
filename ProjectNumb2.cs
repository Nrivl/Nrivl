using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            string ab ;

            Console.WriteLine("Enter the name of a day in week");

             ab = Console.ReadLine();


            ab = DaysOfWeek(ab);

            Console.ReadKey();

        }

        static string DaysOfWeek(string Days)
        {

            switch (Days)
	{

                case "Shanbe":
                     Console.WriteLine(1);
                    break ;
                case "Yekshanbe":
                    Console.WriteLine(2);
                    break;
                case "Doshanbe":
                    Console.WriteLine(3);
                    break;
                case "Seshanbe":
                    Console.WriteLine(4);
                    break;
                case "Charshanbe":
                    Console.WriteLine(5);
                    break;
                case "Panjshanbe":
                    Console.WriteLine(6);
                    break;
                case "Jome":
                    Console.WriteLine(7);
                    break;

		default:
                    Console.WriteLine("Khejalat Khejalat!!!!!!!!!!!!!!!!!!!");
                    break;
	}

            return Days;

        }
        }
    }
