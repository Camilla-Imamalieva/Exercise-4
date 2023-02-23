int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Power(int powerBase, int extent)
{
    int power = 1;
    for (int i = 0; i < extent; i++)
    {
        power *= powerBase;   
    }
    return power;
}
bool ValidateExtent(int extent)
{
    if (extent < 0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}
int powerBase = Prompt("Введите основное число: ");
int extent = Prompt("Введите натуральную степень: ");
if (ValidateExtent(extent))
{
    System.Console.WriteLine($"Число {powerBase} в стпени {extent} равно {Power(powerBase, extent)}");
}