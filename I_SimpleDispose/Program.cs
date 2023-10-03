using System;

namespace DestructorExample
{
    class DestructorDemo : IDisposable
    {
        SimpleClass simple = new SimpleClass();

        public DestructorDemo()
        {
            Console.WriteLine("Object created");
        }

        public void Dispose()
        {
            simple = null;
        }

        ~DestructorDemo()
        {
            Dispose();
            Console.WriteLine("Object destroyed");
        }
    }

    class SimpleClass
    {
        ~SimpleClass()
        {
            Console.WriteLine("Simple Class Destroyed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DestructorDemo obj1 = new DestructorDemo();
            DestructorDemo obj2 = new DestructorDemo();

            obj1.Dispose();
            obj1 = null;

            Console.ReadKey();
            GC.Collect();
            GC.WaitForPendingFinalizers();  // Wait for the finalizers to run

            Console.ReadKey();
        }
    }
}
