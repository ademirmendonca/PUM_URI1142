using System;

namespace PUM_URI1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int primeiro = 1;
            
            for (int i = 1; i <= n; i++)
            {
                int segundo = primeiro + 1;
                int terceiro = primeiro + 2;

                Console.WriteLine(primeiro + " " + segundo + " " + terceiro +  " PUM");

                primeiro = primeiro + 4;
            }
        }
    }
}
