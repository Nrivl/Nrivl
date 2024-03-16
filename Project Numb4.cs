using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            Human human2 = new Human();

            human1.Name = "Rick ";
            human1.Eat();
            human1.Sleep();

            human2.Name = "Morty ";
            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }

    public class Human // here my class is about a human
    {
        // we use class if we ever needed to change anything in your code it would be easier

        public string Name;
        public int age;

        //this section is my code field what it has 

        public void Eat() // this section called ,Method what my code does like eating and sleeping
        {
            Console.WriteLine(Name + "Is Eating");
        }
        public void Sleep() // this section called ,Method what my code does like eating and sleeping
        {
            Console.WriteLine(Name + "Is Sleeping");
        }
    }
}
