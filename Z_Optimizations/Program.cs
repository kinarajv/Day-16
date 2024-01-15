#region Gen0 optimizations

using System.Collections;
using System.Text;

void OptimizeStrBuilder()
{
	//problem
	var s = new StringBuilder();
	for (int i = 0; i < 10000; i++)
		s.Append(i.ToString() + "KB");

	//solution
	var sb = new StringBuilder();
	for (int i = 0; i < 10000; i++)
	{
		sb.Append(i);
		sb.Append("KB");
	}

}
void OptimizeList() 
{
	//Problem
	List<int> myList = new List<int>();
	myList.Add(4);
	//using the myList.. long process...
	myList = new List<int>();
	//using the myList.. long process...
	myList.Add(3);
	
	
	//Solution
	List<int> myList2 = new List<int>();
	myList2.Add(4);
	//using the myList.. long process...
	myList2.Clear();
	//using the myList.. long process...
	myList2.Add(3);
	
	
}
void OptmList()
{
	//problem
	var array = new ArrayList();
	for (int i = 0; i < 10000; i++)
		array.Add(i);

	//solution
	var list = new List<int>();
	for (int i = 0; i < 10000; i++)
		list.Add(i);
}

void ObjectsInstanciation()
{
	//problem
	MyClass myclass = new MyClass();
	//lots of other code...
	UseTheObject(myclass);



	//solution
	MyClass obj = new MyClass();
	UseTheObject(obj);
}
#endregion

#region Size Strategies

void ReduceSizeToKeepShortLived()
{
	//problem
	var buffer = new int[32768];
	for (int i = 0; i < buffer.Length; i++)
		buffer[i] = GetByte(i);

	//solution
	var otherBuffer = new byte[32768];
	for (int i = 0; i < otherBuffer.Length; i++)
		otherBuffer[i] = GetByte(i);
}

void IncreaseSizeToKeepLongLived()
{
	//problem
	var list = new ArrayList();
	//lots of other code!
	UseTheList(list);

	//solution
	var list2 = new ArrayList(85190);
	//lots of other code!
	UseTheList(list2);

}
#endregion
#region empty definitions

//methods created only for completing the examples!

void UseTheList(ArrayList list)
{
	throw new NotImplementedException();
}
void UseTheObject(object o)
{
	throw new NotImplementedException();
}
byte GetByte(int i)
{
	throw new NotImplementedException();
}

class Pair
{
	public Pair(int x, int y)
	{
		throw new NotImplementedException();
	}
}

public class MyClass
{
}


#endregion