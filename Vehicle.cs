public class Vehicle
{
    public int VehicleId { get; set; }
    public string VehicleName { get; set; }
    public string VehicleType { get; set; }
    public string VehicleColor { get; set; }
    public int VehicleYear { get; set; }
    public int VehiclePrice { get; set; }

    public void Run()
    {
        Console.WriteLine("Vehicle is running");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle is stopped");
    }
}