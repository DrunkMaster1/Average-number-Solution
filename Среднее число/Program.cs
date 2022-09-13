using System.Runtime.Serialization.Formatters;

internal class Program
{
    private static void Main(string[] args)
    {
        
        int[] nums = new int[4];
        
        Console.WriteLine("Введите 10 чисел, если необходимо остановить ввод, введите \"0\"");
        
        for (int i = 0; i<nums.Length; i++)
        {
            
            nums[i] = int.Parse(Console.ReadLine());
            if (Console.ReadLine() == "0") break;
            else if (nums[i] ==4) break;


        }
        

    }
}