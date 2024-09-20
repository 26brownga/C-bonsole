public class Car
{
    public string brand;
    public int speed;

    public void Drive()
    {
        Console.WriteLine("The car is driving");
    }
}


Car myCar = new Car();
myCar.brand = "Toyota";
myCar.speed = 60;
myCar.Drive();

public class BankAccount
{
    private double balance;

    public void Deposit(double amount)
    {
        balance += amount;
    }
    public double GetBalance()
    {
        return balance;
    }
}

BankAccount account = new BankAccount();
account.Deposit(100);
Console.WriteLine(account.GetBalance());

public class Vehicle
{
    public string brand;

    public void Start()
    {
        Console.WriteLine("Vehicle is starting");
    }
}

public class Car : Vehicle
{
    public int speed;

    public void Drive()
    {
        Console.WriteLine(brand + " is driving at " + speed + " km/h.");
    }
}

Car myCar = new Car();
myCar.brand = "Toyota";
myCar.speed = 120;
myCar.Start();
myCar.Drive();

public class Animal
{
    public virtual WaitForChangedResult MakeSound()
    {
        Console.WriteLine("Animal sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

Animal myDog = new Dog();
myDog.MakeSound();

public abstract class Animal
{
    public abstract void MakeSound();
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
Animal myDog = new Dog();
myDog.MakeSound();