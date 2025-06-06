﻿// See https://aka.ms/new-console-template for more information


public class Sort
{
    protected Random number = new Random();
    protected int[] array;

    public Sort(int size)
    {
        array = new int[size];
    }

    public void PrintArray()
    {
       Console.WriteLine(string.Join(", ", array));
    }

    public void PrintArray(int[] inputArray)
    {
        Console.WriteLine(string.Join(", ", inputArray));
    }

    public void FillArrayRand(int min = 0, int max = 100)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = number.Next(min, max);
        }
    }

    public void FillArrayRand(int[] inputArray, int min = 0, int max = 100)
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            array[i] = number.Next(min, max);
        }
    }

    public void FillArrayAscending()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }
    }
    public void FillArrayAscending(int[] inputArray)
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            array[i] = i;
        }
    }

    public void FillArrayDescending()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array.Length - i;
        }
    }

    public void FillArrayDescending(int[] inputArray)
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            array[i] = array.Length - i;
        }
    }
}

public class BubbleSort : Sort
{
    public BubbleSort(int size) : base(size)
    {
       
    }

    public void SortArray(int[] inputArray)
    {
        bool isChanged = true;
        for(int i = 0; i < inputArray.Length - 1; i++)
        {
            if (!isChanged) return;
            isChanged = false;
            for(int j = 0; j < inputArray.Length - 1 - i; j++)
            {
                if (inputArray[j] > inputArray[j + 1])
                {
                    (inputArray[j], inputArray[j+1]) = (inputArray[j+1], inputArray[j]);
                    isChanged = true;
                }
            }
        }
        return;
    }

    public void SortArray()
    {
        bool isChanged = true;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (!isChanged) return;
            isChanged = false;
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    isChanged = true;
                }
            }
        }
        return;
    }

}

public class InsertionSort : Sort
{
    public InsertionSort(int size) : base(size)
    {

    }

    public void SortArray()
    {
        int key = 0;
        for (int i = 1; i < array.Length; i++)
        {
            int j = i;
            key = array[j];
            while (j > 0 && array[j - 1] > key)
            {
                array[j] = array[j - 1];
                j--;
            }
            array[j] = key;
        }
    }
}

public class MergeSort : Sort
{
    public MergeSort(int size) : base(size)
    {

    }

    public void SortArray()
    {
        
        SortArray(array, 0, array.Length / 2 - 1);
        SortArray(array, array.Length, array.Length);

    }

    public void SortArray(int[] arr, int start, int end)
    {

    }
}
public class Program
{
    public static void Main(string[] args)
    {
        int arraySize = 20;

        InsertionSort sorter = new InsertionSort(arraySize);

        sorter.FillArrayRand();

        Console.WriteLine("Array before sorting: ");

        sorter.PrintArray();

        sorter.SortArray();
        Console.WriteLine("Array after sorting: ");

        sorter.PrintArray();

    }
}