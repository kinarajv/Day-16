using System;

class Program {
	static void Main() {
		string text = String.Empty;
		for (int i = 0; i < 100000000; i++) {
			text += "a";
			text += "b";
			text = text.Replace('a', 'c');
		}
	}
}
