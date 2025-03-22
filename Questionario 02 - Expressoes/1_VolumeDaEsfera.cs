double radius = double.Parse(Console.ReadLine());
const double pi = 3.1416;

double volumeSphere = (4 * pi * Math.Pow(radius, 3)) / 3;

Console.WriteLine($"{volumeSphere.ToString("F2")}");
