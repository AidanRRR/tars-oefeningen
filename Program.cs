using System;

namespace ctest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrTest = new int[] { 1, 50, 60, 80 };
            int som = 0;

            for (int i = 0; i < arrTest.Length; i++)
            {
                som += arrTest[i];
            }

            Console.WriteLine(som);
        }
    }
}
