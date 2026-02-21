using System;

namespace _01_Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 1, 1, 1, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            try
            {

                int num = int.Parse(Console.ReadLine());

                Console.WriteLine(num);
            }
            catch(FormatException)
            {
                Console.WriteLine("please input num");
            }
            catch (Exception)
            {

                throw;
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
