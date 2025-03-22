string userInput = Console.ReadLine();
string[] separateValues = userInput.Split(" ");

double cubicMeters = double.Parse(separateValues[0]);
double waterConsumption = double.Parse(separateValues[1]);

double water = (cubicMeters * 1000) * waterConsumption;
double sewage = water * 0.8;
double total = water + sewage;

Console.WriteLine($"{water.ToString("F2")}\n{sewage.ToString("F2")}\n{total.ToString("F2")}");
