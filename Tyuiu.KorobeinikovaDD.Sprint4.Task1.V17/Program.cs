// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint4.Task1.V17.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Одномерные массивы (ввод c клавитатуры)                               *");
Console.WriteLine("* Задание #0                                                                  *");
Console.WriteLine("* Вариант #19                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Подсчитать сумму четных элементов массивa с клавитауры                      *");
Console.WriteLine("* {1, 7, 6, 3, 2, 5, 7, 6, 5, 4, 7, 6}                                        *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

int len;
Console.WriteLine("Введите количество элементов массива: ");
len = Convert.ToInt32(Console.ReadLine());

int[] Array = new int[len];

for (int i = 0; i <= len-1; i++)
{
    Console.Write("Введите значение " + i + " элемента массива: ");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i <= len-1; i++)
{
    Console.Write(Array[i] + "\t");
}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("Cумма = " + ds.Calculate(Array));
Console.ReadKey();
