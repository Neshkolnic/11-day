using System;
using System.Collections.Generic;

class ArrayHelper<T>
{
    private static Random random = new Random();

    public List<int> array;

    public ArrayHelper(int size, int minValue, int maxValue)
    {
        if (size <= 0)
        {
            throw new ArgumentException("Размер массива должен быть положительным числом");
        }

        array = new List<int>(size);
        for (int i = 0; i < size; i++)
        {
            array.Add(random.Next(minValue, maxValue + 1));
        }
    }

    public ArrayHelper(string values)
    {
        array = new List<int>();
        foreach (string value in values.Split(' '))
        {
            array.Add(int.Parse(value));
        }
    }

    public int CountOfFifty
    {
        get
        {
            int count = 0;
            foreach (int value in array)
            {
                if (value == 50)
                {
                    count++;
                }
            }
            return count;
        }
    }

    public int SumBeforeMaxAbsolute()
    {
        if (array.Count == 0)
        {
            throw new InvalidOperationException("Массив пуст");
        }

        int maxIndex = 0;
        int maxAbsValue = Math.Abs(array[0]);
        for (int i = 1; i < array.Count; i++)
        {
            int absValue = Math.Abs(array[i]);
            if (absValue > maxAbsValue)
            {
                maxAbsValue = absValue;
                maxIndex = i;
            }
        }

        int sum = 0;
        for (int i = 0; i < maxIndex; i++)
        {
            sum += Math.Abs(array[i]);
        }
        return sum;
    }

    public int[] GetArray()
    {
        return array.ToArray();
    }
}
