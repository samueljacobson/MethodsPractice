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

            string myBirthMonth = "September";
            string myFriendsBirthMonth = "December";
            string myVehicle = Vehicle(myBirthMonth);
            string myFriendsVehicle = Vehicle(myFriendsBirthMonth);

            Console.WriteLine("My future vehicle is {0} and Jordan's future vehicle is {1}.", myVehicle, myFriendsVehicle);
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

    }
}
