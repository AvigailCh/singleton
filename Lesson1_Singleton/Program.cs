using Lesson1_Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal animal = Dog.GetInstance();
        Animal animal1 = Cat.GetInstance();
        Animal animal2 = Animal.GetInstance();


        Vehicle v = FactoryVehicle.GetVehicle("Car");
        Vehicle v1 = FactoryVehicle.GetVehicle("Truck");

    }
}