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
                            // <Summary> //
                            //Takes first and second numbers here, adds them together, 
                            //then sends them down to the RunAdditiveMethod Method.
                            Console.Write("\n" + "Enter first number here: ");
                            double numberOne = double.Parse(Console.ReadLine() ?? "");

                            Console.Write("\n" + "Enter the next number here: ");
                            double numberTwo = double.Parse(Console.ReadLine() ?? "");

                            double Answer = numberOne + numberTwo;

                            RunAdditiveMethod(Answer);
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
                            if (ResponseDivision == 0)
                            {
                                Console.Clear();
                                break;
                            }

                            Console.WriteLine("The answer is: " + ResponseDivision);
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
                    Console.WriteLine("\nHit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid equationform!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.ResetColor();
                }
            }
        }
        private static void RunAdditiveMethod(double Answer)
        {

            Console.Write("\n" + "The answer is: " + Answer  + ", Would you like to add more numbers? y/n: ");
            string Operator = (Console.ReadLine() ?? "");
            switch (Operator)
            {
                case "n":
                    if (Operator == "n")
                    {
                        Console.Clear();
                        return;
                    }
                    break;
                case "y":
                    RunAdditiveMethodLoop(Answer);
                    break;
                default:
                    break;
            }
            return;
            }

        private static double RunAdditiveMethodLoop(double Answer)
        {

            int i = 0;
            do
            {
                double previousAnswer = Answer;

                Console.Write("\n" + "Enter the next number here: ");
                double numberTwo = double.Parse(Console.ReadLine() ?? "");

                Console.Clear();

                Answer = Answer + numberTwo;

                Console.Write("\n" + previousAnswer + " + " + numberTwo + " = " + Answer + " Want to add more numbers? y/n: ");
                string Operator = (Console.ReadLine() ?? "");

                if (Operator == "n")
                {
                    i = 1;
                }
            }
            while (i < 1);
            {
                double RunAdditionMethod = Answer;
                return RunAdditionMethod;
                
            }
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
                double RunDivisionMethod = numberTwo;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nOh oh! Can't divide by 0! Please try something else!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

                return RunDivisionMethod;
            }
            else
            {
                double RunDivisionMethod = numberOne / numberTwo;

                return RunDivisionMethod;
            }
        }
    }
}
