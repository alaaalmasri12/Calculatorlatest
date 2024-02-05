using System.Diagnostics;

namespace CalculatorLibrary
{
    public class Calculator
    {
        private static int used = 0;
        private static List<string> calculations = new List<string>();

        public Calculator()
        {
            StreamWriter logFile = File.CreateText("calculator.log");
            Trace.Listeners.Add(new TextWriterTraceListener(logFile));
            Trace.AutoFlush = true;
            Trace.WriteLine("Starting Calculator Log");
            Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
        }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    Trace.WriteLine(String.Format("{0} + {1} = {2}", num1, num2, result));
                    calculations.Add(String.Format("{0} + {1} = {2}", num1, num2, result));
                    calculatorused();
                    break;
                case "s":
                    result = num1 - num2;
                    Trace.WriteLine(String.Format("{0} - {1} = {2}", num1, num2, result));
                    calculations.Add(String.Format("{0} - {1} = {2}", num1, num2, result));
                    calculatorused();
                    break;
                case "m":
                    result = num1 * num2;
                    Trace.WriteLine(String.Format("{0} * {1} = {2}", num1, num2, result));
                    calculations.Add(String.Format("{0} * {1} = {2}", num1, num2, result));
                    calculatorused();
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Trace.WriteLine(String.Format("{0} / {1} = {2}", num1, num2, result));
                        calculations.Add(String.Format("{0} / {1} = {2}", num1, num2, result));
                        calculatorused();
                    }
                    break;
                case "l":
                    showlist();
                    break;

                case "q":

                    result = Math.Sqrt(num1);
                    Trace.WriteLine(String.Format($"sqrt({num1}) = {result}"));
                    calculations.Add(String.Format($"sqrt({num1}) = {result}"));
                    calculatorused();
                    break;

                case "p":
                    result = Math.Pow(num1, num2);
                    Trace.WriteLine($"{num1} ^ {num2} = {result}");
                    calculations.Add($"{num1} ^ {num2} = {result}");
                    calculatorused();
                    break; 
                case "r":
                        removelist();
                    break;

                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public static int calculatorused()
        {
            var count = ++used;
            Console.WriteLine($"the amount of times the calculator was used is {count}");
            return count;
        }

        public void removelist()
        {
            calculations.Clear();
            Console.WriteLine("The list has been cleared.");
        }
        public void showlist()
        {
            if (calculations.Count == 0)
            {
                Console.WriteLine("The list is empty.");

            }
            else
            {
                foreach (var item in calculations)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}