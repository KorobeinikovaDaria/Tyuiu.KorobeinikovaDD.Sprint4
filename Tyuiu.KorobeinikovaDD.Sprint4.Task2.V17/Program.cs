// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint4.Task2.V17.Lib;
Random rnd = new Random();
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                        *");
Console.WriteLine("* Задание #2                                                                  *");
Console.WriteLine("* Вариант #17                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Подсчитать произведние нечетных элементов массивa                           *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

int len;
Console.WriteLine("Введите количество элементов массива: ");
len = Convert.ToInt32(Console.ReadLine());

int[] Array = new int[len];

for ( int i = 0; i <= len - 1; i++)
{
    Array[i] = rnd.Next(3, 9);
}

Console.WriteLine("Массив: ");
for (int i = 0; i <= len - 1; i++)
{
    Console.Write(Array[i] + "\t");
}
int res = ds.Calculate(Array);

Console.WriteLine();
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("Произведение = " + res);
Console.ReadKey();

