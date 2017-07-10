using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods are a tool to create resuable pieces of code
            //Methods are a way of collecting a series of instructions and then call them when needed
            //Methods are always part of a class - children of classes
            //This means a method will never be created inside another method or member of the class
            //However, methods are frequently called (invoked) inside of another class or method

            Console.WriteLine("Please enter the first number to be added.");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine(("Please enter the second number to be added."));
            int numberTwo = int.Parse(Console.ReadLine());

            int answer = Add(numberOne, numberTwo);
            Console.WriteLine("The sum of your two numbers is " + answer);

            //int answer = Add(5, 7);
            //Console.WriteLine(answer);

            RobotWarning("Will Robinson");
            Useless();

            //Fortune teller
            string myBirthMonth = "September";
            string myFriendsBirthMonth = "December";
            string myVehicle = Vehicle(myBirthMonth);
            string myFriendsVehicle = Vehicle(myFriendsBirthMonth);

            Console.WriteLine("My future vehicle is {0} and Jordan's future vehicle is {1}.", myVehicle, myFriendsVehicle);

            //Favorite food
            Console.WriteLine("What is your name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();
            FavoriteFood(firstName, food);

            //Retirement age
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            RetirementCalculator(age);

            //Monthly wages
            double hoursWorked = 42.3d;
            double hourlyWage = 12.50d;
            Console.WriteLine("Your monthly wage is {0}.", WageCalculator(hoursWorked, hourlyWage));

            //Difference
            Console.WriteLine("Choose the first number.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose the second number.");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose the third number.");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("The difference of the three numbers is {0}", Subtract(number1, number2, number3));

            //Favorite letter
            Console.WriteLine("What is your favorite letter?");
            char favLetter = char.Parse(Console.ReadLine());
            Letter(favLetter);
        }

        //Method header
        //Access Modifier - Return Type - Method Name - Parentheses (sometimes with parameters)
        public static int Add(int firstNumber, int secondNumber)
        {
            //Method body
            //A complete method - header and body - is called a method declaration

            int sum = firstNumber + secondNumber;
            return sum;
            //The "return" keyword takes whatever value is determined by using this method and sends that value
            //back to where call method
        }
        public static string Vehicle(string birthMonth)
        {
            string vehicleFortune;
            if (birthMonth.ToUpper() == "SEPTEMBER" || birthMonth.ToUpper() == "OCTOBER")
            {
                vehicleFortune = "Hoverboard";
            }
            else
            {
                vehicleFortune = "SUV";
            }
            return vehicleFortune;
        }

        //If you have a method that does not have a return value, use keyword "void"
        //When using void return type, don't need to use the keyword "return"

        public static void RobotWarning(string name)
        {
            Console.WriteLine("Danger, " + name + "!!");
        }
        public static void Useless()    //no parameters, will simply print below
        {
            Console.WriteLine("Blah blah blah");
        }

        //Create a method called FavoriteFood
        //It should take two string parameters. One representing a name, and the other represting a favorite food.
        //The return type should be void
        //The method should concatenate
        public static void FavoriteFood(string firstName, string food)
        {
            Console.WriteLine(firstName + "'s favorite food is " + food + ".");
        }

        //Create a method called RetirementCalculator
        //It should take an int as a parameter representing the user's age
        //The method should calculate how many more years until the user retires using 65 as the age of retirement
        //The return type should not be void (int)
        //Once it calculates the user's reitrement age it should print "The user will retire in X years."
        public static int RetirementCalculator(int age)
        {
            int retirementAge = 65 - age;
            Console.WriteLine("The user will retire in " + retirementAge + " years.");
            return retirementAge;
        }

        //Method wage calculator
        public static double WageCalculator(double hoursWorkedWeekly, double hourlyWage)
        {
            //This method should calculate the monthly wage
            double monthlyWage = (hoursWorkedWeekly * hourlyWage * 52) / 12;
            return monthlyWage;
        }

        //Create 2 methods of your choosing. At least one of the methods should have a non-void return type.
        //Both should take at least one parameter.
        //Your method should only aim to accomplish one thing.

        public static int Subtract(int number1, int number2, int number3)
        {
            int diff = number1 - number2 - number3;
            return diff;
        }
        public static void Letter(char favLetter)
        {
            Console.WriteLine("My favorite letter is " + favLetter);
        }

    }
}
