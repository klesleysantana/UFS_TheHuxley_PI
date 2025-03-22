int userInput = int.Parse(Console.ReadLine());

double hour = userInput / 3600;
double minute = userInput / 60;
double second = userInput % 60;

Console.WriteLine($"{hour}:{minute}:{second}");
