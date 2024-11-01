// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint4.Task6.V26.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                 *");
Console.WriteLine("* Задание #6                                                                  *");
Console.WriteLine("* Вариант #26                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Используя класс Array, выведите элементы массива                            *");
Console.WriteLine("* [Тюмень, Тамбов, Томск, Омск, Орёл], длина которых больше 5 символов        *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

string[] Array = {"Тюмень", "Тамбов", "Томск", "Омск", "Орёл"};

Console.WriteLine("Массив: ");
for (int j = 0; j < Array.Length; j++)
{
    Console.WriteLine($"{Array[j]} \t ");
}

Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
Array = ds.Calculate(Array);
for (int j = 0; j < Array.Length; j++)
{
    Console.WriteLine($"{Array[j]} \t ");
}


Console.ReadKey();
