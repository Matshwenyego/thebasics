using System;
using System.IO;

//functions for/foreach/switch/do/while
//arrays 2d/3d
//oject orientated structure (invoking functions)
//validation try

namespace thebasics
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            string line;
            string fileName = "details.txt";
            StreamReader read = new StreamReader(fileName);

            Console.WriteLine("Welcome to C# demo systems");
            Console.WriteLine("Please enter password to continue...");
            password = Console.ReadLine();



            switch (additionFunction(password)) {
                case true:

                    Console.WriteLine("Successfully logged in");

                    while (!read.EndOfStream) {

                        line = read.ReadLine();
                        Console.WriteLine(line);

                    }

                    read.Close();

                    break;
                case false:
                    Console.WriteLine("Oops!! you've entered an incorrect password");

                    break;
            }

            Console.ReadLine();
        }

        static bool additionFunction(string pass)
        {
            bool state = false;
            string systemPass = "Pa$$w0rd";


            if (systemPass == pass)
            {
                state = true;
            }
            else
            {
                state = false;
            }

            return state;
        }

        static void viewType(string file) {
            char type;

            Console.WriteLine("Select view type.. |n-name|s-surname|sn-student number|c-course|ms-major subjects|");
            type = Convert.ToChar(Console.ReadLine());



        }
    }
}
