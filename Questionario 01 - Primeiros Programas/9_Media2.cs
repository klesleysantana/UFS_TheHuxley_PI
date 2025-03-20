double score1 = double.Parse(Console.ReadLine());
double score2 = double.Parse(Console.ReadLine());
double score3 = double.Parse(Console.ReadLine());

double weightedAverage = ((score1*2) + (score2*3) + (score3*5)) / 10;

Console.WriteLine($"MEDIA = {weightedAverage.ToString("F1")}");
