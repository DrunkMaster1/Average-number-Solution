using System;
using System.Runtime.Serialization.Formatters;
using Среднее_число;

internal class Program
{
    private static void Main(string[] args)
    {



     int b = 0;
     int temp = 0;
     int[] array = new int[10];
     
        Console.WriteLine("Введите 10 чисел");

        for (int i = 0; i < array.Length; i++)
        {
            int c = int.Parse(Console.ReadLine());
            array[b] = c;
            temp += array[b];
            if (c == 0) break;


        }
        int result = temp / LastIndexOf(array);
        Console.Write("Среднее число: ");
        Console.WriteLine(result);






        //MetSred c = new MetSred();
        //c.sredNumber();


    }
}