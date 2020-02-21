using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //Console.WriteLine("Five plus Ten = " + total.ToString());
            //Console.ReadLine();

            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();


            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //bool isWarm = currentTemperature <= roomTemperature;
            //bool isWarm = currentTemperature == roomTemperature;  -- EQUAL
            //bool isWarm = currentTemperature != roomTemperature;  -- NO EQUAL
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            Console.WriteLine("Please enter a number:");
            string userNumber = Console.ReadLine();
            int number = Convert.ToInt32(userNumber);
            int total = number * 50;
            Console.WriteLine("That number multiplied by 50 is: " + total);

            Console.WriteLine("Please enter a number:");
            string userNumber2 = Console.ReadLine();
            int number2 = Convert.ToInt32(userNumber2);
            int total2 = number2 + 25;
            Console.WriteLine("That number plus 25 is: " + total2);

            Console.WriteLine("Please enter a number:");
            int userNumber3 = Convert.ToInt32(Console.ReadLine());
            double number3 = Convert.ToDouble(userNumber3);
            double total3 = number3 / 12.5;
            Console.WriteLine("That number divided by 12.5 is: " + total3);

            Console.WriteLine("Please enter a number:");
            string userNumber4 = Console.ReadLine();
            int number4 = Convert.ToInt32(userNumber4);
            bool total4 = number4 > 50;
            Console.WriteLine(total4);

            Console.WriteLine("Please enter a number:");
            string userNumber5 = Console.ReadLine();
            int number5 = Convert.ToInt32(userNumber5);
            int total5 = number5 % 7;
            Console.WriteLine("That number divided by 7 has a remainder of: " + total5);
            Console.ReadLine();











        }
    }
}
