using System.Diagnostics.CodeAnalysis;

namespace Dart_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dartboard dartboard = new Dartboard();
            bool active;
            while (true)
            {
                Console.WriteLine("Here are three new throws");
                Number throw1 = dartboard.PossibleNumberList[dartboard.random(0, 61)];
                Number throw2 = dartboard.PossibleNumberList[dartboard.random(0, 61)];
                Number throw3 = dartboard.PossibleNumberList[dartboard.random(0, 61)];
                Console.WriteLine(throw1.Name + ", " + throw2.Name + ", " + throw3.Name); 
                active = true;

                while (active)
                {

                    Console.WriteLine("What is the total score:");
                    int guess = int.Parse(Console.ReadLine());
                    int sum = dartboard.calculator(throw1.Value, throw2.Value, throw3.Value);
                    if (guess == sum)
                    {
                        Console.WriteLine("Correct!");
                        Console.WriteLine();
                        active = false;
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }
            }
            
            
            

        }
    }
}
