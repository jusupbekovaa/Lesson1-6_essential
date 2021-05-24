using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5_2
{
    public class MyArray
    {
        
        public void Max(params int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Максимальный элемент массива: {0}", max);
        }
        public void Min(params int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Минимальный элемент массива: {0}", min);
        }
        public int Sum(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
            
            
        }
        public void Average(params int[] array)
        {
            int average = 0 ;
            int sum = Sum(array);
            average = sum / (array.Length);
            Console.WriteLine("Средняя арифметическая элементов массива: {0}", average);
        }

        public void OddNumbers(params int[] array)
        {
            Console.WriteLine("Нечетные элементы массива: ");
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] % 2 != 0)
                {
                    Console.WriteLine("Элемент {0} индекса = {1}", i, array[i]);
                }
            }
        }
    }
}
