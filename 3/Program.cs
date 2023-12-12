// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.


Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array= new double[n];
Random rnd= new Random();
int a = 0;
double b = 0.0;

for (int i = 0; i < n; i++)
     {  
        a = rnd.Next(-50, 50);
        b = rnd.NextDouble();
        array[i] = Math.Round((a * b), 3);
        Console.Write($" {array[i]} ");

     }
double max= array[0];
double min= array[0];
foreach (double c in array)
    {
      if(c <= min)
      {
        min = c;
      }  
      if(c > max)
      {
        max = c;
      }
    }
Console.WriteLine("");
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");
Console.WriteLine($"diff = {max - min}");