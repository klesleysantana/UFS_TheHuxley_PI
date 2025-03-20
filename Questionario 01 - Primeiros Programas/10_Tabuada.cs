int number = int.Parse(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    int multi = number * i;
    Console.WriteLine($"{number} X {i} = {multi}");
}