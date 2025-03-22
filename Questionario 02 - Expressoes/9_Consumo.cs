double km = double.Parse(Console.ReadLine());
double litter = double.Parse(Console.ReadLine());

double fuelConsumption = km / litter;

Console.WriteLine($"{fuelConsumption.ToString("F3")} km/l");
