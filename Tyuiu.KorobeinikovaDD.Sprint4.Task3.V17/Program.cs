// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint4.Task3.V17.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                                  *");
Console.WriteLine("* Задание #3                                                                  *");
Console.WriteLine("* Вариант #17                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Подсчитать сумму элементов в четвертом столбце массивa                      *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

int[,] Array = new int[5, 5]{ { 6, 4, 2, 2, 1 },
                              { 3, 6, 5, 4, 1 },
                              { 5, 2, 3, 1, 6 },
                              { 8, 8, 4, 5, 3 },
                              { 7, 4, 5, 1, 6 } };

int rows = Array.GetUpperBound(0) + 1;
int columns = Array.Length / rows;

Console.WriteLine("Массив = ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine($"{Array[i, j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("Сумма = " + ds.Calculate(Array));
Console.ReadKey();
