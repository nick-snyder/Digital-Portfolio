using System;

namespace AP_CSP_Create_Performance_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correct = false;
            
            
            while (correct == false)
            {
                string decision = Ask();

                switch (decision)
                {
                case "math":
                    SimpleArithmetic();
                    correct = true;
                    break;
                case "trigonometry":
                    Trigonometry();
                    correct = true;
                    break;
                case "convert":
                    Convertion();
                    correct = true;
                    break;
                default:
                    Console.WriteLine("Check your spelling and try again");
                    break;
                }
            }
        }

        static string Ask()
        {
            Console.Write(@"What would you like to do today? You have three options

Simple math (+, -. *, /, %)
Trigonometry
Convert

Your selection:");

            return Console.ReadLine();
        }

        static void SimpleArithmetic()
        {
            Console.Write("555555555");
        }

        static void Trigonometry()
        {
            Console.Write("Trug");
        }

        static void Convertion()
        {
            Console.Write("vert");
        }        
    }
}

