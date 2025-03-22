string userInput = Console.ReadLine();
string[] separateValues = userInput.Split(" ");

double a = double.Parse(separateValues[0]);
double b = double.Parse(separateValues[1]);
double c = double.Parse(separateValues[2]);

double triangle, circle, trapezium, square, rectangle;
triangle = (a * c) / 2;
circle = 3.14159 * Math.Pow(c, 2);
trapezium = ((a + b) * c) / 2;
square = Math.Pow(b, 2);
rectangle = a * b;

Console.WriteLine($"TRIANGULO: {triangle.ToString("F3")}\nCIRCULO: {circle.ToString("F3")}\nTRAPEZIO: {trapezium.ToString("F3")}\nQUADRADO: {square.ToString("F3")}\nRETANGULO: {rectangle.ToString("F3")}");
