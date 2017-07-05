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

            //string[] vacationSpots = { "Paris", "Scottish Highlands", "Laguna Beach", "Iceland", "Sidney", "Seattle", "Cancun", "Hawaii", "Sandusky", "Vegas" };
            //Console.WriteLine(vacationSpots[0]);
            //Console.WriteLine(vacationSpots[9]);

            //int[] childAges = { 2,4,1 };
            //Console.WriteLine("Callum is " + childAges[0]);
            //Console.WriteLine("Noah is " + childAges[1]);
            //Console.WriteLine("Nolan is " + childAges[2]);

            //double[] gradePointAverage = { 4.0, 3.5, 3.0, 2.5, 2.0, 1.5, 1.0, 0.5 };

            //char[] peopleNames = { 'P', 'V', 'V', 'J' };
            //Console.WriteLine(peopleNames);

            //Console.WriteLine("{0}, {1}, {2}, {3}", peopleNames[0], peopleNames[1], peopleNames[2], peopleNames[3]);
            ////This method could pull values from different arrays into one line

            //int[] numberOfSeats = new int[21];//Creates a dresser with 21 drawers
            //string[] studentsInClass = new string[21];

            ////nameOfArray[index] = Element;
            //studentsInClass[0] = "Jordan";

            //Console.WriteLine("Please enter in the name of the next student: ");
            //studentsInClass[1] = Console.ReadLine();
            //Console.WriteLine("The student in the second seat is {0}.", studentsInClass[1]);

            ////Ask user for input
            //Console.WriteLine("Please enter the age of the person in the first seat: ");
            ////Create a new int array with 21 spots and call it ageOfStudents
            //int[] ageOfStudents = new int[21];
            ////Assign the value of the int at the 0 index of ageOfStudents to..
            ////..the user's input converted into an int
            //ageOfStudents[0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("The age of the student in the first seat is " + ageOfStudents[0]);
            ////Create a new string variable and set it equal to the int at the index of 0..
            ////..and convert it into a string
            //string firstIndex = ageOfStudents[0].ToString();



            //char[] middleName = { 'C', 'h', 'a', 'r', 'l', 'e', 's' };
            //Console.WriteLine(middleName.Length);

            ////Declare and initialize a string array
            ////Using the length property, print the second to last element in the array

            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick Fil-A" };
            //int numRest = restaurantsInMall.Length;
            //Console.WriteLine(restaurantsInMall[numRest - 2]);

            ////IndexOf is a method used to search an array for a specified value and returns the index position of the first matching value found.
            //int[] bestYearsEver = { 1985, 1999, 1991, 2000, 1985 };
            //Console.WriteLine(Array.IndexOf(bestYearsEver, 1985));
            ////LastIndexOf is a method used to search an array for a specified value and returns the index position of the last matching value found.
            //Console.WriteLine(Array.LastIndexOf(bestYearsEver, 1985));

            ////Reverse Method
            //int[] palindromeNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(palindromeNumbers[0]);
            //Array.Reverse(palindromeNumbers);
            //Console.WriteLine(palindromeNumbers[0]);

            ////Sort
            ////Will sort numbers in an array from lowest to highest
            ////will sort char's and strings in alphabetical order from a-z
            //string[] powerRangers = { "green", "yellow", "pink", "blue", "red", "black" };
            //Console.WriteLine(powerRangers[0]);
            //Array.Sort(powerRangers);
            //Console.WriteLine(powerRangers[0]);

            string[] firstNames = { "John", "Paul", "Derek", "Frank", "Mitch", "Pierre" };
            Console.WriteLine(Array.IndexOf(firstNames, "Frank"));
            Console.WriteLine(Array.IndexOf(firstNames, "Pierre"));

            int[] luckyNumbers = { 3, 3, 6, 6, 7, 7, 8, 8, 9, 9 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers, 8));

            char[] alphabetChars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
            Console.WriteLine(alphabetChars[0]);
            Array.Reverse(alphabetChars);
            Console.WriteLine(alphabetChars[0]);

            string[] studentNames = { "Vik", "Vivian", "Joe", "Pete", "Nick", "Hope", "Iris" };
            Array.Sort(studentNames);
            Console.WriteLine(studentNames[0]);
            Console.WriteLine(studentNames[6]);

            Console.WriteLine("Please enter your favorite number: ");
            //Homework



        }
    }
}
