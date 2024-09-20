using System.Collections;

class Arrays
{
    public static void Arrays1(String[] args)
    {
        int[] number =  new int[5];
        number[0] = 1;

        Console.WriteLine(number[0]);

        string [] names = {"Alice", "Bob", "Charlie"};

        Console.WriteLine(names[0]);

        int[] grades = new int[5];
        grades[0] = 85;
        grades[1] = 90;
        grades[2] = 95;
        grades[3] = 100;
        grades[4] = 80;

        Console.WriteLine("Grades ");
        for(int i = 0; i < grades.Length; i ++)
        {
            Console.WriteLine(grades[i]);
        }
    }
}