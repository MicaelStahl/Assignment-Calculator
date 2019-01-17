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

                            RunAdditiveMethod();
                            double ResponseAdditive = RunAdditiveMethod();

                            Console.WriteLine("The answer is: " + ResponseAdditive);
                            //
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

                        //case "%": //Percentage
                        //          double ResponsePercentage = RunPercentageMethod();

                        //        Console.WriteLine("The answer is: " + ResponsePercentage +"%");
                        //    break;

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
        private static double RunAdditiveMethod()
        {
            Console.Write("\n" + "Enter first number here: ");
            double numberOne = double.Parse(Console.ReadLine() ?? "");

            Console.Write("\n" + "Enter the next number here: ");
            double numberTwo = double.Parse(Console.ReadLine() ?? "");

            double Answer = numberOne + numberTwo;
            double RunAdditiveMethod = Answer;

            Console.Write("\n" + "Would you like to add more numbers? y/n: ");
            string Operator = (Console.ReadLine() ?? "");
            switch (Operator)
            {
                case "y":
                    if (Operator == "y")
                        RunAdditiveMethodLoop(Answer);
                    break;

                case "n":
                    if (Operator == "n")
                        return RunAdditiveMethod;
                    break;


            }
            return RunAdditiveMethod;
            }


        private static double RunAdditiveMethodLoop(double Answer)
        {

            int i = 0;
            do
            {
                Console.Write("\n" + "Enter the next number here: ");
                double numberTwo = double.Parse(Console.ReadLine() ?? "");

                Answer = Answer + numberTwo;

                Console.Write("\n" + "The Answer is: " + Answer + " Want to add more numbers? y/n: ");
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



            //Console.Write("\n" + "Enter the next number here: ");
            //double numberThree = double.Parse(Console.ReadLine() ?? "");

            //double Answer1 = numberThree;

            //double RunAdditiveMethodLoop = Answer + Answer1;
            //return RunAdditiveMethodLoop;
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


        //private static double RunPercentageMethod()
        //{
        //    Console.Write("\n" + "Enter first number here: ");
        //    double numberOne = double.Parse(Console.ReadLine() ?? "");

        //    Console.Write("\n" + "Enter the next number here: ");
        //    double numberTwo = double.Parse(Console.ReadLine() ?? "");

        //    double Percentage = numberOne - numberTwo;
        //    //double RunPercentageMethod = (double)(Percentage / (double)numberOne) * 100;

        //    //double RunPercentageMethod = (numberTwo / numberOne) * 100;
        //    double RunPercentageMethod = (double)(numberTwo / (double)numberOne) * 100;

        //    return RunPercentageMethod;
        //}
    }

}
