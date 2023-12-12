// Задача 1: Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90]. 

using System.Reflection.Metadata.Ecma335;

int[] array = new int[10];
System.Console.Write($"Массив [ ");
for(int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(1,101);
    System.Console.Write(array[i]+ " ");
}
Console.Write($" ] => ");
int count = 0;
 for (int i= 0; i < array.Length; i++)
        if (array[i] >=20 && array[i] <=90)
        {
            count = count + 1;
        }
Console.Write(count);