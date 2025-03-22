double fahrenheit = double.Parse(Console.ReadLine());

double celcius = (fahrenheit - 32) * 5 / 9;

Console.WriteLine($"{celcius.ToString("F2")}");
