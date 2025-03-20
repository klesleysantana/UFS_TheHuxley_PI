double radius = double.Parse(Console.ReadLine());
const double pi = 3.14159;

// Area calculus and m2 conversion
double area = (pi * Math.Pow(radius, 2)) / 10000;

Console.WriteLine($"AREA = {area.ToString("F4")}");
