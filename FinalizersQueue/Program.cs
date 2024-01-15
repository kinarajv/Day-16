class Program
{
	static void Main(string[] args)
	{
		int count = 0;

		while (!Console.KeyAvailable)
			new MyObject(count++);

		Console.WriteLine("Terminating process...");
	}
}
class MyObject
{
	private int index;

	public MyObject(int index)
	{
		this.index = index;
		Console.WriteLine($"Constructed object {index} in gen {GC.GetGeneration(this)}");
	}

	~MyObject()
	{
		Thread.Sleep(500);
		Console.WriteLine($"Finalized object {index} in gen {GC.GetGeneration(this)}");
	}
}