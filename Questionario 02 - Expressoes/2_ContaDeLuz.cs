double consumption = double.Parse(Console.ReadLine());
const double kwhCost = 1.5;

double total = consumption * kwhCost;
double totalDescont = total - (0.15 * total);

Console.WriteLine($"Valor a ser pago: R$ {total.ToString("F2")} reais\nValor a ser pago com desconto: R$ {totalDescont.ToString("F2")} reais");
