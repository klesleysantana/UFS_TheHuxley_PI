double number1 = double.Parse(Console.ReadLine());
double number2 = double.Parse(Console.ReadLine());

double sum = number1+number2, sub = number1-number2, mult = number1*number2, div = number1/number2;

Console.WriteLine($"{sum.ToString("F2")}\n{sub.ToString("F2")}\n{mult.ToString("F2")}\n{div.ToString("F2")}");
