using System;

class Program
{
    static void Main(string[] args)
    {

        string letter = "";

        //ask user for grade percentage

        Console.Write("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);

        //if else statements for letter grade

        if (grade >= 90)
        {
            Console.WriteLine("Your letter grade is an A");
        }

        else if (grade >= 80)
        {
            Console.WriteLine("Your letter grade is a B");
        }

        else if (grade >= 70)
        {
            Console.WriteLine("Your letter grade is a C");
        }

        else if (grade >= 60)
        {
            Console.WriteLine("Your letter grade is a D");
        }

        else
        {
            Console.WriteLine("Your letter grade is an F");
        }

        Console.WriteLine();
        Console.WriteLine();

        //Did you pass?

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations!  You passed the course.");
        }

        else
        {
            Console.WriteLine("I am sorry, you did not pass the course.  Don't give up.  Get a tutor and try again next semester.");
        }


        //second set of if else statements

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }


        string sign = "";

        float plumin = grade % 10;

        if (plumin >= 7)
        {
            sign = "+";
        }

        else if (plumin < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is a {letter}{sign}.");

    }
}