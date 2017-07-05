using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Declaring an arrary without initializing
            //int[] myFirstArray;
            ////Declaring and initializing a second array
            //string[] myStringArray = { "First", "Second", "Third", "Fourth" };
            ////Declare and initialize 
            //char[] myLastName = { 'W', 'i', 's', 'e' };
            ////Make console print elements of array
            //Console.Write(myLastName[0]);
            //Console.Write(myLastName[1]);
            //Console.Write(myLastName[2]);
            //Console.Write(myLastName[3]);

            //Create following arrays and print using the correct index numbers
            //Array of top 10 vacation spots
            //Print the first and last vacation spots
            //Array of the ages of three children you know
            //Print each child's age
            //Array of GPA's on a 4.0 scale of 8 students - dont have to print
            //Array of the first letter of four of your classmate's names who are sitting near you
            //Print all four on the same line

            string[] vacationSpots = { "Paris", "Scottish Highlands", "Laguna Beach", "Iceland", "Sidney", "Seattle", "Cancun", "Hawaii", "Sandusky", "Vegas" };
            Console.WriteLine(vacationSpots[0]);
            Console.WriteLine(vacationSpots[9]);

            int[] childAges = { 2,4,1 };
            Console.WriteLine("Callum is " + childAges[0]);
            Console.WriteLine("Noah is " + childAges[1]);
            Console.WriteLine("Nolan is " + childAges[2]);

            double[] gradePointAverage = { 4.0, 3.5, 3.0, 2.5, 2.0, 1.5, 1.0, 0.5 };

            char[] peopleNames = { 'P', 'V', 'V', 'J' };
            Console.WriteLine(peopleNames);

            Console.WriteLine("{0}, {1}, {2}, {3}", peopleNames[0], peopleNames[1], peopleNames[2], peopleNames[3]);
            //This method could pull values from different arrays into one line


        }
    }
}
