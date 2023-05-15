

﻿/* Пользователь вводит с клавиатуры M 
чисел. Посчитайте, сколько чисел больше 0 ввёл 
пользователь.
*/ 

void FullArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        System.Console.Write($"Введите {i} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

string PrintArray(int[] arr)
{
    string res = "";
    for(int i=0; i<(arr.Length)-1; i++)
    {
        res += Convert.ToString(arr[i]);
        res += ", ";
    }
    res += Convert.ToString(arr[(arr.Length)-1]);
    return res;
}

int CountArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0)
        {
            count++;
        }
    }
    return count;
}

System.Console.Write("Введите количесто чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] my_array = new int[size];
FullArray(my_array);
System.Console.WriteLine($"{PrintArray(my_array)} -> {CountArray(my_array)}");