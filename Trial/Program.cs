using System.Text;

class Program
{
	static void Main() 
	{
		StringBuilder sb = new();
		int iteration = 1000000000;
		for(int i = 0; i < iteration; i++) 
		{
			sb.Append("a");
			sb.Append("b");
			sb.Append("c");
		}
	}
}