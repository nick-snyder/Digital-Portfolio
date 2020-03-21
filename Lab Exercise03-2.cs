using System;

namespace Exercise03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            if (numberTwo == 0)
            {
                Game();
                
                Console.Write("Enter a number: ");
                numberOne = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                numberTwo = Convert.ToInt32(Console.ReadLine());

                Part2(numberOne, numberTwo);
            }
            else
            {
                Part2(numberOne, numberTwo);
            }
        }
        static void Game()
        {
            Console.Write(
@"Wow, It looks like you've triggered my mandatory if/else statement!

    Did you know that Johns Hopkins University was named after philanthropist Johns Hopkins?
    But that begs the question, how does someone get the name Johns Hopkins?
    The name comes from Johns Hopkins' grandfather, who's also named Johns Hopkins!
    Now THAT name comes from the last names of Margeret Johns and Gerald Hopkins, Johns Hopkins' parents.

And that's it. It sort of asked for a game, so here it is.
Oh and while you're here, here's the madatory loop as well:

");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"    Mandatory Loop {i + 1}");
            }

            Console.WriteLine("\nAnd now its time to return to our regularly scheduled programming. get it? programming");
        }
        static void Part2(int numberOne, int numberTwo)
        {
            Console.WriteLine($"\n    Sum is: {numberOne + numberTwo}\n    Difference is: {numberOne - numberTwo}\n    Product is: {numberOne * numberTwo}\n    Quotient is: {numberOne / numberTwo}\n    Remainder is: {numberOne % numberTwo}");

            if (numberOne != 0)
            {
                Hypotenuse(numberOne, numberTwo);
                Angles(numberOne, numberTwo);
            }

            Console.Write("\nPress any key to continue . . .");
            string aaaa = Console.ReadLine();
        }
        static void Hypotenuse(int numberOne, int numberTwo)
        {
            double a = Convert.ToDouble(numberOne);     // Converts int to double
            double b = Convert.ToDouble(numberTwo);

            double aSquared = Math.Pow(a, 2);   // Raises to power of two
            double BSquared = Math.Pow(b, 2);

            double cSquared = aSquared + BSquared;      // Pythagorean's Theorem

            double c = Math.Sqrt(cSquared);     // Un-squares c

            double cRounded = Math.Round(c, 2);         // Rounds c to two decimal places

            Console.WriteLine($"    Hypotenuse Leg: {cRounded}");
        }
        static void Angles(int numberOne, int numberTwo)
        {
            double a = Convert.ToDouble(numberOne);     // Converts int to double
            double b = Convert.ToDouble(numberTwo);

            double angleOppositeToSideA = Math.Atan(b / a);     // Inverse tangent of angles, output is in radians
            double angleOppositeToSideB = Math.Atan(a / b);

            double angleAToDegrees = 180 / 3.1415 * angleOppositeToSideA;   // Converts radians to degrees
            double angleBToDegrees = 180 / 3.1415 * angleOppositeToSideB;

            double angleARoundedToTwoDecimalPlaces = Math.Round(angleAToDegrees, 2);    // Rounds angle measurement to two decimal places
            double angleBRoundedToTwoDecimalPlaces = Math.Round(angleBToDegrees, 2);

            Console.WriteLine($"    Angle measurements of {angleARoundedToTwoDecimalPlaces}, {angleBRoundedToTwoDecimalPlaces}, and 90 degrees");
        }
    }
}