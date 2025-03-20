double salary = double.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double newSalary = ((percentage / 100) * salary) + salary;

Console.WriteLine($"Seu salario teve aumento de {percentage.ToString("F1")} %, passando de R$ {salary.ToString("F1")} para R$ {newSalary.ToString("F1")}"); 
