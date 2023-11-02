using System;

namespace DestructorExample
{
	class DestructorDemo
	{
		public DestructorDemo()
		{
			Console.WriteLine("Constructor Object created");
		}
		~DestructorDemo()
		{
			Console.WriteLine("Destructor/Finalizers called, Object destroyed");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			
			InstanceCreator();
			DestructorDemo obj1 = new DestructorDemo();
			obj1 = new DestructorDemo();
			GC.Collect();
			GC.WaitForPendingFinalizers();
			GC.Collect();
			GC.Collect();
			GC.WaitForPendingFinalizers();
			GC.WaitForPendingFinalizers();
			Console.ReadKey();
		}
		static void InstanceCreator() {
			DestructorDemo obj1 = new DestructorDemo();
		}
	}
}
