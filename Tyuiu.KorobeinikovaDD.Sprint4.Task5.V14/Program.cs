// See https://aka.ms/new-console-template for more information
using System.Transactions;
using Tyuiu.KorobeinikovaDD.Sprint4.Task5.V14.Lib;
Random rnd = new Random();
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                                  *");
Console.WriteLine("* Задание #5                                                                  *");
Console.WriteLine("* Вариант #14                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Найти количество положительных элементов массива                            *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

int rows;
Console.WriteLine("Введите количество cтрок в массиве: ");
rows = Convert.ToInt32(Console.ReadLine());

int columns;
Console.WriteLine("Введите количество столбцов в массиве: ");
columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("*******************************************************************************");
int[,] matrix = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = rnd.Next(-5, 7);
    }
}

Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine($"{matrix[i, j]} \t ");
    }
}
Console.WriteLine();


Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");

Console.WriteLine("Количество = " + ds.Calculate(matrix));
Console.ReadKey();

