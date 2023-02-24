﻿int[] Array(int size)
{
    int a = Input($"Введите максимальное значение для массива: ");
    int b = Input($"Введите минимальное значение для массива: ");
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(b, a + 1);               
    }
    return array;    
}

int Input(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    while (num <= 0){
    Console.WriteLine($"Неверное значение");
    Console.Write(text);
    num = int.Parse(Console.ReadLine());
    }
    return num;
}

Console.Clear();
int size = Input($"Введите размер массива: ");
int[] array = Array(size);
Console.Write($"[{String.Join(", ", array)}]");