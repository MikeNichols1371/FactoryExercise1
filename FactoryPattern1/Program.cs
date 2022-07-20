using FactoryPattern1;

Console.WriteLine("How many tires does your Vehicle have?");
Console.WriteLine();
var wheelNum = int.Parse(Console.ReadLine().ToLower());
Console.WriteLine();
IVehicle vehicle = VehicleFactory.GetVehicle(wheelNum);
vehicle.Drive();

