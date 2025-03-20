double amount = double.Parse(Console.ReadLine());

double amountPaid = (0.1 * amount) + amount;

Console.WriteLine($"{amountPaid.ToString("F2")}");
