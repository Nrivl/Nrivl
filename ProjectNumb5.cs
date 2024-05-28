using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Human ensan1 = new Human();

            ensan1.Name = "Asghar";
            ensan1.Age = 17;
            ensan1.talking();
            ensan1.walking();

            Console.ReadKey();
        }
        public class Human
        {
            public string Name;
            public int Age = 0;

            public void walking()
            {
                Console.WriteLine(Name + " is walking");
            }
            public void talking() 
            {
                Console.WriteLine(Name + " is talking");
            }
        } 
    }
}
