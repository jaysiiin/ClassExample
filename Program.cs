using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample_Fall2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the beginning of our class example.");
            Console.WriteLine();
            
            //our first person instance 
            Person thisPerson = new Person();
            //have to add name so it would print out 
            thisPerson.Greet("Jason");


            //our second person instance
            Person secondPerson = new Person(25, "Lupe", "brown", "Whattup");
            Console.WriteLine();
            secondPerson.Greet("Mike");
            Console.WriteLine();
        }
    }
}
