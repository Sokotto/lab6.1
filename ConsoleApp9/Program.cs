Console.Write("Введите числитель (a): ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите знаменатель (b): ");
int b = int.Parse(Console.ReadLine());
if (b == 0)
{
    Console.WriteLine("Знаменатель не может быть равен нулю.");
    return;
}
int gcd = GCD(a, b);
int reducedNumerator = a / gcd;
int reducedDenominator = b / gcd;
Console.WriteLine($"Сокращенная дробь: {reducedNumerator}/{reducedDenominator}");
static int GCD(int x, int y)
{
    while (y != 0)
    {
        int temp = y;
        y = x % y;
        x = temp;
    }
    return x;
}