using System;

namespace DestructorExample
{
    class DestructorDemo
    {
        public DestructorDemo()
        {
            Console.WriteLine("Object created");
        }
        ~DestructorDemo()
        {
            Console.WriteLine("Object destroyed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DestructorDemo? obj1 = new DestructorDemo();
            DestructorDemo? obj2 = new DestructorDemo();

            obj1 = null;
            GC.Collect();
            GC.Collect();
            Console.ReadKey();
        }
    }
}
