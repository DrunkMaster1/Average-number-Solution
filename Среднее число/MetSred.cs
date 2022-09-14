using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Среднее_число
{
    public class MetSred
    {

        public int b = 0;
        public int temp = 0;
        public int[] array = new int[10];
        public void sredNumber ()
        {
            Console.WriteLine("Введите 10 чисел");

            for (int i = 0; i < array.Length; i++)
            {
                int c = int.Parse(Console.ReadLine());
                array[b] = c;
                temp += array[b];
                if (c == 0) break;


            }
            int result = temp / Array.LastIndexOf(array);
            Console.Write("Среднее число: ");
            Console.WriteLine(result);

        }
    }
}
