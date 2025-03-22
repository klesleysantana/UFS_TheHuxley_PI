int smallerBase = int.Parse(Console.ReadLine());
int largerBase = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

double trapezium = ((double)(smallerBase + largerBase) * height) / 2;

Console.WriteLine($"{trapezium.ToString("F1")}");
