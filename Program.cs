var names = new List<string>{ "A","any A","C" };
var def = new List<string>{ "A","B","C" };

var newNames = new List<string>();

foreach (var n in names)
{
    if(!n.Contains("any"))
        newNames.Add(n);
    if (n.Contains("any"))
    {
       newNames.AddRange(def);
    }
}

foreach (var name in newNames)
{
    Console.WriteLine(name);
}




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

    public dynamic myobject()
    {
        var info = "jsydusydusyd";
        return info;
    }
}