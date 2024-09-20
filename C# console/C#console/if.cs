using System.Globalization;
using System.Runtime.CompilerServices;

class If
{
    public static void IfElse(int number)
    {
        

        if(number > 0)
        {
            Console.WriteLine("The Number is Positive.");
        }
        else if(number < 0)
        {
            Console.WriteLine("The Number is Negative.");
        }
        else
        {
            Console.WriteLine("The Number is Zero.");
        }
    }

    public static void IfHealth(int number)
    {
        if(number > 75)
        {
            Console.WriteLine("The player is in great condition!");
        }
        else if(number > 50)
        {
            Console.WriteLine("The player is in good condition!");
        }
        else if(number > 0)
        {
            Console.WriteLine("The player is in danger!");
        }
        else
        {
            Console.WriteLine("Game Over.");
        }
    }
}