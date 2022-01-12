public class Car : Vehicle
{

}


public class Motorcycle : Vehicle
{
    public Motorcycle()
    {
        
    }

    public void RunCar()
    {
        Car car = new();
        car.Run();
    }
}