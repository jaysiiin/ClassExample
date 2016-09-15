using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample_Fall2016
{
    class Person
    {

        private int age;
        private string name;
        private string eyeColor;
        public string greeting;

        public void Greet()
        {
            Console.WriteLine(greeting);
        }

        private string Description()
        {
            string tempString;
            tempString = "Hello I am " + name + " and I am " + age + " years old.";
            return tempString;

        }

    }
}
