using DecoratorPattern;
using System.Net.Http.Headers;
using DecoratorPattern.Options;

public class Program
{
    static void Main(string[] args)
    {
        ICar myCar = new Car("Toyota", 180);
        Console.WriteLine(myCar.GetDescription());
        Console.WriteLine($"Speed:" + myCar.GetSpeed() + "км/год");


        myCar = new AudioSystem(myCar);
        Console.WriteLine(myCar.GetDescription());

        myCar = new Conditioner(myCar);
        Console.WriteLine(myCar.GetDescription());

        myCar = new HeatedSeats(myCar);
        Console.WriteLine(myCar.GetDescription());

        myCar = new SportPackage(myCar);
        Console.WriteLine(myCar.GetDescription());
        Console.WriteLine($"Speed:" + myCar.GetSpeed() + "км/год");
    }
}
