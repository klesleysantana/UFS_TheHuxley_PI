double height = double.Parse(Console.ReadLine());
double radius = double.Parse(Console.ReadLine());
const double pi = 3.14;

double volume = pi * Math.Pow(radius, 2) * height;
double area = 2 * pi * radius * (radius + height);

Console.WriteLine($"{volume.ToString("F2")}\n{area.ToString("F2")}");
