using System;

namespace Assignment_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stayAlive = true;
            while (stayAlive)
            {
                try
                {
                    Console.Write("Enter the operator here  (+, -, *, /, % or x to exit): ");
                    string Operator = (Console.ReadLine() ?? "");

                switch (Operator)
                {
                    case "+": //Additive
                            double ResponseAdditive = RunAdditiveMethod();
                        Console.WriteLine("The answer is: " + ResponseAdditive);
                        break;

                    case "-": //Subtraction
                              double ResponseSubtraction = RunSubtractionMethod();
                            Console.WriteLine("The answer is: " + ResponseSubtraction);
                        break;

                    case "*": //Multiplication
                              double ResponseMultiplication = RunMultiplicationMethod();
                            Console.WriteLine("The answer is: " + ResponseMultiplication);
                            break;

                    case "/": //Division
                            //
                              double ResponseDivision = RunDivisionMethod();

                            Console.WriteLine("The answer is: " + ResponseDivision);
                        break;

                    case "%": //Percentage
                              //RunPercentageMethod();
                        break;

                        case "x":
                            stayAlive = false;
                            if (Operator == "x")
                            {
                                stayAlive = false;
                                return;
                            }
                            break;

                        default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This is a invalid equationform!");
                        break;
                }
                Console.ResetColor();
                Console.WriteLine("Hit any key to continue!");
                Console.ReadKey();
                Console.Clear();
            }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid equationform!");
                    Console.ResetColor();
                }
            }
        }
        private static double RunAdditiveMethod()
        {
            Console.Write("\n" + "Enter first number here: ");
            double numberOne = double.Parse(Console.ReadLine() ?? "");

            Console.Write("\n" + "Enter the next number here: ");
            double numberTwo = double.Parse(Console.ReadLine() ?? "");

            double RunAdditiveMethod = numberOne + numberTwo;

            return RunAdditiveMethod;
        }
        private static double RunSubtractionMethod()
        {
            Console.Write("\n" + "Enter first number here: ");
            double numberOne = double.Parse(Console.ReadLine() ?? "");

            Console.Write("\n" + "Enter the next number here: ");
            double numberTwo = double.Parse(Console.ReadLine() ?? "");

            double RunSubtractionMethod = numberOne - numberTwo;

            return RunSubtractionMethod;
        }
        private static double RunMultiplicationMethod()
        {
            Console.Write("\n" + "Enter first number here: ");
            double numberOne = double.Parse(Console.ReadLine() ?? "");

            Console.Write("\n" + "Enter the next number here: ");
            double numberTwo = double.Parse(Console.ReadLine() ?? "");

            double RunMultiplicationMethod = numberOne * numberTwo;

            return RunMultiplicationMethod;
        }
        private static double RunDivisionMethod()
        {
            Console.Write("\n" + "Enter first number here: ");
            double numberOne = double.Parse(Console.ReadLine() ?? "");

            Console.Write("\n" + "Enter the next number here: ");
            double numberTwo = double.Parse(Console.ReadLine() ?? "");
            if (numberTwo == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oh oh! Can't divide by 0! Please try something else!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }
            double RunDivisionMethod = numberOne / numberTwo;

            return RunDivisionMethod;


            //double RunDivisionMethod = numberOne / numberTwo;

            //return RunDivisionMethod;
        }
    }

}
