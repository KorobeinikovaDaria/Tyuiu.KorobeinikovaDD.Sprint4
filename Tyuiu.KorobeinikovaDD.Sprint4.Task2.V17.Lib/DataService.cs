﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KorobeinikovaDD.Sprint4.Task2.V17.Lib
{
    public class DataService : ISprint4Task2V17
    {
        public int Calculate(int[] array)
        {
            int p = 1;
            for ( int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    p *= array[i];
                }
            }
            return p;
        }
    }
}
