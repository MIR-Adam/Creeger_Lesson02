// Adam Creeger
using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Conditional_Statements cs = new Conditional_Statements();
            cs.RunExercise();

            Comparison_Operators co = new Comparison_Operators();
            co.RunExercise();

            IO_Operators ioo = new IO_Operators();
            ioo.RunExercise();
            
            Integer_Vs_Real_Division ivrd = new Integer_Vs_Real_Division();
            ivrd.RunExercise();

            Modulus_Operator mo = new Modulus_Operator();
            mo.RunExercise();

            Fahrenheit_To_Celsius ftc = new Fahrenheit_To_Celsius();
            ftc.RunExercise();
         }
    }

    class Conditional_Statements
    {
        public void RunExercise()
        {
            Console.WriteLine("About to do the \"Conditional Statements\" exercise");
            Conditional_Methods cm = new Conditional_Methods();
            cm.UsingIf();
            cm.UsingIfElse();
            cm.UsingSwitch();
        }
    }

    class Comparison_Operators
    {
        int num1; int num2;
        public void RunExercise()
        {
            Console.WriteLine("Get 2 integers & store them, then compare them using <, <=, etc, etc: ");
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out num1) == false)
                {
                    Console.WriteLine("You need to type in a whole number, between 1 and 10: ");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out num2) == false)
                {
                    Console.WriteLine("You need to type in a whole number, between 1 and 10: ");
                }
                else
                {
                    break;
                }
            }
            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is greater than " + num2);
            }
            if (num1 < num2)
            {
                Console.WriteLine(num1 + " is less than " + num2);
            }
            if (num1 >= num2)
            {
                Console.WriteLine(num1 + " is greater than or equal to " + num2);
            }
            if (num1 <= num2)
            {
                Console.WriteLine(num1 + " is less than or equal to " + num2);
            }
            if (num1 == num2)
            {
                Console.WriteLine(num1 + " is equal to " + num2);
            }
            if (num1 != num2)
            {
                Console.WriteLine(num1 + " is NOT equal to " + num2);
            }
        }
    }


    class IO_Operators
    {
        int num1; int num2;
        public void RunExercise()
        {
            Console.WriteLine("Get 2 integers & store them, then check if they are within 5 integer values of eachother: ");
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out num1) == false)
                {
                    Console.WriteLine("You need to type in a whole number, between 1 and 10: ");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out num2) == false)
                {
                    Console.WriteLine("You need to type in a whole number, between 1 and 10: ");
                }
                else
                {
                    break;
                }
            }
            int big = Math.Max(num1, num2);
            int small = Math.Min(num1, num2);
            if (big - small <= 5)
            {
                Console.WriteLine(num1 + " and " + num2 + " are within 5 integers of eachother");
            }
            else
            {
                Console.WriteLine(num1 + " and " + num2 + " are NOT within 5 integers of eachother");
            }
        }
    }

    class Conditional_Methods
    {
        int number;
        public void UsingIf()
        {
            Console.WriteLine("Enter a grade number: ");
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out number) == false)
                {
                    Console.WriteLine("You need to type in a whole number, between 1 and 10: ");
                }
                if (number < 0)
                {
                    Console.WriteLine("You need to type in a number that is 1 or greater: ");
                }
                if (number >= 0 && number <= 10)
                {
                    Console.WriteLine("You entered the number: " + number);
                    break;
                }
            }
            if (number == 0)
            {
                Console.WriteLine("You need to talk to the professor immediately!");
            }
            if (number == 1)
            {
                Console.WriteLine("You need to study a lot more!");
            }
            if (number >= 2 && number <= 4)
            {
                Console.WriteLine("If you keep working at this, you'll do better!");
            }
            if (number == 5 || number == 6)
            {
                Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
            }
            if (number == 7 || number == 8)
            {
                Console.WriteLine("Nice job, but don't let yourself slack!");
            }
            if (number == 9)
            {
                Console.WriteLine("Very nice job – keep up the good work!");
            }
            if (number == 10)
            {
                Console.WriteLine("Perfect!");
            }
        }

        public void UsingIfElse()
        {
            Console.WriteLine("Enter a grade number: ");
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out number) == false)
                {
                    Console.WriteLine("You need to type in a whole number, between 1 and 10: ");
                }
                else if (number < 0)
                {
                    Console.WriteLine("You need to type in a number that is 1 or greater: ");
                }
                else if (number >= 0 && number <= 10)
                {
                    Console.WriteLine("You entered the number: " + number);
                    break;
                }
            }
            if (number == 0)
            {
                Console.WriteLine("You need to talk to the professor immediately!");
            }
            if (number == 1)
            {
                Console.WriteLine("You need to study a lot more!");
            }
            else if (number <= 2 && number <= 4)
            {
                Console.WriteLine("If you keep working at this, you'll do better!");
            }
            else if (number == 5 || number == 6)
            {
                Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
            }
            else if (number == 7 || number == 8)
            {
                Console.WriteLine("Nice job, but don't let yourself slack!");
            }
            else if (number == 9)
            {
                Console.WriteLine("Very nice job – keep up the good work!");
            }
            else
            {
                Console.WriteLine("Perfect!");
            }
        }
        public void UsingSwitch()
        {
            Console.WriteLine("Enter a grade number: ");
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out number) == false)
                {
                    Console.WriteLine("You need to type in a whole number, between 1 and 10: ");
                }
                else if (number < 0)
                {
                    Console.WriteLine("You need to type in a number that is 1 or greater: ");
                }
                else if (number >= 0 && number <= 10)
                {
                    Console.WriteLine("You entered the number: " + number);
                    break;
                }
            }
            switch (number)
            {
                case 0:
                    Console.WriteLine("You need to talk to the professor immediately!");
                    break;
                case 1:
                    Console.WriteLine("You need to study a lot more!");
                    break;
                case 2:
                    Console.WriteLine("If you keep working at this, you'll do better!");
                    break;
                case 3:
                    Console.WriteLine("If you keep working at this, you'll do better!");
                    break;
                case 4:
                    Console.WriteLine("If you keep working at this, you'll do better!");
                    break;
                case 5:
                    Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
                    break;
                case 6:
                    Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
                    break;
                case 7:
                    Console.WriteLine("Nice job, but don't let yourself slack!");
                    break;
                case 8:
                    Console.WriteLine("Nice job, but don't let yourself slack!");
                    break;
                case 9:
                    Console.WriteLine("Very nice job – keep up the good work!");
                    break;
                case 10:
                    Console.WriteLine("Perfect!");
                    break;
            }
        }
    }
    class Integer_Vs_Real_Division
    {
        int int1; int int2;
        float f1; float f2;
        double d1; double d2;
        public void RunExercise()
        {
            Console.WriteLine("Enter two integers for division: ");
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out int1) == false)
                {
                    Console.WriteLine("You need to type in a numerical value!");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out int2) == false)
                {
                    Console.WriteLine("You need to type in a numerical value!");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Enter two floating point values for division: ");
            while (true)
            {
                if (float.TryParse(Console.ReadLine(), out f1) == false)
                {
                    Console.WriteLine("You need to type in a numerical value!");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                if (float.TryParse(Console.ReadLine(), out f2) == false)
                {
                    Console.WriteLine("You need to type in a numerical value!");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Enter two double values for division: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out d1) == false)
                {
                    Console.WriteLine("You need to type in a numerical value!");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out d2) == false)
                {
                    Console.WriteLine("You need to type in a numerical value!");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Integer division: " + int1 + " / " + int2 + " = " + int1/int2);
            Console.WriteLine("Floating point division: " + f1 + " / " + f2 + " = " + f1 / f2);
            Console.WriteLine("Double division: " + d1 + " / " + d2 + " = " + d1/d2);

            // The double data type has twice the precision of the float data type.  
            // A double 'generally' goes up to 15 points of a precision while a float has 'generally' 7.
        }
    }

    class Modulus_Operator
    {
        int num1; int num2;
        public void RunExercise()
        {
            Console.WriteLine("Enter two values for division and remainder: ");
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out num1) == false)
                {
                    Console.WriteLine("You need to type in a whole number!");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out num2) == false)
                {
                    Console.WriteLine("You need to type in a whole number!");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Integer division: " + num1 + " / " + num2 + " = " + num1 / num2);
            Console.WriteLine("Modulus Return: " + num1 + " % " + num2 + " = " + num1 % num2);
            /*
             * Sample Test Question Output:
             * 3
             * 2
             * 0
             * 1
             * 3
             */
        }
    }

    class Fahrenheit_To_Celsius
    {
        public void RunExercise()
        {
            double temp;
            double divide = 5.0 / 9.0;

            Console.WriteLine("Please enter a temperature value in Fahrenheit: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out temp) == false)
                {
                    Console.WriteLine("You need to type in a whole number!");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(temp + " degrees Fahrenheit = " + (temp-32)*(divide) + " degrees Celcius");
        }
    }

    class Logical_Operators
    {
        //1. y < 1 || y > 1
        // 2 < 1 || 2 > 1 - Will evaluate to true because the OR logical operator only needs one statement to be correct to return true.

        //2. y < 2 || x > 4
        // 2 < 2 || 5 > 4 - This will evaluate to true due to the OR operator and the fact that 5 > 4.

        //3. z > 8 || y < 3
        // 10 > 8 || 2 < 3 - Both statements are true and OR logical operater will evaluate to true.

        //4.!(z>8)
        // !(10>8) - This will evaluate to false due to the not operator

        //5. (z>8 || y < 3)
        // !(10>8 || 2<3) - Even with the OR operator, these will both evaluate to false due to the not operator

        //6. !( z > 4 && y == 2) || (z ==10 && y <= 3)
        // !( 10 > 4 && 2 == 2) || (10 == 10 && y <= 3) - The first have will evaluate to true but because of the NOT operator it is false.  
        // The second half evaluates to true, due to the OR operator, the entire statement will evaluate to true.

        //7. y < z ^ z < x
        // 2 < 10 ^ 10 < 5 - This will evaluate to true if only one side is true, which is correct as 10 is not less than 5.

        //8. z < x ^ y < z
        // 10 < 5 ^ 2 < 10 - This will evaluate to true if only one side is true, which is correct as 2 is less than 10.

        //9. 10 < 20 ^ 20 < 30 - This will evaluate to false as BOTH sides evaluate to true.

        //10. 20 == 10 ^ 20 < 10 - This will evaluate to false as BOTH sides evaluate to false.  
    }
}