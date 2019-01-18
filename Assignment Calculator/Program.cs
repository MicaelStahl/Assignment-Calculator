using System;

namespace Assignment_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
                //This command will make the code function until stated otherwise in the first switch.

            bool stayAlive = true;
            while (stayAlive)
            {
                try
                {
                            //This command asks for specific commands and will then use the 
                            //given command through the switch to it's own method that handles the request.

                    Console.Write("Enter the operator here  (+, -, *, /, % or x to exit): ");
                    string Operator = (Console.ReadLine() ?? "");

                    switch (Operator)
                    {
                        case "+": //Addition
                                  // <Summary> //
                                  //Takes first and second numbers here, adds them together, 
                                  //then sends them down to the RunAdditionMethod Method.

                            Console.Write("\n" + "Enter first number here: ");
                            double addOne = double.Parse(Console.ReadLine() ?? "");

                            Console.Write("\n" + "Enter the next number here: ");
                            double addTwo = double.Parse(Console.ReadLine() ?? "");

                            double addAnswer = addOne + addTwo;

                            RunAdditionMethod(addAnswer);
                            break;

                        case "-": //Subtraction
                                  // <Summary> //
                                  //Takes first and second numbers here, adds them together, 
                                  //then sends them down to the RunAdditionMethod Method.

                            Console.Write("\n" + "Enter first number here: ");
                            double subOne = double.Parse(Console.ReadLine() ?? "");

                            Console.Write("\n" + "Enter the next number here: ");
                            double subTwo = double.Parse(Console.ReadLine() ?? "");

                            double subAnswer = subOne - subTwo;
                            RunSubtractionMethod(subAnswer);
                            break;

                        case "*": //Multiplication
                                  // <Summary> //
                                  //Sends for a method that makes the wanted multiplication equation and
                                  //Then sends it back up here to write it out in a Console.WriteLine.
                                  //OBS. Didn't have to this -
                                  //But wanted to practice moving data around with Methods

                            double ResponseMultiplication = RunMultiplicationMethod();

                            Console.WriteLine("The answer is: " + ResponseMultiplication);
                            break;

                        case "/": //Division
                                  // <Summary> //
                                  //Does the same thing as Multiplication does except for one major thing,
                                  //if the response is 0 it will instead send it down to "catch".

                            double ResponseDivision = RunDivisionMethod();
                            if (ResponseDivision == 0)
                            {
                                Console.Clear();
                                break;
                            }

                            Console.WriteLine("The answer is: " + ResponseDivision);
                            break;

                        case "x": //ShutDown switch
                                  // <Summary> //
                                  //If the user presses "x" in previous Console.Write the
                                  //Console will shutdown.

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
        private static void RunAdditionMethod(double addAnswer)
        {
            //This Method indicates the start of the loop if you wish for it.
            Console.Write("\n" + "The answer is: " + addAnswer  + ", Would you like to add more numbers? y/n: ");
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
                    RunAdditionMethodLoop(addAnswer);
                    break;
            }
            return;
            }

        private static double RunAdditionMethodLoop(double addAnswer)
        {

            int i = 0;
            do
            {
                //Makes the current answer from the current loop sequence into its own variable.
                double previousAddAnswer = addAnswer;

                Console.Write("\nEnter the next number here: ");
                double addThree = double.Parse(Console.ReadLine() ?? "");

                //We use a Console.Clear here to keep the Console from getting too cluttered.
                Console.Clear();

                //Here we add the old answer and the new number to create a new answer for this loop sequence
                addAnswer = addAnswer + addThree;

                Console.Write("\n" + previousAddAnswer + " + " + addThree + " = " + addAnswer + " Want to add more numbers? y/n: ");
                string Operator = (Console.ReadLine() ?? "");

                //here we make i = 1 if the user presses "n" in previous Console.Write. This means that the loop will end.
                if (Operator == "n")
                {
                    i = 1;
                }
            }
            while (i < 1);
            {
                double RunAdditionMethod = addAnswer;
                return RunAdditionMethod;
                
            }
        }


        private static void RunSubtractionMethod(double subAnswer)
        {
            //This Method indicates the start of the loop if you wish for it.
            Console.Write("\n" + "The answer is: " + subAnswer + " would you like to add more numbers? y/n ");
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
                    RunSubtractionMethodLoop(subAnswer);
                    break;
            }
        }
        private static double RunSubtractionMethodLoop(double subAnswer)
        {
            int i = 0;

            do
            {
                //Makes the current answer from the current loop sequence into its own variable.
                double previousSubAnswer = subAnswer;

                Console.Write("\nEnter the next number here: ");
                double subThree = double.Parse(Console.ReadLine() ?? "");

                //We use a Console.Clear here to keep the Console from getting too cluttered.
                Console.Clear();

                //Here we add the old answer and the new number to create a new answer for this loop sequence
                subAnswer = subAnswer - subThree;

                Console.Write("\n" + previousSubAnswer + " - " + subThree + " = " + subAnswer + ", want to add more numbers? y/n ");
                string Operator = (Console.ReadLine() ?? "");

                //here we make i = 1 if the user presses "n" in previous Console.Write. This means that the loop will end.
                if (Operator == "n")
                {
                    i = 1;
                }
            }

            while (i < 1);
            {
                double RunSubtractionmethod = subAnswer;
                return RunSubtractionmethod;
            }
        }


        private static double RunMultiplicationMethod()
        {
                //This Method performs a simple Multiplication equation and 
                //then sends it back to the Main Method.
            Console.Write("\n" + "Enter first number here: ");
            double numberOne = double.Parse(Console.ReadLine() ?? "");

            Console.Write("\n" + "Enter the next number here: ");
            double numberTwo = double.Parse(Console.ReadLine() ?? "");

            double RunMultiplicationMethod = numberOne * numberTwo;

            return RunMultiplicationMethod;
        }


        private static double RunDivisionMethod()
        {
            //This Method creates a Division equation while also checking
            //to see if either numbers contains a 0 before performing the equation.
            Console.Write("\n" + "Enter first number here: ");
            double numberOne = double.Parse(Console.ReadLine() ?? "");

            Console.Write("\n" + "Enter the next number here: ");
            double numberTwo = double.Parse(Console.ReadLine() ?? "");

            if (numberOne == 0 || numberTwo == 0)
            {
                string divisionError = "";

                double RunDivisionMethod = Convert.ToDouble(divisionError);
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
