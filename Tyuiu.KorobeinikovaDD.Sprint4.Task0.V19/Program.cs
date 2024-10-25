// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint4.Task0.V19.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                 *");
Console.WriteLine("* Задание #0                                                                  *");
Console.WriteLine("* Вариант #19                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Подсчитать произведние нечетных элементов массивa                           *");
Console.WriteLine("* {9, 5, 7, 4, 5, 3, 7, 8, 9 ,1}                                              *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

int[] Array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

Console.WriteLine("Массив = " + Array);

Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("Произведение = " + ds.GetMultOddArrEl(Array));
Console.ReadKey();
