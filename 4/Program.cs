// Задача 4**(не обязательно): Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.


Console.Write($"Введите натуральное число в диапазоне от 1 до 100 000: ");

int number = Convert.ToInt32(Console.ReadLine());
int a =0;
int number2= number;
while (number2 >0)
{
    a++;
    number2/=10;
}
int[] array = new int[a];
for(int i = a-1; i>=0; i--)
{
    array[i]= number%10;
    number/= 10;
}

System.Console.Write($" => ");
 for(int k = 0; k<array.Length; k++)
 {
        System.Console.Write(array[k]+ " ");
 }
