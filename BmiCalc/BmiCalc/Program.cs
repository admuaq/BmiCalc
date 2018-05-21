using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;

            while (keepGoing)
            {

                //Requests users age
                Console.Write("Please enter your age or type quit: ");
                string age = Console.ReadLine();
                string toExit = age.ToLower();

                int ageInput;
                if (toExit == "quit")
                {
                    Console.WriteLine("Thank you for using the BMI calculator. Good bye!~\n");
                    break;
                }

                try
                {
                    ageInput = Convert.ToInt32(age);
                   

                   if (ageInput < 0 || ageInput > 99)
                    {
                        Console.WriteLine("Please enter a valid age between 1-99 years old.\n");
                        continue;
                    }


                    Console.WriteLine("You are " + ageInput + " years old.\n");
                }

                catch (FormatException)
                {
                    Console.WriteLine("Please write a valid input.\n");
                    continue;
                }

                //Requests users height
                Console.WriteLine("Please enter your height in cm: ");
                var height = Console.ReadLine();

                int heightInput;
                try
                {
                    heightInput = Convert.ToInt32(height);

                    if (heightInput < 0 || heightInput > 200)
                    {
                        Console.WriteLine("Surely you aren't " + heightInput + " cm tall!.\n");
                        continue;
                    }

                    else
                    {
                        Console.WriteLine("You are " + heightInput + " cm tall.\n"); ;
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Please write a valid input.\n");
                    continue;
                }
                

                //Requests Users Weight
                Console.WriteLine("What is your weight in kg?: ");
                var weight = Console.ReadLine();

                double weightInput;
                try
                {
                    weightInput = Convert.ToDouble(weight);

                    if (weightInput < 0 || weightInput > 200)
                    {
                        Console.WriteLine("Surely you aren't " + weightInput + " kg heavy!.\n");
                        continue;
                    }

                    else
                    {
                        Console.WriteLine("You weigh " + weightInput + " kg.\n"); ;
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Please write a valid input.\n");
                    continue;
                }


                //Calculate BMI
                Console.WriteLine("Calculating BMI... Please wait.");
                double heightMetres = heightInput / 100f;
                double heightsq = Math.Pow(heightMetres, 2);
                Console.WriteLine(heightInput);
                double bmiVal = weightInput/heightsq;
                Console.WriteLine("Your BMI value is " + bmiVal + ".\n");

            }
            
        }
    }
}
