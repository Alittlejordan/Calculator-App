using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculator_App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculatorr");
            Console.WriteLine("------------------------\n");
            string number ="";
            // Ask the user to type the first number.
            while (number !="-1")
            {

                Console.WriteLine("Please type in the number you would like to enter or type -1 to exit:");

                number = Console.ReadLine();
                
                
                if (number.All(char.IsDigit) == true && number != "-1")
                {
                    int num = int.Parse(number);
                    StartCaluclator(num);
                }
                // check if the number is -1 to exit the program
                else if(number=="-1")
                {
                    break;
                }
                
            }
         
        }


        // Function to start the calculator
        public static void StartCaluclator(int number)
        {
            int num=0;

            // Ask the user to choose an option.
            CalculatorPrompt();

           string key= Console.ReadLine();
            if (key == null)
                return;

            if(key.All(char.IsDigit)==true)
            {
                num=int.Parse(key);
                Caluclations(number,num);
            }
            else
            {
                return;
            }

        }
        // Function to add two numbers
        public static void Caluclations(int firstnum, int key)
        {
            // Use a switch statement to do the math.
            switch (key)
            {
                case 1:
                    Console.WriteLine("Please enter a second number");

                    string second1 = Console.ReadLine();

                    // check if the second number is a valid number
                    if (second1.All(char.IsDigit) == true)
                    {
                        int secondnum1 = int.Parse(second1);
                        int answer1 = firstnum + secondnum1 ;

                        Console.WriteLine("the result is {0}", answer1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("not a valid number was entered");
                    }

                    break;
                case 2:
                    Console.WriteLine("Please enter a second number");

                    string second2 = Console.ReadLine();
                    // check if the second number is a valid number
                    if (second2.All(char.IsDigit) == true)
                    {
                        int secondnum1 = int.Parse(second2);
                        int answer1 = firstnum-secondnum1;

                        Console.WriteLine("the result is {0}", answer1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("not a valid number was entered");
                    }

                    break;

                    break;
                case 3:
                    Console.WriteLine("Please enter a second number");

                    string second3 = Console.ReadLine();
                    // check if the second number is a valid number
                    if (second3.All(char.IsDigit) == true && second3 != "0")
                    {
                        int secondnum1 = int.Parse(second3);
                        int answer1 = firstnum / secondnum1;

                        Console.WriteLine("the result is {0}", answer1);
                        break;
                    }
                    // check if the second number is 0 as you cannot divide by 0
                    else if (second3 == "0")
                        Console.WriteLine("You cannot divide an a number by 0");

                    else
                    {
                        Console.WriteLine("not a valid number was entered");
                    }

                    break;

                case 4:
                    Console.WriteLine("Please enter a second number");

                    string second4 = Console.ReadLine();
                    // check if the second number is a valid number
                    if (second4.All(char.IsDigit) == true)
                    {
                        int secondnum1 = int.Parse(second4);
                        int answer1 = firstnum*secondnum1;

                        Console.WriteLine("the result is {0}", answer1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("not a valid number was entered");
                    }

                    break;
                default:
                    Console.WriteLine("Wrong Key was entered");
                    break;
            }
        }

        public static void CalculatorPrompt()
        {
            // Ask the user to choose an option.
            Console.WriteLine("Please enter which calcualtion you would like to use by " +
                "entering the respective number:");

            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substract");
            Console.WriteLine("3.Division");
            Console.WriteLine("4.Multiply");
        }
    }
}