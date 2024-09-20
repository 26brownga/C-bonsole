using System.Security.Authentication;

class Var
{
    public static void MyVar()
    {
        string myName = "Gage";

        Console.WriteLine(myName);
    }

    public static void DataTypes()
    {
        string firstName = "Gage";
        string lastName = "Brown";
        string wholeName = firstName + " " + lastName;
        int age = 16;
        double height = 5.11;
        float gpa = 3.8f;
        decimal dollar = 100.95m;
        bool is_Teacher = true;
        char grade = 'F';
        

        
        //Console.WriteLine(firstName);
        //Console.WriteLine(lastName);
        Console.WriteLine(wholeName);
        Console.WriteLine(age);
        Console.WriteLine(height);
        Console.WriteLine(gpa);
        Console.WriteLine(dollar);
        Console.WriteLine(is_Teacher);
        Console.WriteLine(grade);
    }
}