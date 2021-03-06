﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample_Fall2016
{
    class Person
    {
        //fields
        private int age;
        private string name;
        private string eyeColor;
        public string greeting;


        //properties

        public int Age
        {

            get { return this.age; }
            set { this.age = value; }


        }


        //constructors

        public Person()
        {
            //can add this. to make SURE it make it consider the private classes above
            age = 20;
            name = "John Doe";
            eyeColor = "brown";
            greeting = "nice to meet you.";

        }

        public Person(int newAge, string newName, string newEyeColor, string newGreeting)
        {
            age = newAge;
            name = newName;
            eyeColor = newEyeColor;
            greeting = newGreeting;



        }



        //method


        //This method takes a string input then prints out a greeting for a person
        public void Greet(string name)
        {
        //provides an output for this method 
            Console.WriteLine("Hello " + name + ", " + greeting);
            Console.WriteLine(Description());
        }

        //returns the users age and name in a description in a string
        private string Description()
        {
            // the temporary string we're using to build our temp string
            string tempString;
            tempString = "I am " + name + " and I am " + age + " years old.";

            //reurning the results
            return tempString;

        }

    }
}
