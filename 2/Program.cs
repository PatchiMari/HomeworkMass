// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.
//В условии этого нет, но я указала размер массива от -100 до 100, чтобы не выводил рандомно огромные числа
int[] array = new int[10];
System.Console.Write($"Массив [ ");
for(int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(-100,100);
    System.Console.Write(array[i]+ " ");
}
Console.Write("] => ");
int count = 0;
for(int i = 0; i<array.Length; i++)
    if (array[i] %2 == 0 )
        {
            count = count + 1;
        }
Console.Write(count);