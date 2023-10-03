using System;

namespace LOHDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] largeArray = new byte[100 * 1024];  // 100 KB

            Console.WriteLine("Large object allocated on the LOH.");
            Console.ReadKey();
        }
    }
}
