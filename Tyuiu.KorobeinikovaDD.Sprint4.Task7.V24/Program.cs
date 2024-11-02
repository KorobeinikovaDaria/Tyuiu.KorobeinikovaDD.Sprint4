// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint4.Task7.V24.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема:                                  *");
Console.WriteLine("* Задание #7                                                                  *");
Console.WriteLine("* Вариант #24                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("*                           *");
Console.WriteLine("*         *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

int n = 5;
int m = 3;
int[,] mtrx = new int[n, m];

string str = "651827384219648";
int index = 0;

Console.WriteLine("Массив: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{str[index]}\t");
        index++;
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("Произведение четных элементов = " + ds.Calculate(n, m, str));

Console.ReadKey();

