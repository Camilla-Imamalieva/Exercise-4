Console.Write("Введите число: ");
int s = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {s} = {SumAllDigit(s)}");
int result = 0;
return result;

int SumAllDigit(int s)
{
    int result = 0;
    while (s > 0)
    {
        result += s % 10;
        s = s / 10;
    }
    return result;
}
