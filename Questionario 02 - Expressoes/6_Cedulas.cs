int userInput = int.Parse(Console.ReadLine());
Console.WriteLine(userInput);

int[] values = { 100, 50, 20, 10, 5, 2, 1 };
int[] count = new int[values.Length];

for (int i = 0; i < values.Length; i++)
{
    count[i] = userInput / values[i]; 
    userInput %= values[i];
    Console.WriteLine($"{count[i]} nota(s) de R$ {values[i].ToString("F2")}");
}
