// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint4.Task4.V14.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                                  *");
Console.WriteLine("* Задание #4                                                                  *");
Console.WriteLine("* Вариант #14                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Заменить все нечетные элементы массива на ноль                              *");
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
        Console.WriteLine($"Введите {i},{j} элемент массива: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
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

matrix = ds.Calculate(matrix);
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine($"{matrix[i, j]} \t ");
    }
}

Console.ReadKey();
